<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE MSRSW PUBLIC "-//ASAM//DTD FUNCTIONAL SPECIFICATION EXCHANGE FORMAT:V1.1.0:LAI:IAI:XML:ML.FSX110.DTD//EN" "fsx_v1_1_0.ml.dtd">
<!--FS2FSX Converter Version 1.0 -->
<MSRSW>
	<CATEGORY>FSX</CATEGORY>
	<ADMIN-DATA>
		<LANGUAGE>de</LANGUAGE>
		<USED-LANGUAGES>
			<L-10 L="DE" />
		</USED-LANGUAGES>
	</ADMIN-DATA>
	<SW-SYSTEMS>
		<SW-SYSTEM>
			<SHORT-NAME>MEDC17</SHORT-NAME>
			<LONG-NAME>
				<L-4 L="EN">EDC/ME(D)17</L-4>
			</LONG-NAME>
			<SW-COMPONENT-SPEC>
				<SW-COMPONENTS>
					<SW-FEATURE>
						<SHORT-NAME>C-Code Source</SHORT-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Code Listing</SHORT-NAME>
							<VERBATIM ALLOW-BREAK="1">
								<L-5 L="DE">
							 
/* BEGIN: ASCET REGION "Generation Information" */
/******************************************************************************
 * BEGIN: Generation Information
 *-----------------------------------------------------------------------------
 * Component:................Module
 * Name:....................."Torque2Throttle"
 * Implementation:..........."Impl"
 * Dataset:.................."Data"
 * Specification:............Block Diagram
 * Version:..................&lt;empty String&gt;
 * Library Path:............."smartm160\Project_SmartM160\Function_Modules"
 *-----------------------------------------------------------------------------
 * Project Name:............."FlexECU_M160"
 * Project Library Path:....."smartm160\Project_SmartM160\"
 *-----------------------------------------------------------------------------
 * Generation Date:..........03.12.2014
 * Generation Time:..........13:41:34
 *-----------------------------------------------------------------------------
 * ASCET Version:............V6.1.4 RB-DGS 2.3
 * ASCET-MD Version:.........V6.1.4
 * ASCET-RP Version:.........V6.1.4
 * ASCET-SE Version:.........V6.1.4.28.19 CID[610]
 *-----------------------------------------------------------------------------
 * END: Generation Information
 ******************************************************************************/
/* END: ASCET REGION "Generation Information" */

/* BEGIN: ASCET REGION "Project Options" */
/******************************************************************************
 * BEGIN: Project Options "Build"/"Code"
 *-----------------------------------------------------------------------------
 *    Build
 *-----------------------------------------------------------------------------
 * Code Generator:...........Object Based Controller Implementation
 * Compiler:.................Microsoft Visual C++ 2008
 * Operating System:.........GENERIC_OSEK
 * Target:...................ANSI-C
 *-----------------------------------------------------------------------------
 *    Code
 *-----------------------------------------------------------------------------
 * Add Comment with Generation Information for each Component [true]: true
 * Add Comment with Implementation Information for each Assignment Statement [true]: true
 * Add Comment with Specification Source for each Statement [true]:..true
 * Add parenthesis for readability [false]:..........................false
 * Casting [MISRA]:..................................................MISRA
 * Force Parenthesis for Binary Logical Operators [false]:...........false
 * Generate Define Directives for Enum Values [false]:...............false
 * Prefix for Component Names [&lt;empty String&gt;]:......................&lt;empty String&gt;
 * Protected against division by zero [true]:........................true
 * Protected Division against Signed Overflow [true]:................true
 * Protected Vector Indices [true]:..................................true
 *-----------------------------------------------------------------------------
 *    Code.Compiler
 *-----------------------------------------------------------------------------
 * Division truncation direction [Zero (T-division)]:................Zero (T-division)
 * Inline directive [__inline]:......................................__inline
 * Integer Bit Size [32]:............................................32
 * Private directive [static]:.......................................static
 * Public directive [&lt;empty String&gt;]:................................&lt;empty String&gt;
 *-----------------------------------------------------------------------------
 *    Code.FixedPoint
 *-----------------------------------------------------------------------------
 * Allow Double bit Size for Division Numerators [true]:.............true
 * Allow Limit Service for Assignment Limitation [true]:.............true
 * Arithmetic Service Set [&lt;None&gt;]:..................................&lt;None&gt;
 * Generate Limiters (may be changed locally) [true]:................true
 * Generate Round Operation on float to integer Assignment [true]:...true
 * Maximum bit Length (float) [64]:..................................64
 * Maximum bit Length (int) [32]:....................................32
 * Result on Division by Zero [numerator]:...........................numerator
 * Temp Vars always 32 bit (integer) [false]:........................false
 * Use power of 2 approximations of literals [false]:................false
 * Use SHIFT Operation on Signed Values instead of DIV Operation [true]: true
 * Use SHIFT Operation on Signed Values instead of MUL Operation [true]: true
 *-----------------------------------------------------------------------------
 *    Code.Optimizations
 *-----------------------------------------------------------------------------
 * Auto-inline private methods (Smaller code-size - may be changed locally) [false]: false
 * Generate well-formed switch [false]:..............................false
 * Hierarchical Code-Generation (may be changed locally) [false]:....false
 * Initialise history variable with zero [false]:....................false
 * Optimize Direct Access Methods (Multiple Levels) [false]:.........false
 * Optimize Direct Access Methods (One Level) [false]:...............false
 * Optimize Static Actions (Restricted Modelling) [false]:...........false
 * Outline Generated Methods (may be changed locally) [false]:.......false
 *-----------------------------------------------------------------------------
 *    Code.Production
 *-----------------------------------------------------------------------------
 * Add Implementation Definitions [true]:............................true
 * Generate Access Macros for [(variables, messages)]:...............(variables, messages)
 * Generate Access Methods for dT (Alternative: use OS dT directly) [true]: true
 * Generate Data Structures [USELOCAL]:..............................USELOCAL
 * Generate Map File [true]:.........................................true
 * Generate OS Configuration [true]:.................................true
 *-----------------------------------------------------------------------------
 *    Station.Build
 *-----------------------------------------------------------------------------
 * Use Customized Data Type Names [false]:...........................false
 *-----------------------------------------------------------------------------
 * END: Project Options "Build"/"Code"
 ******************************************************************************/
/* END: ASCET REGION "Project Options" */
/* BEGIN: ASCET REGION "ASCET-SE AddOn Options" */
/******************************************************************************
 * BEGIN: ASCET-SE AddOn Options
 * ----------------------------------------------------------------------------
 *     Code
 * ----------------------------------------------------------------------------
 * checkMemSectionVolatility [true]:.................................false
 * checkMultipleSend [false]:........................................false
 * distribVarMemClass ["DISTRRAM"]:.................................."RAM"
 * genAlwaysInitValues [false]:......................................true
 * genLogicElementsAs [PACKED_BITFIELD]:.............................PACKED_BITFIELD
 * genObjList [false]:...............................................false
 * implInfoComments [true]:..........................................true
 * initTaskMemClass ["ASD_INIT_TASK_MEM"]:..........................."ASD_INIT_TASK_MEM"
 * isrMemClass ["ASD_ISR_MEM"]:......................................"ASD_ISR_MEM"
 * mainMemClass ["ASD_EXT_CODE_MEM"]:................................"ASD_EXT_CODE_MEM"
 * optimizeUnusedCode [true]:........................................true
 * paramAsSysConst [false]:..........................................false
 * pragmaMemClassAtDecl [false]:.....................................false
 * pragmaMemClassEnabled [true]:.....................................false
 * referenceMemClass ["REFRAM"]:....................................."RAM"
 * shortNames [false]:...............................................false
 * taskMemClass ["ASD_TASK_MEM"]:...................................."ASD_TASK_MEM"
 * virtualParameterMemClass ["VIRT_PARAM"]:.........................."VIRT_PARAM"
 * ----------------------------------------------------------------------------
 *     Code.Appearance
 * ----------------------------------------------------------------------------
 * braceLineFeed [true]:.............................................true
 * genDate [&lt;undef&gt;]:................................................&lt;undef&gt;
 * genTime [&lt;undef&gt;]:................................................&lt;undef&gt;
 * generateSignatureDecorationComments [true]:.......................true
 * lineFeedPosition [LEFT]:..........................................LEFT
 * maxIdentLength [0]:...............................................40
 * maxRightLength [60]:..............................................60
 * minLeftLength [8]:................................................8
 * preventIndentStructInit [true]:...................................true
 * ----------------------------------------------------------------------------
 *     OS
 * ----------------------------------------------------------------------------
 * Os-Config-C_gen_declaration_alarms [false]:.......................false
 * Os-Config-C_gen_declaration_appmodes [false]:.....................false
 * Os-Config-C_gen_dt_calc [false]:..................................true
 * Os-Config-C_gen_initCOM [false]:..................................false
 * Os-Config-C_gen_inittask [false]:.................................true
 * Os-Config-C_gen_main [false]:.....................................false
 * Os-Config-C_gen_process_container [false]:........................true
 * Os-Config-C_gen_startuphook [false]:..............................false
 * asd_exclusive_area ["ASD_EXCLUSIVE_AREA"]:........................"ASCET_exclusive_area"
 * messageDoInit [false]:............................................false
 * messageExternalMessageCopies [false]:.............................false
 * messageGenOSEKDeclarations [true]:................................false
 * messageIgnoreUsageInInitTask [false]:.............................false
 * messageOverloadInitValues [&lt;undef&gt;]:..............................&lt;undef&gt;
 * messageUsageVariant [OPT_COPY]:...................................NON_OPT_COPY
 * modularMessageUse [false]:........................................false
 * osAppModePattern ["%name%"]:......................................"appmode_%name%"
 * osStartupFunction [&lt;undef&gt;]:......................................&lt;undef&gt;
 * ----------------------------------------------------------------------------
 *     OS.OIL
 * ----------------------------------------------------------------------------
 * OIL-COOP-RESOURCE-name ["ASD_Cooperative_Res"]:..................."ASD_Cooperative_Res"
 * OIL-outputFile ["temp.oil"]:......................................"temp.oil"
 * ----------------------------------------------------------------------------
 *     SERAP
 * ----------------------------------------------------------------------------
 * SERAPRefPageMemoryClass ["SERAP_REF"]:............................"SERAP_REF"
 * SERAPWorkPageMemoryClass ["SERAP_WORK"]:.........................."SERAP_WORK"
 * serap [false]:....................................................false
 * serapEmbedded [true]:.............................................true
 * ----------------------------------------------------------------------------
 *     Virtual Address Tables
 * ----------------------------------------------------------------------------
 * addressTable [true]:..............................................false
 * addressTableMemoryClass ["VATROM"]:..............................."VATROM"
 * ----------------------------------------------------------------------------
 * END: ASCET-SE AddOn Options
 ******************************************************************************/

/* END: ASCET REGION "ASCET-SE AddOn Options" */
/* BEGIN: ASCET REGION "Module Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF SUBSTRUCT VARIABLE 'T2t_RAM'
 * ----------------------------------------------------------------------------
 * memory class:.................................'RAM'
 * model name:...................................'T2t'
 * data set:.....................................'TORQUE2THROTTLE_IMPL_Data'
 * ---------------------------------------------------------------------------*/
struct TORQUE2THROTTLE_IMPL_RAM_SUBSTRUCT T2t_RAM = {
   /* substruct: T2t_RAM.EdgeFalling (modeled as:'EdgeFalling.T2t') */
   {
      /* struct element:'T2t_RAM.EdgeFalling.buffer1' (modeled as:'buffer1.EdgeFalling.T2t') */
      false,
      /* struct element:'T2t_RAM.EdgeFalling.oldSignal1' (modeled as:'oldSignal1.EdgeFalling.T2t') */
      false
   },
   /* substruct: T2t_RAM.PID_Limit_AWU (modeled as:'PID_Limit_AWU.T2t') */
   {
      /* struct element:'T2t_RAM.PID_Limit_AWU.inOLD' (modeled as:'inOLD.PID_Limit_AWU.T2t') */
      0.0,
      /* struct element:'T2t_RAM.PID_Limit_AWU.memory1' (modeled as:'memory1.PID_Limit_AWU.T2t') */
      0.0,
      /* struct element:'T2t_RAM.PID_Limit_AWU.memory2' (modeled as:'memory2.PID_Limit_AWU.T2t') */
      0.0
   },
   /* substruct: T2t_RAM.PID_Limit_AWU_1 (modeled as:'PID_Limit_AWU_1.T2t') */
   {
      /* struct element:'T2t_RAM.PID_Limit_AWU_1.inOLD' (modeled as:'inOLD.PID_Limit_AWU_1.T2t') */
      0.0,
      /* struct element:'T2t_RAM.PID_Limit_AWU_1.memory1' (modeled as:'memory1.PID_Limit_AWU_1.T2t') */
      0.0,
      /* struct element:'T2t_RAM.PID_Limit_AWU_1.memory2' (modeled as:'memory2.PID_Limit_AWU_1.T2t') */
      0.0
   }
};
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF SUBSTRUCT VARIABLE 'T2t_RAM'
 ******************************************************************************/

/******************************************************************************
 * BEGIN: DEFINITION OF COMPONENT VARIABLE 'T2t'
 * ----------------------------------------------------------------------------
 * memory class:.................................'ROM'
 * model name:...................................'T2t'
 * data set:.....................................'TORQUE2THROTTLE_IMPL_Data'
 * ---------------------------------------------------------------------------*/
const struct TORQUE2THROTTLE_IMPL T2t = {
   /* substruct: T2t.EdgeFalling (modeled as:'EdgeFalling.T2t') */
   {
      /* type descriptor pointer 'EDGEFALLING_IMPL_RAM' for memory class substruct for 'RAM' */
      &amp;T2t_RAM.EdgeFalling
   },
   /* substruct: T2t.PID_Limit_AWU (modeled as:'PID_Limit_AWU.T2t') */
   {
      /* type descriptor pointer 'PID_LIMIT_AWU_IMPL_RAM' for memory class substruct for 'RAM' */
      &amp;T2t_RAM.PID_Limit_AWU
   },
   /* substruct: T2t.PID_Limit_AWU_1 (modeled as:'PID_Limit_AWU_1.T2t') */
   {
      /* type descriptor pointer 'PID_LIMIT_AWU_IMPL_RAM' for memory class substruct for 'RAM' */
      &amp;T2t_RAM.PID_Limit_AWU_1
   }
};
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF COMPONENT VARIABLE 'T2t'
 ******************************************************************************/

/* END: ASCET REGION "Module Data Definitions" */

/* BEGIN: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'T2t_CatHeatTime2pManiRes'
 * ---------------------------------------------------------------------------*/
const struct CharTable1_uint16_4_uint16_TORQUE2THROTTLE_IMPL_TYPE T2t_CatHeatTime2pManiRes = {
      4,
      {
         0, 300, 1000, 2000
      },
      {
         15000, 30000, 30000, 0
      }
   };
   /* result: min=0.0, max=50000.0, ident, limit=no */
   /* x axis: min=0.0, max=100.0, fac_100 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'T2t_CatHeatTime2pManiRes'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_KWastegateReqCorr'
 * ---------------------------------------------------------------------------*/
const real64 T2t_KWastegateReqCorr = 0.000001;
   /* min=0.0, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_KWastegateReqCorr'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'T2t_RpmEngSpd2pMaxWithoutWasteGate'
 * ---------------------------------------------------------------------------*/
const struct CharTable1_sint16_11_uint16_TORQUE2THROTTLE_IMPL_TYPE T2t_RpmEngSpd2pMaxWithoutWasteGate = {
      11,
      {
         2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000, 11000, 12000
      },
      {
         27500, 27500, 32500, 35000, 37500, 39250, 40000, 40000, 40000, 40000, 40000
      }
   };
   /* result: min=0.0, max=262140.0, fac_1div4, limit=no */
   /* x axis: min=-16384.0, max=16383.5, fac_2 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'T2t_RpmEngSpd2pMaxWithoutWasteGate'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_ThrPosStart'
 * ---------------------------------------------------------------------------*/
const uint8 T2t_ThrPosStart = 0;
   /* min=0.0, max=1.0, fac_128, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_ThrPosStart'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_ThrValve2WasteGateThreshold'
 * ---------------------------------------------------------------------------*/
const uint8 T2t_ThrValve2WasteGateThreshold = 122;
   /* min=0.0, max=1.0, fac_128, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_ThrValve2WasteGateThreshold'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_ThrValveReqCorrMax'
 * ---------------------------------------------------------------------------*/
const real64 T2t_ThrValveReqCorrMax = 1.0;
   /* min=-oo, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_ThrValveReqCorrMax'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_ThrValveReqCorrMin'
 * ---------------------------------------------------------------------------*/
const real64 T2t_ThrValveReqCorrMin = -1.0;
   /* min=-oo, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_ThrValveReqCorrMin'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'T2t_degIgnAngleDiff2facSparkEff_CUR'
 * ---------------------------------------------------------------------------*/
const struct CharTable1_sint8_67_uint16_TORQUE2THROTTLE_IMPL_TYPE T2t_degIgnAngleDiff2facSparkEff_CUR = {
      67,
      {
         -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
         21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
         41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
         61, 62, 63, 64, 65
      },
      {
         1024, 1024, 1024, 1024, 1024, 1019, 1019, 1014, 1014, 1009, 1009, 1004, 998,
         993, 988, 983, 978, 968, 963, 952, 942, 937, 927, 916, 901, 891, 876, 865, 850,
         835, 814, 799, 783, 763, 742, 722, 701, 676, 655, 630, 609, 584, 558, 527, 502,
         476, 445, 420, 394, 364, 338, 307, 282, 251, 225, 200, 174, 154, 128, 108, 87,
         72, 56, 46, 36, 31, 31
      }
   };
   /* result: min=0.0009765625, max=1.0, fac_1024, limit=no */
   /* x axis: min=-96.0, max=95.25, IGN_4div3 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'T2t_degIgnAngleDiff2facSparkEff_CUR'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_facKThrValveReqCorr'
 * ---------------------------------------------------------------------------*/
const real64 T2t_facKThrValveReqCorr = 0.0000075;
   /* min=0.0, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_facKThrValveReqCorr'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'T2t_facLambaReq2facLambdaEff_CUR'
 * ---------------------------------------------------------------------------*/
const struct CharTable1_uint16_18_uint16_TORQUE2THROTTLE_IMPL_TYPE T2t_facLambaReq2facLambdaEff_CUR = {
      18,
      {
         410, 614, 952, 1157, 1374, 1536, 1632, 1744, 1840, 1952, 2048, 2144, 2256, 2352,
         2464, 2576, 3072, 4076
      },
      {
         410, 410, 638, 834, 997, 1019, 1029, 1039, 1044, 1039, 1024, 1004, 973, 942,
         911, 870, 614, 69
      }
   };
   /* result: min=0.0009765625, max=2.0, fac_1024, limit=no */
   /* x axis: min=0.0, max=2.0, fac_2048 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'T2t_facLambaReq2facLambdaEff_CUR'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_facLambdaEff'
 * ---------------------------------------------------------------------------*/
uint16 T2t_facLambdaEff = 1024;
   /* min=0.0009765625, max=2.0, fac_1024, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_facLambdaEff'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_facSparkEff'
 * ---------------------------------------------------------------------------*/
uint16 T2t_facSparkEff = 1024;
   /* min=0.0009765625, max=1.0, fac_1024, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_facSparkEff'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_facThrValveReqBase'
 * ---------------------------------------------------------------------------*/
sint16 T2t_facThrValveReqBase = 0;
   /* min=-0.12890625, max=1.0, fac_512, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_facThrValveReqBase'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_facThrValveReqCorr'
 * ---------------------------------------------------------------------------*/
sint16 T2t_facThrValveReqCorr = 0;
   /* min=-2.0, max=1.99993896484375, fac_16384, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_facThrValveReqCorr'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_facThrValveReqCorrEnable'
 * ---------------------------------------------------------------------------*/
const uint8 T2t_facThrValveReqCorrEnable = true;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_facThrValveReqCorrEnable'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_facWastegateReqBase'
 * ---------------------------------------------------------------------------*/
uint16 T2t_facWastegateReqBase = 0;
   /* min=0.0, max=1.0, fac_10000, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_facWastegateReqBase'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_facWastegateReqCorr'
 * ---------------------------------------------------------------------------*/
sint16 T2t_facWastegateReqCorr = 0;
   /* min=-1.0, max=1.0, fac_10000, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_facWastegateReqCorr'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_facWastegateReqCorrEnable'
 * ---------------------------------------------------------------------------*/
const uint8 T2t_facWastegateReqCorrEnable = true;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_facWastegateReqCorrEnable'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_flgWasteGateControllerTrue'
 * ---------------------------------------------------------------------------*/
uint8 T2t_flgWasteGateControllerTrue = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_flgWasteGateControllerTrue'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_pManiReq'
 * ---------------------------------------------------------------------------*/
uint16 T2t_pManiReq = 0;
   /* min=0.0, max=262140.0, fac_1div4, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_pManiReq'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_pManiReqCalc'
 * ---------------------------------------------------------------------------*/
uint16 T2t_pManiReqCalc = 0;
   /* min=0.0, max=262140.0, fac_1div4, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_pManiReqCalc'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_pManiReqMan'
 * ---------------------------------------------------------------------------*/
const uint16 T2t_pManiReqMan = 12500;
   /* min=0.0, max=262140.0, fac_1div4, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_pManiReqMan'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_pManiReqMin'
 * ---------------------------------------------------------------------------*/
const uint16 T2t_pManiReqMin = 5250;
   /* min=0.0, max=262140.0, fac_1div4, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_pManiReqMin'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_pManiReqOverride'
 * ---------------------------------------------------------------------------*/
const uint8 T2t_pManiReqOverride = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_pManiReqOverride'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_pManiReqSlow'
 * ---------------------------------------------------------------------------*/
uint16 T2t_pManiReqSlow = 0;
   /* min=0.0, max=262140.0, fac_1div4, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_pManiReqSlow'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_pManiRes'
 * ---------------------------------------------------------------------------*/
const uint16 T2t_pManiRes = 6000;
   /* min=0.0, max=50000.0, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_pManiRes'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_rpmEngSpdFilt'
 * ---------------------------------------------------------------------------*/
const sint16 T2t_rpmEngSpdFilt = 3000;
   /* min=0.0, max=16383.5, fac_2, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_rpmEngSpdFilt'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'T2t_rpmEngSpdpManiReq2facThrValveReqBase_MAP'
 * ---------------------------------------------------------------------------*/
const struct CharTable2_sint16_17_uint16_18_sint16_TORQUE2THROTTLE_IMPL_TYPE T2t_rpmEngSpdpManiReq2facThrValveReqBase_MAP = {
      17,
      18,
      {
         1500, 1600, 1700, 1800, 2000, 2500, 3000, 3500, 4000, 5000, 6000, 7000, 8000,
         9000, 10000, 11000, 12000
      },
      {
         5000, 7500, 10000, 12500, 15000, 16250, 17500, 18750, 20000, 21250, 22500,
         25000, 27500, 30000, 32500, 35000, 37500, 40000
      },
      {
         -59, -59, -32, -32, -19, -13, -7, 6, 18, 31, 43, 128, 209, 512, 512, 512, 512,
         512,
         -59, -59, -32, -32, -19, -13, -7, 6, 18, 31, 43, 128, 209, 512, 512, 512, 512,
         512,
         -59, -59, -32, -32, -19, -13, -7, 6, 18, 31, 43, 128, 209, 512, 512, 512, 512,
         512,
         -59, -59, -32, -32, -19, -13, -7, 6, 18, 31, 43, 128, 209, 512, 512, 512, 512,
         512,
         -59, -59, -32, -32, -19, -13, -7, 6, 18, 31, 43, 128, 209, 512, 512, 512, 512,
         512,
         -59, -59, -32, -32, -19, -13, -7, 6, 18, 31, 43, 128, 209, 512, 512, 512, 512,
         512,
         -49, -49, -38, -32, -19, -13, -7, 6, 18, 31, 43, 128, 209, 512, 512, 512, 512,
         512,
         -37, -37, -26, -20, -5, 0, 5, 18, 26, 38, 49, 92, 133, 230, 307, 512, 512, 512,
         -31, -31, -20, -14, 1, 9, 16, 26, 35, 45, 54, 77, 109, 184, 219, 512, 512, 512,
         -29, -24, -8, 6, 18, 23, 29, 37, 45, 53, 60, 77, 96, 128, 137, 512, 512, 512,
         -29, -19, -3, 14, 30, 38, 46, 52, 58, 64, 70, 77, 95, 123, 125, 512, 512, 512,
         -21, -14, -3, 17, 33, 42, 50, 55, 60, 65, 71, 82, 95, 118, 127, 184, 217, 512,
         -16, -9, 7, 29, 38, 49, 55, 60, 65, 70, 75, 87, 99, 113, 137, 179, 215, 512,
         -11, 1, 13, 37, 44, 51, 60, 65, 69, 74, 79, 92, 110, 113, 143, 174, 207, 512,
         -11, 1, 18, 42, 49, 56, 64, 69, 74, 79, 86, 97, 116, 128, 151, 169, 229, 512,
         -11, 1, 18, 42, 49, 56, 64, 69, 74, 79, 86, 97, 116, 128, 151, 169, 229, 512,
         -11, 1, 18, 42, 49, 56, 64, 69, 74, 79, 86, 97, 116, 128, 151, 169, 229, 512
      }
   };
   /* result: min=-0.12890625, max=1.0, fac_512, limit=no */
   /* x axis: min=-16384.0, max=16383.5, fac_2 */
   /* y axis: min=0.0, max=262140.0, fac_1div4 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'T2t_rpmEngSpdpManiReq2facThrValveReqBase_MAP'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'T2t_rpmEngSpdpManiReq2facWastegateReqBase_MAP'
 * ---------------------------------------------------------------------------*/
const struct CharTable2_sint16_17_uint16_18_uint16_TORQUE2THROTTLE_IMPL_TYPE T2t_rpmEngSpdpManiReq2facWastegateReqBase_MAP = {
      17,
      18,
      {
         1500, 1600, 1700, 1800, 2000, 2500, 3000, 3500, 4000, 5000, 6000, 7000, 8000,
         9000, 10000, 11000, 12000
      },
      {
         7500, 10000, 12500, 15000, 17500, 20000, 22500, 25000, 27500, 30000, 32500,
         35000, 37500, 40000, 42500, 45000, 47500, 50000
      },
      {
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1500, 3000, 3900, 4800, 4800, 4800, 4800,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1500, 3000, 4700, 4700, 4700, 4700,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1000, 2500, 4000, 4000, 4000, 4000,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1000, 4000, 4000, 4000, 4000,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1000, 3300, 3300, 3300, 3300,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1000, 3000, 3000, 3000, 3000,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2000, 2000, 2000, 2000,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1000, 1000, 1000, 1000
      }
   };
   /* result: min=0.0, max=1.0, fac_10000, limit=yes */
   /* x axis: min=-16384.0, max=16383.5, fac_2 */
   /* y axis: min=0.0, max=262140.0, fac_1div4 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'T2t_rpmEngSpdpManiReq2facWastegateReqBase_MAP'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'T2t_rpmEngSpdtqReq2pManiReqBase_MAP'
 * ---------------------------------------------------------------------------*/
const struct CharTable2_sint16_19_sint16_40_uint16_TORQUE2THROTTLE_IMPL_TYPE T2t_rpmEngSpdtqReq2pManiReqBase_MAP = {
      19,
      40,
      {
         520, 800, 1080, 1520, 2000, 2500, 3000, 3500, 4000, 4500, 5000, 6000, 7000,
         8000, 9000, 10000, 11000, 12000, 13000
      },
      {
         0, 235, 905, 1667, 2048, 2415, 2782, 3091, 3434, 3691, 3944, 4293, 4482, 4917,
         5065, 5555, 5754, 5919, 6111, 6290, 6463, 6671, 7516, 7772, 8074, 8297, 8445,
         8672, 8841, 9028, 9237, 9629, 10022, 10559, 11173, 11567, 12148, 12729, 13310,
         13892
      },
      {
         5304, 5930, 7713, 9739, 10753, 11729, 12708, 13530, 14441, 15125, 15798, 16728,
         17230, 18388, 18782, 20085, 20614, 21055, 21564, 22042, 22503, 23054, 25304,
         25984, 26789, 27382, 27777, 28381, 28830, 29327, 29883, 30925, 31973, 33401,
         35035, 36084, 37630, 40372, 42847, 42847,
         5353, 5983, 7779, 9820, 10840, 11823, 12809, 13636, 14554, 15243, 15920, 16857,
         17363, 18528, 18926, 20238, 20770, 21214, 21727, 22208, 22672, 23228, 25494,
         26178, 26989, 27586, 27983, 28592, 29044, 29544, 30105, 31154, 32209, 33647,
         35292, 36349, 37906, 40666, 43159, 43159,
         5402, 6037, 7845, 9900, 10927, 11917, 12910, 13743, 14667, 15361, 16043, 16986,
         17495, 18669, 19069, 20391, 20927, 21374, 21890, 22374, 22842, 23401, 25683,
         26372, 27189, 27789, 28190, 28803, 29258, 29762, 30326, 31383, 32445, 33894,
         35550, 36614, 38182, 40962, 43473, 43473,
         5479, 6121, 7948, 10026, 11064, 12065, 13068, 13911, 14844, 15546, 16235, 17189,
         17704, 18890, 19295, 20631, 21172, 21624, 22146, 22636, 23109, 23674, 25980,
         26677, 27503, 28110, 28515, 29135, 29594, 30104, 30674, 31742, 32816, 34280,
         35955, 37030, 38615, 41427, 43967, 43967,
         5563, 6212, 8061, 10163, 11214, 12226, 13241, 14094, 15038, 15748, 16446, 17411,
         17931, 19132, 19541, 20892, 21440, 21898, 22426, 22921, 23399, 23971, 26305,
         27010, 27845, 28459, 28869, 29496, 29961, 30477, 31053, 32134, 33221, 34702,
         36396, 37484, 39088, 41933, 44504, 44504,
         5650, 6308, 8179, 10306, 11369, 12394, 13422, 14284, 15240, 15958, 16664, 17641,
         18168, 19383, 19797, 21165, 21720, 22183, 22717, 23218, 23702, 24281, 26643,
         27356, 28202, 28823, 29238, 29873, 30343, 30865, 31449, 32543, 33642, 35142,
         36856, 37957, 39580, 42461, 45064, 45064,
         5738, 6403, 8296, 10449, 11525, 12562, 13602, 14475, 15442, 16169, 16883, 17872,
         18405, 19634, 20054, 21438, 21999, 22467, 23008, 23515, 24005, 24591, 26981,
         27703, 28558, 29187, 29607, 30249, 30725, 31253, 31844, 32951, 34064, 35581,
         37316, 38430, 40073, 42989, 45625, 45625,
         5825, 6498, 8414, 10592, 11681, 12730, 13782, 14665, 15644, 16379, 17102, 18102,
         18642, 19886, 20310, 21710, 22278, 22752, 23299, 23813, 24308, 24901, 27319,
         28049, 28915, 29551, 29976, 30626, 31107, 31642, 32240, 33360, 34485, 36020,
         37776, 38903, 40565, 43517, 46185, 46185,
         5912, 6593, 8532, 10735, 11837, 12898, 13962, 14856, 15846, 16590, 17321, 18333,
         18879, 20137, 20566, 21983, 22557, 23037, 23591, 24110, 24611, 25211, 27657,
         28396, 29271, 29915, 30345, 31002, 31490, 32030, 32635, 33768, 34907, 36460,
         38236, 39376, 41058, 44046, 46747, 46747,
         6000, 6689, 8649, 10878, 11992, 13066, 14142, 15046, 16048, 16800, 17540, 18564,
         19116, 20388, 20823, 22256, 22837, 23322, 23882, 24407, 24914, 25520, 27995,
         28743, 29628, 30279, 30714, 31379, 31872, 32419, 33030, 34176, 35328, 36899,
         38696, 39849, 41550, 44573, 47305, 47305,
         6087, 6784, 8767, 11021, 12148, 13234, 14323, 15237, 16250, 17011, 17759, 18794,
         19353, 20640, 21079, 22528, 23116, 23606, 24173, 24704, 25217, 25830, 28333,
         29089, 29985, 30643, 31083, 31755, 32254, 32807, 33426, 34585, 35750, 37339,
         39156, 40322, 42042, 45100, 47865, 47865,
         6262, 6975, 9002, 11307, 12460, 13570, 14683, 15618, 16654, 17432, 18197, 19255,
         19826, 21143, 21592, 23074, 23674, 24176, 24755, 25298, 25823, 26450, 29009,
         29782, 30698, 31372, 31821, 32508, 33018, 33584, 34216, 35402, 36593, 38218,
         40075, 41269, 43027, 46156, 48986, 48986,
         6437, 7165, 9238, 11593, 12771, 13906, 15044, 15999, 17058, 17853, 18635, 19716,
         20300, 21645, 22104, 23619, 24233, 24746, 25337, 25893, 26429, 27070, 29685,
         30475, 31411, 32100, 32559, 33262, 33783, 34361, 35007, 36219, 37436, 39096,
         40995, 42215, 44012, 47212, 50106, 50106,
         6612, 7356, 9473, 11879, 13082, 14242, 15404, 16380, 17461, 18274, 19073, 20178,
         20774, 22148, 22617, 24164, 24791, 25315, 25920, 26487, 27034, 27689, 30361,
         31168, 32124, 32828, 33297, 34015, 34547, 35137, 35798, 37035, 38279, 39975,
         41915, 43161, 44997, 48267, 51226, 51226,
         6787, 7547, 9708, 12165, 13394, 14578, 15764, 16761, 17865, 18695, 19511, 20639,
         21247, 22651, 23129, 24709, 25350, 25885, 26502, 27081, 27640, 28309, 31037,
         31861, 32838, 33556, 34035, 34768, 35311, 35914, 36589, 37852, 39122, 40854,
         42835, 44107, 45982, 49323, 52346, 52346,
         6962, 7737, 9943, 12451, 13705, 14913, 16125, 17142, 18269, 19116, 19948, 21100,
         21721, 23153, 23642, 25255, 25908, 26454, 27084, 27675, 28246, 28929, 31713,
         32554, 33551, 34284, 34773, 35521, 36076, 36691, 37379, 38669, 39965, 41733,
         43755, 45053, 46966, 50377, 53466, 53466,
         7137, 7928, 10179, 12738, 14017, 15249, 16485, 17523, 18673, 19537, 20386,
         21561, 22195, 23656, 24155, 25800, 26467, 27024, 27667, 28270, 28852, 29548,
         32389, 33247, 34264, 35012, 35511, 36274, 36840, 37468, 38170, 39486, 40808,
         42612, 44674, 45999, 47951, 51434, 54587, 54587,
         7312, 8119, 10414, 13024, 14328, 15585, 16846, 17904, 19077, 19958, 20824,
         22022, 22669, 24159, 24667, 26345, 27025, 27593, 28249, 28864, 29458, 30168,
         33065, 33940, 34977, 35740, 36249, 37027, 37604, 38245, 38961, 40303, 41651,
         43491, 45594, 46945, 48936, 52489, 55708, 55708,
         7487, 8309, 10649, 13310, 14640, 15921, 17206, 18285, 19481, 20379, 21262,
         22483, 23142, 24662, 25180, 26891, 27584, 28163, 28831, 29458, 30064, 30787,
         33741, 34634, 35690, 36468, 36987, 37780, 38369, 39021, 39752, 41120, 42495,
         44370, 46514, 47891, 49921, 53545, 56828, 56828
      }
   };
   /* result: min=0.0, max=262140.0, fac_1div4, limit=yes */
   /* x axis: min=-16384.0, max=16383.5, fac_2 */
   /* y axis: min=-256.0, max=255.9921875, fac_128 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'T2t_rpmEngSpdtqReq2pManiReqBase_MAP'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_tiTaThrValveReqCorr'
 * ---------------------------------------------------------------------------*/
real64 T2t_tiTaThrValveReqCorr = 0.001;
   /* min=0.001, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_tiTaThrValveReqCorr'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_tiTaWastegateReqCorr'
 * ---------------------------------------------------------------------------*/
real64 T2t_tiTaWastegateReqCorr = 0.001;
   /* min=0.001, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_tiTaWastegateReqCorr'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_tiTnThrValveReqCorr'
 * ---------------------------------------------------------------------------*/
const real64 T2t_tiTnThrValveReqCorr = 0.3;
   /* min=0.001, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_tiTnThrValveReqCorr'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_tiTnWastegateReqCorr'
 * ---------------------------------------------------------------------------*/
const real64 T2t_tiTnWastegateReqCorr = 0.1;
   /* min=0.001, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_tiTnWastegateReqCorr'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_tiTvThrValveReqCorr'
 * ---------------------------------------------------------------------------*/
const real64 T2t_tiTvThrValveReqCorr = 0.015;
   /* min=0.0, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_tiTvThrValveReqCorr'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'T2t_tiTvWastegateReqCorr'
 * ---------------------------------------------------------------------------*/
const real64 T2t_tiTvWastegateReqCorr = 0.012;
   /* min=0.0, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'T2t_tiTvWastegateReqCorr'
 ******************************************************************************/

/* END: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF MESSAGES
 * ----------------------------------------------------------------------------
 * Total size is [bytes]:........................6
 * ---------------------------------------------------------------------------*/
/* messages of memory class:............................................'RAM' */
/* messages of size [bytes]:................................................2 */
/* modelled as 'T2t_facThrValveReq' */
sint16 T2t_facThrValveReq;
/* modelled as 'T2t_facWasteGateRate' */
uint16 T2t_facWasteGateRate;
/* modelled as 'T2t_pManiReqFast' */
uint16 T2t_pManiReqFast;
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF MESSAGES
 ******************************************************************************/

#define _EdgeFalling T2t.EdgeFalling
#define _EdgeFalling_REF_ (&amp;(T2t.EdgeFalling))
#define _PID_Limit_AWU T2t.PID_Limit_AWU
#define _PID_Limit_AWU_1 T2t.PID_Limit_AWU_1
#define _PID_Limit_AWU_1_REF_ (&amp;(T2t.PID_Limit_AWU_1))
#define _PID_Limit_AWU_REF_ (&amp;(T2t.PID_Limit_AWU))
#define _T2t_CatHeatTime2pManiRes T2t_CatHeatTime2pManiRes
#define _T2t_CatHeatTime2pManiRes_REF_ (&amp;(T2t_CatHeatTime2pManiRes))
#define _T2t_degIgnAngleDiff2facSparkEff_CUR T2t_degIgnAngleDiff2facSparkEff_CUR
#define _T2t_degIgnAngleDiff2facSparkEff_CUR_REF_ (&amp;(T2t_degIgnAngleDiff2facSparkEff_CUR))
#define _T2t_facKThrValveReqCorr T2t_facKThrValveReqCorr
#define _T2t_facLambaReq2facLambdaEff_CUR T2t_facLambaReq2facLambdaEff_CUR
#define _T2t_facLambaReq2facLambdaEff_CUR_REF_ (&amp;(T2t_facLambaReq2facLambdaEff_CUR))
#define _T2t_facLambdaEff T2t_facLambdaEff
#define _T2t_facSparkEff T2t_facSparkEff
#define _T2t_facThrValveReqBase T2t_facThrValveReqBase
#define _T2t_facThrValveReqCorr T2t_facThrValveReqCorr
#define _T2t_facThrValveReqCorrEnable T2t_facThrValveReqCorrEnable
#define _T2t_facWastegateReqBase T2t_facWastegateReqBase
#define _T2t_facWastegateReqCorr T2t_facWastegateReqCorr
#define _T2t_facWastegateReqCorrEnable T2t_facWastegateReqCorrEnable
#define _T2t_flgWasteGateControllerTrue T2t_flgWasteGateControllerTrue
#define _T2t_KWastegateReqCorr T2t_KWastegateReqCorr
#define _T2t_pManiReq T2t_pManiReq
#define _T2t_pManiReqCalc T2t_pManiReqCalc
#define _T2t_pManiReqMan T2t_pManiReqMan
#define _T2t_pManiReqMin T2t_pManiReqMin
#define _T2t_pManiReqOverride T2t_pManiReqOverride
#define _T2t_pManiReqSlow T2t_pManiReqSlow
#define _T2t_pManiRes T2t_pManiRes
#define _T2t_RpmEngSpd2pMaxWithoutWasteGate T2t_RpmEngSpd2pMaxWithoutWasteGate
#define _T2t_RpmEngSpd2pMaxWithoutWasteGate_REF_ (&amp;(T2t_RpmEngSpd2pMaxWithoutWasteGate))
#define _T2t_rpmEngSpdFilt T2t_rpmEngSpdFilt
#define _T2t_rpmEngSpdpManiReq2facThrValveReqBase_MAP T2t_rpmEngSpdpManiReq2facThrValveReqBase_MAP
#define _T2t_rpmEngSpdpManiReq2facThrValveReqBase_MAP_REF_ (&amp;(T2t_rpmEngSpdpManiReq2facThrValveReqBase_MAP))
#define _T2t_rpmEngSpdpManiReq2facWastegateReqBase_MAP T2t_rpmEngSpdpManiReq2facWastegateReqBase_MAP
#define _T2t_rpmEngSpdpManiReq2facWastegateReqBase_MAP_REF_ (&amp;(T2t_rpmEngSpdpManiReq2facWastegateReqBase_MAP))
#define _T2t_rpmEngSpdtqReq2pManiReqBase_MAP T2t_rpmEngSpdtqReq2pManiReqBase_MAP
#define _T2t_rpmEngSpdtqReq2pManiReqBase_MAP_REF_ (&amp;(T2t_rpmEngSpdtqReq2pManiReqBase_MAP))
#define _T2t_ThrPosStart T2t_ThrPosStart
#define _T2t_ThrValve2WasteGateThreshold T2t_ThrValve2WasteGateThreshold
#define _T2t_ThrValveReqCorrMax T2t_ThrValveReqCorrMax
#define _T2t_ThrValveReqCorrMin T2t_ThrValveReqCorrMin
#define _T2t_tiTaThrValveReqCorr T2t_tiTaThrValveReqCorr
#define _T2t_tiTaWastegateReqCorr T2t_tiTaWastegateReqCorr
#define _T2t_tiTnThrValveReqCorr T2t_tiTnThrValveReqCorr
#define _T2t_tiTnWastegateReqCorr T2t_tiTnWastegateReqCorr
#define _T2t_tiTvThrValveReqCorr T2t_tiTvThrValveReqCorr
#define _T2t_tiTvWastegateReqCorr T2t_tiTvWastegateReqCorr

/* BEGIN: ASCET REGION "Component Functions" */
/******************************************************************************
 * BEGIN: FUNCTIONS OF COMPONENT
 ******************************************************************************/

/* BEGIN: ASCET REGION "Process Definition 'T2t_calc'" */
/******************************************************************************
 * BEGIN: DEFINITION OF PROCESS 'TORQUE2THROTTLE_IMPL_T2t_calc'
 * ----------------------------------------------------------------------------
 * model name:...................................'T2t_calc'
 * memory class:.................................'CODE'
 * ---------------------------------------------------------------------------*/
//#if defined(COMPILE_UNUSED_CODE) || defined(COMPILE_UNUSED__TORQUE2THROTTLE_IMPL_T2t_calc)
/* messages used by this process */

/* public T2t_calc []  */

void TORQUE2THROTTLE_IMPL_T2t_calc (void)
{
   /* temp. variables */
   sint16 _t1sint16;
   uint32 _t1uint32;
   sint32 _t1sint32;
   uint16 _t1uint16;
   uint32 _t2uint32;
   sint16 _t2sint16;
   real64 _t1real64;

   /* define local message copies */
   uint16 Afr_facLambdaReq__TORQUE2THROTTLE_IMPL_T2t_calc;
   sint16 Epm_rpmEngSpd__TORQUE2THROTTLE_IMPL_T2t_calc;
   sint8 Iac_degIgn__TORQUE2THROTTLE_IMPL_T2t_calc;
   sint8 Iac_degMinAdvBestTq__TORQUE2THROTTLE_IMPL_T2t_calc;
   sint16 Isc_IdleSpdCtrlIPart__TORQUE2THROTTLE_IMPL_T2t_calc;
   sint16 Isc_IdleSpdCtrlPPart__TORQUE2THROTTLE_IMPL_T2t_calc;
   uint8 Isc_flgIdleSpdCtrlActive__TORQUE2THROTTLE_IMPL_T2t_calc;
   uint16 Mpc_pManiFilt__TORQUE2THROTTLE_IMPL_T2t_calc;
   uint16 Stc_CatalyserHeatingTime__TORQUE2THROTTLE_IMPL_T2t_calc;
   uint8 Stc_flgCatalyserHeating__TORQUE2THROTTLE_IMPL_T2t_calc;
   uint8 Stc_flgStarterActive__TORQUE2THROTTLE_IMPL_T2t_calc;
   sint16 T2t_facThrValveReq__TORQUE2THROTTLE_IMPL_T2t_calc;
   uint16 T2t_facWasteGateRate__TORQUE2THROTTLE_IMPL_T2t_calc;
   uint16 T2t_pManiReqFast__TORQUE2THROTTLE_IMPL_T2t_calc;
   sint16 Tqs_tqReq__TORQUE2THROTTLE_IMPL_T2t_calc;
   /* receive messages implicitly */
   {
      DisableAllInterrupts();
      Afr_facLambdaReq__TORQUE2THROTTLE_IMPL_T2t_calc = Afr_facLambdaReq;
      Epm_rpmEngSpd__TORQUE2THROTTLE_IMPL_T2t_calc = Epm_rpmEngSpd;
      Iac_degIgn__TORQUE2THROTTLE_IMPL_T2t_calc = Iac_degIgn;
      Iac_degMinAdvBestTq__TORQUE2THROTTLE_IMPL_T2t_calc = Iac_degMinAdvBestTq;
      Isc_IdleSpdCtrlIPart__TORQUE2THROTTLE_IMPL_T2t_calc = Isc_IdleSpdCtrlIPart;
      Isc_IdleSpdCtrlPPart__TORQUE2THROTTLE_IMPL_T2t_calc = Isc_IdleSpdCtrlPPart;
      Isc_flgIdleSpdCtrlActive__TORQUE2THROTTLE_IMPL_T2t_calc = Isc_flgIdleSpdCtrlActive;
      Mpc_pManiFilt__TORQUE2THROTTLE_IMPL_T2t_calc = Mpc_pManiFilt;
      Stc_CatalyserHeatingTime__TORQUE2THROTTLE_IMPL_T2t_calc = Stc_CatalyserHeatingTime;
      Stc_flgCatalyserHeating__TORQUE2THROTTLE_IMPL_T2t_calc = Stc_flgCatalyserHeating;
      Stc_flgStarterActive__TORQUE2THROTTLE_IMPL_T2t_calc = Stc_flgStarterActive;
      T2t_facThrValveReq__TORQUE2THROTTLE_IMPL_T2t_calc = T2t_facThrValveReq;
      T2t_facWasteGateRate__TORQUE2THROTTLE_IMPL_T2t_calc = T2t_facWasteGateRate;
      T2t_pManiReqFast__TORQUE2THROTTLE_IMPL_T2t_calc = T2t_pManiReqFast;
      Tqs_tqReq__TORQUE2THROTTLE_IMPL_T2t_calc = Tqs_tqReq;
      EnableAllInterrupts();
   }
   /* T2t_calc: sequence call #2  */
   _t1sint16
      = (sint16)Iac_degMinAdvBestTq__TORQUE2THROTTLE_IMPL_T2t_calc - Iac_degIgn__TORQUE2THROTTLE_IMPL_T2t_calc;
   /* assignment to T2t_facSparkEff: min=1, max=1024, hex=1024phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _T2t_facSparkEff
      = CharTable1_getAt_s8u16(_T2t_degIgnAngleDiff2facSparkEff_CUR_REF_,(sint8)(((_t1sint16 &gt;= -128) ? ((_t1sint16 &lt;= 127) ? _t1sint16 : 127) : -128)));
   /* T2t_calc: sequence call #3  */
   /* assignment to T2t_facLambdaEff: min=1, max=2048, hex=1024phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _T2t_facLambdaEff
      = CharTable1_getAt_u16u16(_T2t_facLambaReq2facLambdaEff_CUR_REF_,Afr_facLambdaReq__TORQUE2THROTTLE_IMPL_T2t_calc);
   /* T2t_calc: sequence call #4  */
   _t1uint32 = (uint32)_T2t_facLambdaEff * _T2t_facSparkEff;
   _t1sint32
      = ((sint32)Tqs_tqReq__TORQUE2THROTTLE_IMPL_T2t_calc &lt;&lt; 16) / (sint32)_t1uint32;
   _t1uint16
      = CharTable2_getAt_s16s16u16(_T2t_rpmEngSpdtqReq2pManiReqBase_MAP_REF_,Epm_rpmEngSpd__TORQUE2THROTTLE_IMPL_T2t_calc,((_t1sint32 &gt;= -2048) ? ((_t1sint32 &lt;= 2047) ? (sint16)_t1sint32 &lt;&lt; 4 : 32767) : -32768));
   /* assignment to T2t_pManiReqCalc: min=0, max=65535, hex=1/4phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _T2t_pManiReqCalc
      = ((_T2t_pManiReqMin &gt;= _t1uint16) ? _T2t_pManiReqMin : _t1uint16);
   /* T2t_calc: sequence call #5  */
   /* assignment to T2t_pManiReq: min=0, max=65535, hex=1/4phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _T2t_pManiReq
      = ((_T2t_pManiReqOverride) ? _T2t_pManiReqMan : _T2t_pManiReqCalc);
   /* T2t_calc: sequence call #6  */
   _t1sint32
      = (sint32)_T2t_pManiReq + ((sint32)Isc_IdleSpdCtrlPPart__TORQUE2THROTTLE_IMPL_T2t_calc + Isc_IdleSpdCtrlIPart__TORQUE2THROTTLE_IMPL_T2t_calc >> 1);
   _t1sint32
      = ((_t1sint32 &gt;= 0) ? ((_t1sint32 &lt;= 65535) ? _t1sint32 : 65535) : 0);
   /* assignment to T2t_pManiReqFast: min=0, max=65535, hex=1/4phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   T2t_pManiReqFast__TORQUE2THROTTLE_IMPL_T2t_calc = (uint16)_t1sint32;
   /* T2t_calc: sequence call #7  */
   _t1uint32 = (uint32)_T2t_pManiReq &lt;&lt; 1;
   _t2uint32
      = ((Stc_flgCatalyserHeating__TORQUE2THROTTLE_IMPL_T2t_calc) ? (uint32)_T2t_pManiRes + CharTable1_getAt_u16u16(_T2t_CatHeatTime2pManiRes_REF_,Stc_CatalyserHeatingTime__TORQUE2THROTTLE_IMPL_T2t_calc) : (_t1uint16
      = ((Isc_flgIdleSpdCtrlActive__TORQUE2THROTTLE_IMPL_T2t_calc) ? _T2t_pManiRes : 0U) ,  _t1uint16));
   _t1sint32
      = ((sint32)_t1uint32 + Isc_IdleSpdCtrlIPart__TORQUE2THROTTLE_IMPL_T2t_calc &lt;&lt; 1) + (sint32)_t2uint32;
   _t1sint32
      = ((_t1sint32 &gt;= 0) ? (((uint32)_t1sint32 &lt;= 262140U) ? _t1sint32 >> 2 : 65535) : 0);
   /* assignment to T2t_pManiReqSlow: min=0, max=65535, hex=1/4phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _T2t_pManiReqSlow = (uint16)_t1sint32;
   /* T2t_calc: sequence call #9  */
   _T2t_flgWasteGateControllerTrue
      = (_T2t_pManiReqSlow
      > CharTable1_getAt_s16u16(_T2t_RpmEngSpd2pMaxWithoutWasteGate_REF_,Epm_rpmEngSpd__TORQUE2THROTTLE_IMPL_T2t_calc)
      || (_t1sint16 = _T2t_facThrValveReqBase &lt;&lt; 5 ,  _t2sint16
      = ((Epm_rpmEngSpd__TORQUE2THROTTLE_IMPL_T2t_calc &gt; _T2t_rpmEngSpdFilt) ? 0 : ((_T2t_facThrValveReqCorrEnable) ? _T2t_facThrValveReqCorr : 0)) ,  _t1uint16 = (uint16)((uint16)_T2t_ThrValve2WasteGateThreshold &lt;&lt; 7) ,  (sint32)_t1sint16 + _t2sint16 > (sint32)_t1uint16)) &amp;&amp; !Stc_flgStarterActive__TORQUE2THROTTLE_IMPL_T2t_calc;
   /* T2t_calc: sequence call #10  */
   if (_T2t_flgWasteGateControllerTrue)
   {
      /* If-block: sequence call #10/Then #1  */
      _t1sint16 = (sint16)_T2t_facWastegateReqBase + _T2t_facWastegateReqCorr;
      /* assignment to T2t_facWasteGateRate: min=100, max=9900, hex=10000phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
      T2t_facWasteGateRate__TORQUE2THROTTLE_IMPL_T2t_calc
         = ((_t1sint16 &gt;= 100) ? (((uint16)_t1sint16 &lt;= 9900U) ? (uint16)_t1sint16 : 9900U) : 100U);
   }
   else
   {
      /* If-block: sequence call #10/Else #1  */
      /* assignment to T2t_facWasteGateRate: min=100, max=9900, hex=10000phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
      T2t_facWasteGateRate__TORQUE2THROTTLE_IMPL_T2t_calc = 100U;
   } /* end if */
   /* T2t_calc: sequence call #11  */
   _t1real64
      = (((real64)Epm_rpmEngSpd__TORQUE2THROTTLE_IMPL_T2t_calc == 0.0) ? 80.0 : 80.0 / (real64)Epm_rpmEngSpd__TORQUE2THROTTLE_IMPL_T2t_calc);
   /* assignment to T2t_tiTaThrValveReqCorr: min=0, max=+oo, hex=phys, limit=n.a., zero incl.=true  */
   _T2t_tiTaThrValveReqCorr = ((_t1real64 &lt;= 40.0) ? _t1real64 : 40.0);
   /* T2t_calc: sequence call #12  */
   /* assignment to T2t_facThrValveReqBase: min=-66, max=512, hex=512phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _T2t_facThrValveReqBase
      = CharTable2_getAt_s16u16s16(_T2t_rpmEngSpdpManiReq2facThrValveReqBase_MAP_REF_,Epm_rpmEngSpd__TORQUE2THROTTLE_IMPL_T2t_calc,_T2t_pManiReqSlow);
   /* T2t_calc: sequence call #13  */
   PID_LIMIT_AWU_IMPL_compute(_PID_Limit_AWU_REF_, ((real64)_T2t_pManiReqSlow - (real64)Mpc_pManiFilt__TORQUE2THROTTLE_IMPL_T2t_calc) * 4.0, _T2t_facKThrValveReqCorr, _T2t_tiTvThrValveReqCorr, _T2t_tiTnThrValveReqCorr, _T2t_tiTaThrValveReqCorr, _T2t_ThrValveReqCorrMax, _T2t_ThrValveReqCorrMin);
   /* T2t_calc: sequence call #14  */
   _t1real64 = PID_LIMIT_AWU_IMPL_out(_PID_Limit_AWU_REF_) * 16384.0;
   _t1real64 = ((_t1real64 &lt; 0.0) ? _t1real64 - 0.5 : _t1real64 + 0.5);
   /* assignment to T2t_facThrValveReqCorr: min=-32768, max=32767, hex=16384phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _T2t_facThrValveReqCorr
      = ((_t1real64 &gt;= -32768.0) ? ((_t1real64 &lt;= 32767.0) ? (sint16)_t1real64 : 32767) : -32768);
   /* T2t_calc: sequence call #15  */
   /* assignment to T2t_facWastegateReqBase: min=0, max=10000, hex=10000phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _T2t_facWastegateReqBase
      = CharTable2_getAt_s16u16u16(_T2t_rpmEngSpdpManiReq2facWastegateReqBase_MAP_REF_,Epm_rpmEngSpd__TORQUE2THROTTLE_IMPL_T2t_calc,_T2t_pManiReqSlow);
   /* T2t_calc: sequence call #17  */
   _t1real64 = PID_LIMIT_AWU_IMPL_out(_PID_Limit_AWU_1_REF_) * 10000.0;
   _t1real64 = ((_t1real64 &lt; 0.0) ? _t1real64 - 0.5 : _t1real64 + 0.5);
   /* assignment to T2t_facWastegateReqCorr: min=-10000, max=10000, hex=10000phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _T2t_facWastegateReqCorr
      = ((_t1real64 &gt;= -10000.0) ? ((_t1real64 &lt;= 10000.0) ? (sint16)_t1real64 : 10000) : -10000);
   /* T2t_calc: sequence call #23  */
   if (_T2t_flgWasteGateControllerTrue
      || EDGEFALLING_IMPL_compute(_EdgeFalling_REF_, Stc_flgStarterActive__TORQUE2THROTTLE_IMPL_T2t_calc))
   {
      /* If-block: sequence call #23/Then #1  */
      PID_LIMIT_AWU_IMPL_reset(_PID_Limit_AWU_REF_, 0.0);
   } /* end if */
   /* T2t_calc: sequence call #24  */
   _t2sint16
      = ((Stc_flgStarterActive__TORQUE2THROTTLE_IMPL_T2t_calc) ? (_t1uint16 = (uint16)((uint16)_T2t_ThrPosStart &lt;&lt; 2) ,  (sint16)_t1uint16) : ((_T2t_flgWasteGateControllerTrue) ? 512 : _T2t_facThrValveReqBase + (((Epm_rpmEngSpd__TORQUE2THROTTLE_IMPL_T2t_calc &gt; _T2t_rpmEngSpdFilt) ? 0 : ((_T2t_facThrValveReqCorrEnable) ? _T2t_facThrValveReqCorr >> 5 : 0)))));
   /* assignment to T2t_facThrValveReq: min=-66, max=512, hex=512phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   T2t_facThrValveReq__TORQUE2THROTTLE_IMPL_T2t_calc
      = ((_t2sint16 &gt;= -66) ? ((_t2sint16 &lt;= 512) ? _t2sint16 : 512) : -66);
   /* T2t_calc: sequence call #25  */
   if (_T2t_facWastegateReqCorrEnable &amp;&amp; _T2t_flgWasteGateControllerTrue)
   {
      /* If-block: sequence call #25/Then #2  */
      _t1real64
         = (((real64)Epm_rpmEngSpd__TORQUE2THROTTLE_IMPL_T2t_calc == 0.0) ? 80.0 : 80.0 / (real64)Epm_rpmEngSpd__TORQUE2THROTTLE_IMPL_T2t_calc);
      /* assignment to T2t_tiTaWastegateReqCorr: min=0, max=+oo, hex=phys, limit=n.a., zero incl.=true  */
      _T2t_tiTaWastegateReqCorr = ((_t1real64 &lt;= 40.0) ? _t1real64 : 40.0);
      /* If-block: sequence call #25/Then #3  */
      PID_LIMIT_AWU_IMPL_compute(_PID_Limit_AWU_1_REF_, ((real64)_T2t_pManiReqSlow - (real64)Mpc_pManiFilt__TORQUE2THROTTLE_IMPL_T2t_calc) * 4.0, _T2t_KWastegateReqCorr, _T2t_tiTvWastegateReqCorr, _T2t_tiTnWastegateReqCorr, _T2t_tiTaWastegateReqCorr, 1.0, -1.0);
   }
   else
   {
      /* If-block: sequence call #25/Else #1  */
      PID_LIMIT_AWU_IMPL_reset(_PID_Limit_AWU_1_REF_, 0.01);
   } /* end if */
   /* send messages implicitly */
   {
      DisableAllInterrupts();
      T2t_facThrValveReq = T2t_facThrValveReq__TORQUE2THROTTLE_IMPL_T2t_calc;
      T2t_facWasteGateRate = T2t_facWasteGateRate__TORQUE2THROTTLE_IMPL_T2t_calc;
      T2t_pManiReqFast = T2t_pManiReqFast__TORQUE2THROTTLE_IMPL_T2t_calc;
      EnableAllInterrupts();
   }
}
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF PROCESS 'TORQUE2THROTTLE_IMPL_T2t_calc'
 ******************************************************************************/
#endif
/* END: ASCET REGION "Process Definition 'T2t_calc'" */


/* ****************************************************************************
 * END: FUNCTIONS OF COMPONENT
 ******************************************************************************/
/* END: ASCET REGION "Component Functions" */


							</L-5>
							</VERBATIM>

						</CHAPTER>


					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
