#include "Rte_Type.h"
#include "Rte_Dcm_Type.h"

extern FUNC(Std_ReturnType,DCM_APPL_CODE) RTE_VehicleSpeed_Data (uint8* Buffer);

extern Std_ReturnType RTE_EngineSpeed_Data(uint8* Buffer);

FUNC(Std_ReturnType, Diag_SWC_CODE) Swc_DSP_SEC_LEV_L1_CK_func(P2CONST(uint8, AUTOMATIC, RTE_APPL_DATA) Key,
                                                               VAR(Dcm_OpStatusType, AUTOMATIC) OpStatus,
                                                               CONSTP2VAR(Dcm_NegativeResponseCodeType, AUTOMATIC, RTE_APPL_DATA) ErrorCode);
FUNC(Std_ReturnType, Diag_SWC_CODE) Swc_DSP_SEC_LEV_L1_GS_func(VAR(Dcm_OpStatusType, AUTOMATIC) OpStatus,
                                                               CONSTP2VAR(uint8, AUTOMATIC, RTE_APPL_DATA) Seed,
                                                               CONSTP2VAR(Dcm_NegativeResponseCodeType, AUTOMATIC, RTE_APPL_DATA) ErrorCode);