#include "Rte_DiagnosticSWC.h"
#include "Rte_DiagnosticSWC_Type.h"
#include "Rte_Dem_Type.h"

#define SWC_COMPARE_KEY_FAILED 11

/* Seed values for Service 0x27 */
const uint8 DcmSeed[2] = {0x11, 0x11};

/* Key values for Service 0x27 */
const uint8 DcmKey[2] = {0x10, 0x10};

Dcm_DataArrayTypeUint8_DspData_ASW_VER_F189Type dataF189 = {0x10, 0x9, 0x8, 0x7, 0x6, 0x5, 0x4, 0x3};

Dcm_DataArrayTypeUint8_DspData_ASW_VER_F189Type rec_dataF189 = {0x00, 0x00, 0x00, 0x0, 0x0, 0x0, 0x0, 0x0};

/* Example Dem data read function */
FUNC(Std_ReturnType, DCM_APPL_CODE) RTE_VehicleSpeed_Data(uint8 *Buffer)
{
    static uint8 VehicleSpeed_Data = 10;
    *Buffer = VehicleSpeed_Data;
    return E_OK;
}

/* Example Dem data read function */
FUNC(Std_ReturnType, DCM_APPL_CODE) RTE_EngineSpeed_Data(uint8 *Buffer)
{
    static uint8 EngineSpeed_Data = 20;
    *Buffer = EngineSpeed_Data;
    return E_OK;
}

/* Diagnostic Service Processing service */
FUNC(Std_ReturnType, TestDiag_CODE) Swc_DSP_SEC_LEV_L1_CK_func(P2CONST(uint8, AUTOMATIC, RTE_APPL_DATA)Key,
                                                               VAR(Dcm_OpStatusType, AUTOMATIC) OpStatus,
                                                               CONSTP2VAR(Dcm_NegativeResponseCodeType, AUTOMATIC,
                                                                          RTE_APPL_DATA) ErrorCode)
{
    Std_ReturnType retValue = RTE_E_OK;

    if ((Key[0] != DcmKey[0]) || (Key[1] != DcmKey[1]))
    {
        retValue = SWC_COMPARE_KEY_FAILED;
    } else { /* Do nothing. Key is correct. */ }

    return (retValue);
}

/* Diagnostic Service Processing service */
FUNC(Std_ReturnType, TestDiag_CODE) Swc_DSP_SEC_LEV_L1_GS_func(VAR(Dcm_OpStatusType, AUTOMATIC) OpStatus,
                                                               CONSTP2VAR(uint8, AUTOMATIC, RTE_APPL_DATA) Seed,
                                                               CONSTP2VAR(Dcm_NegativeResponseCodeType, AUTOMATIC,
                                                                          RTE_APPL_DATA) ErrorCode)
{
    Std_ReturnType retValue = RTE_E_OK;
    *Seed = DcmSeed[0];
    *(Seed + 1) = DcmSeed[1];
    return (retValue);
}

/*
Runnable: RE_Diag_Periodic

Example periodic diagnostic runnable

For this example, the runnable updates a Data Identifier
*/
FUNC (void, DiagnosticSWC_CODE) RE_Diag_Periodic/* return value & FctID */(void)
{

    Rte_Read_RPort_Did_ASW_VER_F189_Data((uint8 *const) &rec_dataF189);
    if (rec_dataF189[0] != 0)
    {
        Rte_Write_PPort_Did_ASW_VER_F189_Data((uint8 *const) &rec_dataF189);
    } else
    {
        Rte_Write_PPort_Did_ASW_VER_F189_Data((uint8 *const) &dataF189);
    }



}

/*
Runnable: RE_Dem_Periodic

Example periodic dem runnable

For this example, if a new test code has been received from the tester (0x31/0x32),
the Event Status is updated accordingly.
*/
FUNC (void, DiagnosticSWC_CODE) RE_Dem_Periodic(void)
{
    uint8 testPermission = 0;
    static uint8 startup = 0;
    static uint8 Dem_test_case = 0, Dem_test_case_old = 0;

    if (startup == 0)
    {
        Rte_Call_RPort_DemOperationCycle_0_SetOperationCycleState(DEM_CYCLE_STATE_START);
        Rte_Call_RPort_DemOperationCycle_OBD_SetOperationCycleState(DEM_CYCLE_STATE_START);
        startup = 1;
    }

    Dem_test_case = Rte_IRead_RE_Dem_Periodic_RPort_TriggerDiagTest_TestCode();

    if (Dem_test_case != Dem_test_case_old)
    {
        switch (Dem_test_case)
        {
            case 0x31:
                Rte_Call_RPort_Monitor_Event_0_SetEventStatus(DEM_EVENT_STATUS_FAILED);
                break;
            case 0x32:
                Rte_Call_RPort_Monitor_Event_0_SetEventStatus(DEM_EVENT_STATUS_PASSED);
                break;
            case 0x33:
                Rte_Call_RPort_Monitor_OBD_Event_SetEventStatus(DEM_EVENT_STATUS_FAILED);
                break;
            case 0x34:
                Rte_Call_RPort_Monitor_OBD_Event_SetEventStatus(DEM_EVENT_STATUS_PASSED);
                break;
            default:
                break;
        }
        Dem_test_case_old = Dem_test_case;
    }

    Rte_Call_RPort_FIMFID_0_GetFunctionPermission(&testPermission);
}
