#include "Rte_E2ESWC.h"

#include "E2ESWC.h"

/*
Runnable: RE_TestE2E

Communicates with MasterSWC code on Port 'E2E_Rx' and 'E2E_Tx'.

When receive correctly protected data ('0x01'), respond with protected data
('0x02').

When receive incorrectly protected data ('0x03'), acknowledge with protected
data ('0x04').
*/
FUNC(void, MasterSWC_CODE) RE_TestE2E(void)
{
    E2EImplementationDataType E2E_InterSWC_TestRx;
    E2EImplementationDataType E2E_InterSWC_TestTx;
    uint8 directAccess_E2E_InterSWC_TestRx;
    uint32 E2EPW_error = E2E_E_OK;

    /* Get port data item, and call E2E Protection Wrapper. */
    Rte_Read_RPort_E2E_Rx_Data(&directAccess_E2E_InterSWC_TestRx);
    E2EPW_error = E2EPW_Read_E2E_E2E_Rx(&E2E_InterSWC_TestRx);

    /* When received initial protected 1, send 2. */
    if ((1u == E2E_InterSWC_TestRx.Impl_Data) && (E2EPW_error == (E2E_P02STATUS_INITIAL << 24)))
    {
        E2E_InterSWC_TestTx.Impl_Data = 2u;
        E2EPW_Write_E2E_E2E_Tx(&E2E_InterSWC_TestTx);
    }

        /* When received invalid 3, send 4. Need to access data in port because E2EPW will
        not read with error. */
    else if ((3u == directAccess_E2E_InterSWC_TestRx) && (E2E_E_OK != E2EPW_error))
    {
        E2E_InterSWC_TestTx.Impl_Data = 4u;
        E2EPW_Write_E2E_E2E_Tx(&E2E_InterSWC_TestTx);
    }
}



/* E2E Protection Wrapper to read data from the relevant ports for E2E_Rx then check data  */
FUNC(uint32, E2E_InterSWC_2) E2EPW_Read_E2E_E2E_Rx(E2EImplementationDataType *data)
{
    uint32 E2EPW_error = E2E_E_OK;
    Std_ReturnType E2E_error;
    E2EImplementationDataType data_tmp;

    /*Read the data*/
    Rte_Read_RPort_E2E_Rx_Alive_Cnt(&(data_tmp.Impl_Alive_Cnt));
    Rte_Read_RPort_E2E_Rx_CKS(&(data_tmp.Impl_CKS));
    Rte_Read_RPort_E2E_Rx_Data(&(data_tmp.Impl_Data));

    E2E_P02ReceiverState_E2ESWC.NewDataAvailable = TRUE;

    /*Data serialization can be done here if necessary */

    /* Check if the data received is correct (Checksum and alive counter)*/
    E2E_error = E2E_P02Check(&E2E_P02_StaticCfg_E2ESWC, &E2E_P02ReceiverState_E2ESWC, (uint8 *) &data_tmp);

    if ((E2E_P02ReceiverState_E2ESWC.Status == E2E_P02STATUS_OK) ||
        (E2E_P02ReceiverState_E2ESWC.Status == E2E_P02STATUS_INITIAL) ||
        (E2E_P02ReceiverState_E2ESWC.Status == E2E_P02STATUS_OKSOMELOST))
    {
        *data = *(E2EImplementationDataType *) &data_tmp;
    }

    return ((RTE_E_OK) | (E2EPW_error << 8) | (E2E_error << 16) | (E2E_P02ReceiverState_E2ESWC.Status << 24));
}

/* E2E Protection Wrapper to protect data then write to the relevant ports for E2E_Tx */
FUNC(uint32, E2E_InterSWC_1) E2EPW_Write_E2E_E2E_Tx(E2EImplementationDataType *data)
{
    uint32 E2EPW_error = E2E_E_OK;
    Std_ReturnType E2E_error;

    /* Call E2E library function to protect the data that will be transmitted over the port*/
    E2E_error = E2E_P02Protect(&E2E_P02_StaticCfg_E2ESWC, &E2E_P02SenderState_E2ESWC, (uint8 *) data);

    /* Transmit the data with alive counter and calculated CKS over the port */
    Rte_Write_PPort_E2E_Tx_Alive_Cnt(data->Impl_Alive_Cnt);
    Rte_Write_PPort_E2E_Tx_CKS(data->Impl_CKS);
    Rte_Write_PPort_E2E_Tx_Data(data->Impl_Data);

    return ((RTE_E_OK) | (E2EPW_error << 8) | (E2E_error << 16));
}
