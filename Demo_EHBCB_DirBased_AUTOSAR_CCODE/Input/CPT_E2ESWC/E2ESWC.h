#include "E2E.h"

extern FUNC(uint32, E2E_InterSWC_2) E2EPW_Read_E2E_E2E_Rx(E2EImplementationDataType *data);
extern FUNC(uint32, E2E_InterSWC_1) E2EPW_Write_E2E_E2E_Tx(E2EImplementationDataType *data);

/*Definition of return values of the E2E Wrapper Read function - START*/
/*    byte 3  |  byte 2 |  byte 1 |  byte 0  */
/**********************************************************************
 * 	  byte 0 -  Status of Rte_Read function - always RTE_E_OK == 0x00 in this case
 * 	  byte 1 -  Status of runtime checks done within E2E Protection Wrapper function - No check is implemented in this example - Status OK == 0x01
 *    byte 2 -  Return value of E2E_P02Check function
 *    byte 3 -  The value of E2E_P02ReceiverStatusType Enumeration, representing the result of the verification of the Data in E2E Profile 02, determined by the Check function
 * ********************************************************************/

#define    E2EPW_P02STATUS_NONEWDATA    	  0x1000100
#define    E2EPW_P02STATUS_WRONGCRC      	  0x2000100
#define    E2EPW_P02STATUS_INITIAL      	  0x4000100
#define    E2EPW_P02STATUS_REPEATED     	  0x8000100
#define    E2EPW_P02STATUS_OK           	 0x10000100
#define    E2EPW_P02STATUS_OKSOMELOST  	 	 0x20000100
#define    E2EPW_P02STATUS_WRONGSEQUENCE 	 0x40000100
/*Definition of return values of the E2E Wrapper Read function - END*/

/*E2E Profile 2 configuration variables - START*/
static E2E_P02CheckStateType E2E_P02ReceiverState_E2ESWC=
{
    0,
	0,
	TRUE,
	FALSE,
	0,
	E2E_P02STATUS_NONEWDATA,
	0,
	0
};

/*E2E Profile 2 configuration variables - START*/
static E2E_P02ProtectStateType E2E_P02SenderState_E2ESWC={0x00};

static const E2E_P02ConfigType E2E_P02_StaticCfg_E2ESWC =
{
		24, 	/* DataLength  in bits*/
		{ 78, 206, 124, 3, 132, 58, 100, 23, 154, 160, 136, 220, 127, 93, 37, 11},	/* DataIDList[16] */
		1	/* MaxDeltaCounterInit */
};
/*E2E Profile 2 configuration variables - END*/
