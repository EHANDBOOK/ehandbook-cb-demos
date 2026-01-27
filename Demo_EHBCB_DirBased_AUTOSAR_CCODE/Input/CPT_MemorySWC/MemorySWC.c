#include "BswM.h"
#include "EcuM.h"

#define TEST_VALUE             0x3333
#define MEM_TEST_CODE          0xA0

volatile uint8 memTestStarted = 0;
volatile uint8 memTestPassed = 0;

#define RE_MEM_SWC_START_SEC_CODE

#include "Rte_MemorySWC.h"

/*
Runnable: RE_MemSWC

Receives the mem test trigger from the MasterSWC, writes in memory a test code (0x3333) and restart the ECU.
During shutdown, the value of the PIM is written in memory and it is restored during startup
*/
FUNC(void, MasterSWC_CODE) RE_MemSWC(void)
{
    uint8 memTestTrigger = 0x00;
    uint8 memTestData = 0x00;
    /* Only once, after startup, it checks if the PIM value is the expected one */
    if ((memTestPassed == FALSE) && (memTestStarted == FALSE))
    {
        /* If the PIM has been restored with the expected value during startup, then communicate to the MasterSWC that the test is passed */
        Rte_Write_PPort_PimValue_TestResult(Rte_CPim_MemorySWC_PIM_0);
        /* The PIM Value is modified */
        Rte_CPim_MemorySWC_PIM_0 = 0;
        /* The block is set as changed, so that it will be written during the shutdown procedure */
        Rte_Call_RPort_NvMService_SetRamBlockStatus(TRUE);
        memTestPassed = TRUE;
    }
    /* Reads the trigger signal for the memtest from the MasterSWC */
    Rte_Read_RPort_TriggerMemTest_TestCode(&memTestTrigger);
    /* Reads the data the tester passed along with the testcode */
    Rte_Read_RPort_TriggerMemTest_Data_TestCode_Data(&memTestData);
    /* If the received trigger signal is equal to the MEM_TEST_CODE, then the memtest will start */
    if (memTestTrigger == MEM_TEST_CODE)
    {
        /* The PIM Value is modified */
        Rte_CPim_MemorySWC_PIM_0 = memTestData;
        /* The block is set as changed, so that it will be written during the shutdown procedure */
        Rte_Call_RPort_NvMService_SetRamBlockStatus(TRUE);
        /* Update the variable memTestStarted in order to keep track that the test has been started */
        memTestStarted = TRUE;
    }
    if (memTestStarted == TRUE)
    {
        /* If the test is started, the block has been marked and therefore the shutdown can be triggered */
        EcuM_SelectShutdownTarget(ECUM_SHUTDOWN_TARGET_RESET, 0u);
        BswM_RequestMode(0u, 1u);
    }
}

#define RE_MEM_SWC_STOP_SEC_CODE

#include "MemorySWC_MemMap.h"