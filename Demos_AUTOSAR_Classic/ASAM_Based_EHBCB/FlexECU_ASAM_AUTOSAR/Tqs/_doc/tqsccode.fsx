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
 * Name:....................."TorqueStructure"
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
 * BEGIN: DEFINITION OF SUBSTRUCT VARIABLE 'Tqs_RAM'
 * ----------------------------------------------------------------------------
 * memory class:.................................'RAM'
 * model name:...................................'Tqs'
 * data set:.....................................'TORQUESTRUCTURE_IMPL_Data'
 * ---------------------------------------------------------------------------*/
struct TORQUESTRUCTURE_IMPL_RAM_SUBSTRUCT Tqs_RAM = {
   /* substruct: Tqs_RAM.PID_Limit_AWU (modeled as:'PID_Limit_AWU.Tqs') */
   {
      /* struct element:'Tqs_RAM.PID_Limit_AWU.inOLD' (modeled as:'inOLD.PID_Limit_AWU.Tqs') */
      0.0,
      /* struct element:'Tqs_RAM.PID_Limit_AWU.memory1' (modeled as:'memory1.PID_Limit_AWU.Tqs') */
      0.0,
      /* struct element:'Tqs_RAM.PID_Limit_AWU.memory2' (modeled as:'memory2.PID_Limit_AWU.Tqs') */
      0.0
   }
};
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF SUBSTRUCT VARIABLE 'Tqs_RAM'
 ******************************************************************************/

/******************************************************************************
 * BEGIN: DEFINITION OF COMPONENT VARIABLE 'Tqs'
 * ----------------------------------------------------------------------------
 * memory class:.................................'ROM'
 * model name:...................................'Tqs'
 * data set:.....................................'TORQUESTRUCTURE_IMPL_Data'
 * ---------------------------------------------------------------------------*/
const struct TORQUESTRUCTURE_IMPL Tqs = {
   /* substruct: Tqs.PID_Limit_AWU (modeled as:'PID_Limit_AWU.Tqs') */
   {
      /* type descriptor pointer 'PID_LIMIT_AWU_IMPL_RAM' for memory class substruct for 'RAM' */
      &amp;Tqs_RAM.PID_Limit_AWU
   }
};
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF COMPONENT VARIABLE 'Tqs'
 ******************************************************************************/

/* END: ASCET REGION "Module Data Definitions" */

/* BEGIN: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'Tqs_atCool2tqDrag_CUR'
 * ---------------------------------------------------------------------------*/
const struct CharTable1_uint16_12_uint16_TORQUESTRUCTURE_IMPL_TYPE Tqs_atCool2tqDrag_CUR = {
      12,
      {
         28544, 29824, 31104, 32384, 33664, 34944, 36224, 38784, 40064, 42624, 46464,
         50304
      },
      {
         5376, 5376, 4032, 3352, 2988, 2818, 2667, 2240, 869, 0, 0, 0
      }
   };
   /* result: min=0.0, max=255.99609375, fac_256, limit=no */
   /* x axis: min=0.0, max=511.9921875, fac_128 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'Tqs_atCool2tqDrag_CUR'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_facEgasFilt'
 * ---------------------------------------------------------------------------*/
uint16 Tqs_facEgasFilt = 0;
   /* min=0.0, max=1.0, fac_256, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_facEgasFilt'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_facKIdleSpdCtrl'
 * ---------------------------------------------------------------------------*/
const real64 Tqs_facKIdleSpdCtrl = 0.2;
   /* min=-oo, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_facKIdleSpdCtrl'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_flgIdleSpdCtrlEnable'
 * ---------------------------------------------------------------------------*/
const uint8 Tqs_flgIdleSpdCtrlEnable = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_flgIdleSpdCtrlEnable'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_flgTorqueReqOverride'
 * ---------------------------------------------------------------------------*/
const uint8 Tqs_flgTorqueReqOverride = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_flgTorqueReqOverride'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'Tqs_rpmEngSpd2tqMax_CUR'
 * ---------------------------------------------------------------------------*/
const struct CharTable1_sint16_14_uint16_TORQUESTRUCTURE_IMPL_TYPE Tqs_rpmEngSpd2tqMax_CUR = {
      14,
      {
         0, 1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000, 11000, 12000,
         13000
      },
      {
         10240, 10240, 11520, 14848, 18176, 21504, 23552, 22272, 21248, 21504, 17920,
         16640, 12800, 8960
      }
   };
   /* result: min=0.0, max=255.99609375, fac_256, limit=no */
   /* x axis: min=-16384.0, max=16383.5, fac_2 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'Tqs_rpmEngSpd2tqMax_CUR'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_rpmEngSpdIdle'
 * ---------------------------------------------------------------------------*/
const sint16 Tqs_rpmEngSpdIdle = 2400;
   /* min=0.0, max=16383.5, fac_2, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_rpmEngSpdIdle'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'Tqs_rpmEngSpdfacEgas2facEgasFilt_MAP'
 * ---------------------------------------------------------------------------*/
const struct CharTable2_sint16_19_uint16_9_uint16_TORQUESTRUCTURE_IMPL_TYPE Tqs_rpmEngSpdfacEgas2facEgasFilt_MAP = {
      19,
      9,
      {
         520, 800, 1080, 1520, 2000, 2480, 3040, 3520, 4000, 5040, 6000, 7040, 8000,
         9040, 10000, 11040, 12400, 13758, 15000
      },
      {
         0, 1, 51, 102, 154, 256, 358, 461, 512
      },
      {
         0, 0, 8, 21, 43, 70, 106, 153, 194,
         0, 0, 8, 21, 43, 70, 106, 153, 194,
         0, 2, 15, 30, 55, 84, 123, 165, 207,
         0, 3, 23, 44, 73, 109, 147, 186, 227,
         0, 5, 24, 45, 75, 112, 152, 195, 239,
         0, 6, 24, 47, 75, 114, 156, 200, 243,
         0, 7, 25, 51, 74, 117, 159, 204, 248,
         0, 8, 26, 52, 75, 119, 163, 208, 254,
         0, 8, 28, 53, 78, 122, 166, 213, 256,
         0, 8, 28, 53, 78, 122, 166, 213, 256,
         0, 8, 28, 53, 78, 122, 166, 213, 256,
         0, 8, 28, 53, 78, 122, 166, 213, 256,
         0, 8, 28, 53, 78, 122, 166, 213, 256,
         0, 8, 28, 53, 78, 122, 166, 213, 256,
         0, 8, 28, 53, 78, 122, 166, 213, 256,
         0, 8, 28, 53, 78, 122, 166, 213, 256,
         0, 8, 28, 53, 78, 122, 166, 213, 256,
         0, 8, 28, 53, 78, 122, 166, 213, 256,
         0, 8, 28, 53, 78, 122, 166, 213, 256
      }
   };
   /* result: min=0.0, max=1.0, fac_256, limit=no */
   /* x axis: min=-16384.0, max=16383.5, fac_2 */
   /* y axis: min=0.0, max=1.0, fac_512 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'Tqs_rpmEngSpdfacEgas2facEgasFilt_MAP'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'Tqs_rpmEngSpdfacRelAir2tqDrag_MAP'
 * ---------------------------------------------------------------------------*/
const struct CharTable2_sint16_12_uint16_28_uint16_TORQUESTRUCTURE_IMPL_TYPE Tqs_rpmEngSpdfacRelAir2tqDrag_MAP = {
      12,
      28,
      {
         500, 1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 10000, 12000, 13000
      },
      {
         0, 26, 51, 77, 102, 154, 205, 256, 307, 358, 410, 461, 512, 563, 614, 666, 717,
         768, 819, 870, 922, 973, 1024, 1075, 1126, 1178, 1229, 1280
      },
      {
         967, 932, 897, 861, 826, 755, 684, 614, 543, 472, 401, 330, 260, 189, 118, 47,
         22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
         1038, 1006, 972, 940, 906, 839, 771, 705, 638, 572, 505, 438, 371, 304, 238,
         171, 105, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37,
         1182, 1154, 1124, 1094, 1064, 1006, 947, 888, 829, 770, 712, 653, 594, 535, 477,
         417, 358, 299, 241, 182, 122, 63, 30, 30, 30, 30, 30, 30,
         1300, 1283, 1266, 1250, 1233, 1200, 1166, 1134, 1100, 1067, 1034, 1001, 967,
         934, 901, 868, 834, 802, 768, 736, 702, 668, 635, 602, 569, 535, 502, 295,
         1495, 1469, 1442, 1415, 1390, 1336, 1283, 1230, 1177, 1124, 1070, 1018, 964,
         911, 858, 805, 753, 698, 646, 592, 538, 486, 432, 378, 326, 273, 220, 166,
         1610, 1583, 1559, 1534, 1509, 1458, 1407, 1357, 1306, 1255, 1206, 1154, 1103,
         1053, 1003, 951, 901, 851, 799, 749, 698, 647, 598, 547, 495, 445, 395, 343,
         1759, 1744, 1728, 1714, 1698, 1669, 1640, 1609, 1580, 1550, 1520, 1490, 1459,
         1430, 1399, 1370, 1341, 1311, 1280, 1250, 1221, 1191, 1161, 1131, 1102, 1072,
         1041, 1012,
         1922, 1914, 1908, 1901, 1895, 1882, 1869, 1854, 1842, 1828, 1815, 1802, 1789,
         1775, 1762, 1749, 1735, 1724, 1710, 1698, 1684, 1670, 1658, 1644, 1631, 1617,
         1604, 1591,
         2041, 2036, 2032, 2027, 2022, 2013, 2003, 1994, 1984, 1975, 1966, 1956, 1947,
         1937, 1928, 1919, 1909, 1899, 1890, 1882, 1871, 1862, 1852, 1843, 1834, 1825,
         1815, 1806,
         2296, 2301, 2305, 2311, 2315, 2324, 2334, 2343, 2354, 2362, 2371, 2381, 2390,
         2401, 2409, 2420, 2429, 2438, 2448, 2457, 2466, 2475, 2485, 2495, 2505, 2514,
         2523, 2533,
         2625, 2635, 2644, 2654, 2662, 2682, 2703, 2722, 2741, 2761, 2780, 2798, 2819,
         2838, 2858, 2877, 2896, 2915, 2936, 2955, 2974, 2994, 3013, 3031, 3051, 3071,
         3091, 3167,
         2769, 2783, 2796, 2810, 2824, 2850, 2878, 2905, 2934, 2959, 2988, 3014, 3041,
         3069, 3094, 3123, 3150, 3178, 3204, 3233, 3258, 3287, 3314, 3342, 3368, 3396,
         3423, 3523
      }
   };
   /* result: min=0.0, max=255.99609375, fac_256, limit=no */
   /* x axis: min=-16384.0, max=16383.5, fac_2 */
   /* y axis: min=0.0, max=2.5, fac_512 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'Tqs_rpmEngSpdfacRelAir2tqDrag_MAP'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_tiTnIdleSpdCtrl'
 * ---------------------------------------------------------------------------*/
const real64 Tqs_tiTnIdleSpdCtrl = 0.1;
   /* min=0.001, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_tiTnIdleSpdCtrl'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_tiTvIdleSpdCtrl'
 * ---------------------------------------------------------------------------*/
const real64 Tqs_tiTvIdleSpdCtrl = 0.012;
   /* min=0.0, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_tiTvIdleSpdCtrl'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_tqDrag'
 * ---------------------------------------------------------------------------*/
uint16 Tqs_tqDrag = 0;
   /* min=0.0, max=255.99609375, fac_256, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_tqDrag'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_tqIdleSpdCtrlCorr'
 * ---------------------------------------------------------------------------*/
sint16 Tqs_tqIdleSpdCtrlCorr = 0;
   /* min=-256.0, max=255.9921875, fac_128, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_tqIdleSpdCtrlCorr'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_tqIdleSpdCtrlMax'
 * ---------------------------------------------------------------------------*/
const real32 Tqs_tqIdleSpdCtrlMax = 80.0F;
   /* min=-oo, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_tqIdleSpdCtrlMax'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_tqIdleSpdCtrlMin'
 * ---------------------------------------------------------------------------*/
const real32 Tqs_tqIdleSpdCtrlMin = 0.0F;
   /* min=-oo, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_tqIdleSpdCtrlMin'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_tqMax'
 * ---------------------------------------------------------------------------*/
uint16 Tqs_tqMax = 0;
   /* min=0.0, max=255.99609375, fac_256, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_tqMax'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_tqReqCalc'
 * ---------------------------------------------------------------------------*/
sint16 Tqs_tqReqCalc = 0;
   /* min=-256.0, max=255.9921875, fac_128, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_tqReqCalc'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Tqs_tqReqMan'
 * ---------------------------------------------------------------------------*/
const sint16 Tqs_tqReqMan = 0;
   /* min=-256.0, max=255.9921875, fac_128, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Tqs_tqReqMan'
 ******************************************************************************/

/* END: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF MESSAGES
 * ----------------------------------------------------------------------------
 * Total size is [bytes]:........................4
 * ---------------------------------------------------------------------------*/
/* messages of memory class:............................................'RAM' */
/* messages of size [bytes]:................................................2 */
/* modelled as 'Tqs_tqMin' */
sint16 Tqs_tqMin;
/* modelled as 'Tqs_tqReq' */
sint16 Tqs_tqReq;
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF MESSAGES
 ******************************************************************************/

#define _PID_Limit_AWU Tqs.PID_Limit_AWU
#define _PID_Limit_AWU_REF_ (&amp;(Tqs.PID_Limit_AWU))
#define _Tqs_atCool2tqDrag_CUR Tqs_atCool2tqDrag_CUR
#define _Tqs_atCool2tqDrag_CUR_REF_ (&amp;(Tqs_atCool2tqDrag_CUR))
#define _Tqs_facEgasFilt Tqs_facEgasFilt
#define _Tqs_facKIdleSpdCtrl Tqs_facKIdleSpdCtrl
#define _Tqs_flgIdleSpdCtrlEnable Tqs_flgIdleSpdCtrlEnable
#define _Tqs_flgTorqueReqOverride Tqs_flgTorqueReqOverride
#define _Tqs_rpmEngSpd2tqMax_CUR Tqs_rpmEngSpd2tqMax_CUR
#define _Tqs_rpmEngSpd2tqMax_CUR_REF_ (&amp;(Tqs_rpmEngSpd2tqMax_CUR))
#define _Tqs_rpmEngSpdfacEgas2facEgasFilt_MAP Tqs_rpmEngSpdfacEgas2facEgasFilt_MAP
#define _Tqs_rpmEngSpdfacEgas2facEgasFilt_MAP_REF_ (&amp;(Tqs_rpmEngSpdfacEgas2facEgasFilt_MAP))
#define _Tqs_rpmEngSpdfacRelAir2tqDrag_MAP Tqs_rpmEngSpdfacRelAir2tqDrag_MAP
#define _Tqs_rpmEngSpdfacRelAir2tqDrag_MAP_REF_ (&amp;(Tqs_rpmEngSpdfacRelAir2tqDrag_MAP))
#define _Tqs_rpmEngSpdIdle Tqs_rpmEngSpdIdle
#define _Tqs_tiTnIdleSpdCtrl Tqs_tiTnIdleSpdCtrl
#define _Tqs_tiTvIdleSpdCtrl Tqs_tiTvIdleSpdCtrl
#define _Tqs_tqDrag Tqs_tqDrag
#define _Tqs_tqIdleSpdCtrlCorr Tqs_tqIdleSpdCtrlCorr
#define _Tqs_tqIdleSpdCtrlMax Tqs_tqIdleSpdCtrlMax
#define _Tqs_tqIdleSpdCtrlMin Tqs_tqIdleSpdCtrlMin
#define _Tqs_tqMax Tqs_tqMax
#define _Tqs_tqReqCalc Tqs_tqReqCalc
#define _Tqs_tqReqMan Tqs_tqReqMan

/* BEGIN: ASCET REGION "Component Functions" */
/******************************************************************************
 * BEGIN: FUNCTIONS OF COMPONENT
 ******************************************************************************/

/* BEGIN: ASCET REGION "Process Definition 'Tqs_calc'" */
/******************************************************************************
 * BEGIN: DEFINITION OF PROCESS 'TORQUESTRUCTURE_IMPL_Tqs_calc'
 * ----------------------------------------------------------------------------
 * model name:...................................'Tqs_calc'
 * memory class:.................................'CODE'
 * ---------------------------------------------------------------------------*/
//#if defined(COMPILE_UNUSED_CODE) || defined(COMPILE_UNUSED__TORQUESTRUCTURE_IMPL_Tqs_calc)
/* messages used by this process */

/* public Tqs_calc []  */

void TORQUESTRUCTURE_IMPL_Tqs_calc (void)
{
   /* user defined local variables */
   uint8 _t1;
   uint32 _t2;
   /* temp. variables */
   real64 _t1real64;
   uint32 _t1uint32;
   sint16 _t1sint16;
   uint32 _t2uint32;
   sint32 _t1sint32;

   /* define local message copies */
   uint16 Amf_facRelAir__TORQUESTRUCTURE_IMPL_Tqs_calc;
   uint16 Ctc_atCool__TORQUESTRUCTURE_IMPL_Tqs_calc;
   uint16 Egc_facEgas__TORQUESTRUCTURE_IMPL_Tqs_calc;
   sint16 Epm_rpmEngSpd__TORQUESTRUCTURE_IMPL_Tqs_calc;
   uint16 Isc_facIdleSpdStab__TORQUESTRUCTURE_IMPL_Tqs_calc;
   sint16 Tqs_tqMin__TORQUESTRUCTURE_IMPL_Tqs_calc;
   sint16 Tqs_tqReq__TORQUESTRUCTURE_IMPL_Tqs_calc;
   /* receive messages implicitly */
   {
      DisableAllInterrupts();
      Amf_facRelAir__TORQUESTRUCTURE_IMPL_Tqs_calc = Amf_facRelAir;
      Ctc_atCool__TORQUESTRUCTURE_IMPL_Tqs_calc = Ctc_atCool;
      Egc_facEgas__TORQUESTRUCTURE_IMPL_Tqs_calc = Egc_facEgas;
      Epm_rpmEngSpd__TORQUESTRUCTURE_IMPL_Tqs_calc = Epm_rpmEngSpd;
      Isc_facIdleSpdStab__TORQUESTRUCTURE_IMPL_Tqs_calc = Isc_facIdleSpdStab;
      Tqs_tqMin__TORQUESTRUCTURE_IMPL_Tqs_calc = Tqs_tqMin;
      Tqs_tqReq__TORQUESTRUCTURE_IMPL_Tqs_calc = Tqs_tqReq;
      EnableAllInterrupts();
   }
   _t1 = Egc_facEgas__TORQUESTRUCTURE_IMPL_Tqs_calc &lt; 26U;
   /* Tqs_calc: sequence call #1  */
   if (_t1)
   {
      /* If-block: sequence call #1/Then #1  */
      PID_LIMIT_AWU_IMPL_compute(_PID_Limit_AWU_REF_, ((real64)_Tqs_rpmEngSpdIdle - (real64)Epm_rpmEngSpd__TORQUESTRUCTURE_IMPL_Tqs_calc) * 0.5, _Tqs_facKIdleSpdCtrl, _Tqs_tiTvIdleSpdCtrl, _Tqs_tiTnIdleSpdCtrl, 0.002, (real64)_Tqs_tqIdleSpdCtrlMax, (real64)_Tqs_tqIdleSpdCtrlMin);
   }
   else
   {
      /* If-block: sequence call #1/Else #1  */
      PID_LIMIT_AWU_IMPL_reset(_PID_Limit_AWU_REF_, 0.0);
   } /* end if */
   /* Tqs_calc: sequence call #2  */
   _t1real64 = PID_LIMIT_AWU_IMPL_out(_PID_Limit_AWU_REF_) * 128.0;
   _t1real64 = ((_t1real64 &lt; 0.0) ? _t1real64 - 0.5 : _t1real64 + 0.5);
   /* assignment to Tqs_tqIdleSpdCtrlCorr: min=-32768, max=32767, hex=128phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _Tqs_tqIdleSpdCtrlCorr
      = ((_t1real64 >= -32768.0) ? ((_t1real64 &lt;= 32767.0) ? (sint16)_t1real64 : 32767) : -32768);
   /* Tqs_calc: sequence call #3  */
   /* assignment to Tqs_facEgasFilt: min=0, max=256, hex=256phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _Tqs_facEgasFilt
      = CharTable2_getAt_s16u16u16(_Tqs_rpmEngSpdfacEgas2facEgasFilt_MAP_REF_,Epm_rpmEngSpd__TORQUESTRUCTURE_IMPL_Tqs_calc,Egc_facEgas__TORQUESTRUCTURE_IMPL_Tqs_calc);
   /* Tqs_calc: sequence call #4  */
   /* assignment to Tqs_tqMax: min=0, max=65535, hex=256phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _Tqs_tqMax
      = CharTable1_getAt_s16u16(_Tqs_rpmEngSpd2tqMax_CUR_REF_,Epm_rpmEngSpd__TORQUESTRUCTURE_IMPL_Tqs_calc);
   /* Tqs_calc: sequence call #5  */
   _t1uint32
      = (uint32)CharTable2_getAt_s16u16u16(_Tqs_rpmEngSpdfacRelAir2tqDrag_MAP_REF_,Epm_rpmEngSpd__TORQUESTRUCTURE_IMPL_Tqs_calc,Amf_facRelAir__TORQUESTRUCTURE_IMPL_Tqs_calc) + CharTable1_getAt_u16u16(_Tqs_atCool2tqDrag_CUR_REF_,Ctc_atCool__TORQUESTRUCTURE_IMPL_Tqs_calc);
   /* assignment to Tqs_tqDrag: min=0, max=65535, hex=256phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _Tqs_tqDrag = (uint16)(((_t1uint32 &lt;= 65535U) ? _t1uint32 : 65535U));
   /* assignment to temporary variable _t2: min=0, max=4294836225, hex=1048576phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _t2
      = (uint32)_Tqs_tqDrag * Isc_facIdleSpdStab__TORQUESTRUCTURE_IMPL_Tqs_calc;
   /* Tqs_calc: sequence call #7  */
   _t1uint32 = ((_t2 &lt;= 268427264U) ? _t2 >> 13 : 32767U);
   /* assignment to Tqs_tqMin: min=-32768, max=32767, hex=128phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   Tqs_tqMin__TORQUESTRUCTURE_IMPL_Tqs_calc = (sint16)_t1uint32;
   /* Tqs_calc: sequence call #8  */
   _t1sint16
      = ((_Tqs_flgIdleSpdCtrlEnable &amp;&amp; _t1) ? _Tqs_tqIdleSpdCtrlCorr : 0);
   _t1uint32 = (uint32)_Tqs_tqMax &lt;&lt; 3;
   _t2uint32 = _t2 >> 9;
   _t1sint32
      = (sint32)_Tqs_facEgasFilt * ((sint32)_t1uint32 - (sint32)_t2uint32);
   _t1uint32 = _t2 >> 13;
   _t1sint32
      = _t1sint16 + (((_t1sint32 > -1073741824) ? _t1sint32 >> 12 : -262144)) + (sint32)_t1uint32;
   /* assignment to Tqs_tqReqCalc: min=-32768, max=32767, hex=128phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _Tqs_tqReqCalc
      = (sint16)(((_t1sint32 >= -32768) ? ((_t1sint32 &lt;= 32767) ? _t1sint32 : 32767) : -32768));
   /* Tqs_calc: sequence call #9  */
   /* assignment to Tqs_tqReq: min=-32768, max=32767, hex=128phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   Tqs_tqReq__TORQUESTRUCTURE_IMPL_Tqs_calc
      = ((_Tqs_flgTorqueReqOverride) ? _Tqs_tqReqMan : _Tqs_tqReqCalc);
   /* send messages implicitly */
   {
      DisableAllInterrupts();
      Tqs_tqMin = Tqs_tqMin__TORQUESTRUCTURE_IMPL_Tqs_calc;
      Tqs_tqReq = Tqs_tqReq__TORQUESTRUCTURE_IMPL_Tqs_calc;
      EnableAllInterrupts();
   }
}
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF PROCESS 'TORQUESTRUCTURE_IMPL_Tqs_calc'
 ******************************************************************************/
#endif
/* END: ASCET REGION "Process Definition 'Tqs_calc'" */


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
