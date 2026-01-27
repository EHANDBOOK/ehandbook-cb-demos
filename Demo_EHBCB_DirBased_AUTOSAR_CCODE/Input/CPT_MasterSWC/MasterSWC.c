#include "WdgM_Bsw_User.h"
#include "Rte_MasterSWC.h"

#include "MemorySWC.h"
#include "MasterSWC.h"

/*Target Specific Settings*/
#include "EVE_SystemClock.h"
#define TARGET_CLOCK_GETVALUE  VECU_SystemClock_GetValue
/*End Target Specific settings */

#define TEST_CAN_SIMPLE_COM    0x01u
#define TEST_CANFD_SIMPLE_COM  0x02u
#define TEST_MEMORY            0xA0u
#define TEST_E2E               0x21u
#define TEST_WDG_TRAP          0x30u
#define TEST_TIME              0x50u

#define TEST_DIAG_1            0x31
#define TEST_DIAG_2            0x32
#define TEST_DIAG_3            0x33
#define TEST_DIAG_4            0x34

#define E2E_TEST_CODE_RX_OK 0x02u
#define E2E_TEST_CODE_TXBAD_OK 0x04u

#define E2E_TEST_STEP_CHECK_TXRX 0u
#define E2E_TEST_STEP_CHECK_BAD_TX 1u
#define E2E_TEST_STEP_FINISH 2u


/* Two flags for calculating time between runnable calls */
volatile timerBegin = FALSE;
volatile timerRunning = FALSE;
uint32 startClock, endClock;

/*
Runnable: RE_RunTest

Reads the test code on Port 'TestCode', runs the relevant test:

Com: TEST_CAN_SIMPLE_COM = 0x01u
Mem: TEST_MEMORY = 0xA0u
E2E: TEST_E2E = 0x21
*/
FUNC(void, MasterSWC_CODE) RE_RunTest(void)
{
    uint8 testCode   = 0x00;
    uint8 testData   = 0x00;
    uint8 pimValue   = 0x00;
    uint8 testCodeFD = 0x00;

    /* Read the test code received on CAN and CAN-FD*/
    Rte_Read_RPort_TestCode_TestCode(&testCode);
    Rte_Read_RPort_TestCodeFD_TestCode_FD(&testCodeFD);


    /*
    Com Test - checks that a message can be received and sent from/to the tester via CAN-FD
    (inter-ECU).

    When test code on Port 'TestCodeFD' is TEST_CANFD_SIMPLE_COM (0x01), transmit result
    TEST_CANFD_SIMPLE_COM on Port 'TestResult'
    */
    {
        if(testCodeFD == TEST_CANFD_SIMPLE_COM)
        {
            /* If the test code correspond to the simple CAN-FD Communication test, echo the test code in the CAN signal*/
            Rte_Write_MasterSWC_PPort_TestResultFD_TestResult_FD(TEST_CANFD_SIMPLE_COM);
        }
    }

    /*
    Com Test - checks that a message can be received and sent from/to the tester
    (inter-ECU).

    When test code on Port 'TestCode' is TEST_CAN_SIMPLE_COM (0x01), transmit result
    TEST_CAN_SIMPLE_COM on Port 'TestResult'
    */
    {
        if(testCode == TEST_CAN_SIMPLE_COM)
        {
            /* If the test code correspond to the simple CAN Communication test, echo the test code in the CAN signal*/
            Rte_Write_PPort_TestResult_TestResult(TEST_CAN_SIMPLE_COM);
            Rte_Write_PPort_TestResult_Data_TestResult_Data(0x00);
        }
    }

    /*
    Diag Test - Send test codes TEST_DIAG_1 (0x31) / TEST_DIAG_2 (0x32) to the
    DiagnosticSWC when they are received. These codes trigger the configuration
    of the Diag stack according to the test. Success is then detected by the tester
    over UDS.
    */
    {
        if ((testCode == TEST_DIAG_1) || (testCode == TEST_DIAG_2) || (testCode == TEST_DIAG_3) || (testCode == TEST_DIAG_4))
        {
            Rte_Write_PPort_TriggerDiagTest_TestCode(testCode);
        }
    }

    /*
    Mem Test - checks that a PIM written to NvM is readable after ECU restart.

    When test code on Port 'TestCode' is TEST_MEMORY (0xA0), request PIM write and
    shutdown from MemorySWC. RE_RunTest runnable is also called on startup, so check
    if the PIM value exists can be read. If so the PIM must have successfully
    written, so transmit result TEST_MEMORY (0xA0) on Port 'TestResult'.
    */
    {
        uint8 previousPimValue = 0;
        static volatile uint8 readyToSendResult = TRUE;
        if(testCode == TEST_MEMORY)
        {
            Rte_Read_RPort_TestCode_Data_TestCode_Data(&testData);
            /* If the test code correspond to the Memory Test, trigger the test in the MemorySWC */
            Rte_Write_PPort_TriggerMemTest_TestCode(TEST_MEMORY);
            /* Write the data the tester has passed to the MemSWC to store in memory*/
            Rte_Write_PPort_TriggerMemTest_Data_TestCode_Data(testData);
        
        }
        /* Receive the value of the PIM from the MemorySWC in order to check if the memory test is passed or not */
        Rte_Read_RPort_PimValue_TestResult(&pimValue);
        if((pimValue != previousPimValue) && (pimValue != 0) && (readyToSendResult == TRUE))
        {
            /* Write back the PIM value. The tester expects to receive the value 0xA0 to set the test as passed. */
            Rte_Write_PPort_TestResult_TestResult(TEST_MEMORY);
            Rte_Write_PPort_TestResult_Data_TestResult_Data(pimValue);
            previousPimValue = pimValue;
            readyToSendResult = FALSE;
        }
    }




    /*
    E2E Test - checks that a protected message can be receive and sent from/to
    the E2ESWC (intra-ECU).

    When test code on Port 'TestCode' is TEST_E2E (0x21), transmit protected
    data ('0x01') to the E2ESWC via E2EPW function. This tests E2E protect.

    When protected data ('0x02') is receive from E2ESWC, transmit incorrectly
    protected data ('0x03') to the E2ESWC via E2EPW function. This tests the E2E
    check function can detect problems.

    When protected data ('0x04') is receive from E2ESWC this signals that E2ESWC
    acknowledge the incorrectly protected data ('0x03'). Therefore the test has
    complete. Send test result TEST_E2E (0x21) on Port 'TestResult'.
    */
    {


        /* E2E test, receive protected then transmit bad data */
        E2EImplementationDataType E2E_Test_Rx;
        uint32 E2EPW_error = E2E_E_OK;

        static uint8 e2eTestStep = E2E_TEST_STEP_CHECK_TXRX;

        switch (e2eTestStep)
        {
            case E2E_TEST_STEP_CHECK_TXRX:
                /* E2E test, send protected 1 */
                if (testCode == TEST_E2E)
                {
                    E2EImplementationDataType E2E_Test_Tx;
                    E2E_Test_Tx.Impl_Data = 0x01;
                    E2EPW_Write_ASWC_E2E_Tx(&E2E_Test_Tx);
                    e2eTestStep++;
                }
                break;

            case E2E_TEST_STEP_CHECK_BAD_TX:
                /* E2E test, receive protected (initial) 2, send incorrectly protected 3 bypass the E2EPW function */
                E2EPW_error = E2EPW_Read_ASWC_E2E_Rx(&E2E_Test_Rx);
                if ((E2E_TEST_CODE_RX_OK == E2E_Test_Rx.Impl_Data) && (E2EPW_error == (E2E_P02STATUS_INITIAL << 24)))
                {
                    E2EImplementationDataType E2E_Test_BadTx;
                    E2E_Test_BadTx.Impl_Data = 3u;
                    E2E_Test_BadTx.Impl_CKS = 0;
                    E2E_Test_BadTx.Impl_Alive_Cnt = 0;

                    Rte_Write_PPort_E2E_Tx_Alive_Cnt(E2E_Test_BadTx.Impl_Alive_Cnt);
                    Rte_Write_PPort_E2E_Tx_CKS(E2E_Test_BadTx.Impl_CKS);
                    Rte_Write_PPort_E2E_Tx_Data(E2E_Test_BadTx.Impl_Data);
                    e2eTestStep++;
                }
                break;

            case E2E_TEST_STEP_FINISH:
                E2EPW_error = E2EPW_Read_ASWC_E2E_Rx(&E2E_Test_Rx);
                /* E2E test, receive acknowledgement of bad data. E2E Test sequence complete */
                if ((E2E_TEST_CODE_TXBAD_OK == E2E_Test_Rx.Impl_Data) && (E2E_E_OK == E2EPW_error))
                {
                    Rte_Write_PPort_TestResult_TestResult(TEST_E2E);
                    Rte_Write_PPort_TestResult_Data_TestResult_Data(0x00);
                    e2eTestStep++;
                }
                break;
        }
    }

    /*
    Wdg Test - checks that the WdgM can detect a missed deadline supervision
    checkpoint. The checkpoints are configured with max deadline of 1 second.

    When test code on Port 'TestCode' is TEST_WDG_TRAP (0x31) call the start
    checkpoint, loop for 1 second, then call the end checkpoint.

    If the WdgM global state was OK before and is stopped after, then wdgM
    correctly detected the missed checkpoint so send test result
    TEST_WDG_TRAP (0x31) on Port 'TestResult'.
    */
    {
        if (testCode == TEST_WDG_TRAP)
        {
            // Call start checkpoint and check status is OK
            WdgM_Rb_Cfg_IndicateCheckPointReached_WdgRE_StartCheckpoint();
            if (Rte_Mode_RPort_WdgGlobalMode_currentMode() == RTE_MODE_WdgM_Mode_SUPERVISION_OK)
            {
                // Block for 1 second and call end checkpoint
                const vrtaUInt startClock = TARGET_CLOCK_GETVALUE();
                while ((vrtaUInt) (TARGET_CLOCK_GETVALUE() - startClock) < (vrtaUInt) 1100);
                WdgM_Rb_Cfg_IndicateCheckPointReached_WdgRE_EndCheckpoint();

                // Check that the status is now stopped.
                if (Rte_Mode_RPort_WdgGlobalMode_currentMode() == RTE_MODE_WdgM_Mode_SUPERVISION_STOPPED)
                {
                    Rte_Write_PPort_TestResult_TestResult(TEST_WDG_TRAP);
                    Rte_Write_PPort_TestResult_Data_TestResult_Data(0x00);
                }
            }
        }
    }
    
    /*
    Timing Test Trigger - if test code for RTE Timing test received then set a flag to start a timer 
    */    
    {
        if (testCode == TEST_TIME)
        {
            timerBegin = TRUE;
        }
    }
}

/*
    Timing Test - check that the time elapsed between the two executions of a periodic 
    runnable is that of what is expected.

    When 0x50 is received on port TestCode a flag is enabled to signal that the periodic 
    runnable should get a start value of the clock.

    On the next entry to the runnable it should then get the final clock value and calc
    the time between calls.

    If the result is in the range 9-11ms then the test code is sent back to the tester.
*/   
FUNC(void, MasterSWC_CODE) RE_TimeTest(void)
{
    /* On entry to runnable we check if we have already got the start checkpoint*/
    if( TRUE == timerRunning)
    {
        endClock = TARGET_CLOCK_GETVALUE();
        /* calc time between runnable execution */
        uint32 finalTime = endClock - startClock;
        /* Here we want to make sure the runnable is being called every 9ms-11ms */
        if( finalTime > 9 && finalTime < 11)
        {
            Rte_Write_PPort_TestResult_TestResult(TEST_TIME);
        }
        timerRunning = FALSE;
    }
    /* When RE_RunTest receives Time test code it enables this flag to get a start point*/
    if( TRUE == timerBegin)
    {
        startClock = TARGET_CLOCK_GETVALUE();
        timerRunning = TRUE;
        timerBegin = FALSE;
    }

}

/* E2E Wrapper to protect data then write to the relevant ports for E2E_Tx */
FUNC(uint32, E2E_InterSWC_1) E2EPW_Write_ASWC_E2E_Tx(E2EImplementationDataType *data)
{
    uint32 E2EPW_error = E2E_E_OK;
    Std_ReturnType E2E_error;

    /*Data serialization can be done here if necessary */

    /* Call E2E library function to protect the data that will be transmitted over the port*/
    E2E_error = E2E_P02Protect(&E2E_P02_StaticCfg_ASWC, &E2E_P02SenderState_ASWC, (uint8 *) data);

    /* Transmit the data with alive counter and calculated CKS over the port */
    Rte_Write_PPort_E2E_Tx_Alive_Cnt(data->Impl_Alive_Cnt);
    Rte_Write_PPort_E2E_Tx_CKS(data->Impl_CKS);
    Rte_Write_PPort_E2E_Tx_Data(data->Impl_Data);

    return ((RTE_E_OK) | (E2EPW_error << 8) | (E2E_error << 16));
}

/* E2E Wrapper to read data from the relevant ports for E2E_Rx then check data  */
FUNC(uint32, E2E_InterSWC_2) E2EPW_Read_ASWC_E2E_Rx(E2EImplementationDataType *data)
{
    uint32 E2EPW_error = E2E_E_OK;
    Std_ReturnType E2E_error;
    E2EImplementationDataType data_tmp;

    /*Read the data*/
    Rte_Read_RPort_E2E_Rx_Alive_Cnt(&(data_tmp.Impl_Alive_Cnt));
    Rte_Read_RPort_E2E_Rx_CKS(&(data_tmp.Impl_CKS));
    Rte_Read_RPort_E2E_Rx_Data(&(data_tmp.Impl_Data));

    E2E_P02ReceiverState_ASWC.NewDataAvailable = TRUE;

    /*Data serialization can be done here if necessary */

    /* Check if the data received is correct (Checksum and alive counter)*/
    E2E_error = E2E_P02Check(&E2E_P02_StaticCfg_ASWC, &E2E_P02ReceiverState_ASWC, (uint8 *) &data_tmp);

    if ((E2E_P02ReceiverState_ASWC.Status == E2E_P02STATUS_OK) ||
        (E2E_P02ReceiverState_ASWC.Status == E2E_P02STATUS_INITIAL) ||
        (E2E_P02ReceiverState_ASWC.Status == E2E_P02STATUS_OKSOMELOST))
    {
        *data = *(E2EImplementationDataType *) &data_tmp;
    }

    return ((RTE_E_OK) | (E2EPW_error << 8) | (E2E_error << 16) | (E2E_P02ReceiverState_ASWC.Status << 24));
}
