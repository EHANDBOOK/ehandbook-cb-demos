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
 * Name:....................."IgnitionAngle"
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
 * DEFINITION OF COMPONENT VARIABLE OMITTED
 * ----------------------------------------------------------------------------
 * memory class:.................................'ROM'
 * model name:...................................'Iac'
 * reason:.......................................no local elements
 * ---------------------------------------------------------------------------*/

/* END: ASCET REGION "Module Data Definitions" */

/* BEGIN: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Iac_degIgnBase'
 * ---------------------------------------------------------------------------*/
sint8 Iac_degIgnBase = 0;
   /* min=-72.0, max=78.0, IGN_4div3, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Iac_degIgnBase'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Iac_degIgnOptOffset'
 * ---------------------------------------------------------------------------*/
const sint8 Iac_degIgnOptOffset = 0;
   /* min=-72.0, max=78.0, IGN_4div3, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Iac_degIgnOptOffset'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'Iac_deltaDegIgn'
 * ---------------------------------------------------------------------------*/
const struct CharTable1_uint16_12_uint8_IGNITIONANGLE_IMPL_TYPE Iac_deltaDegIgn = {
      12,
      {
         1000, 1200, 1900, 2800, 4000, 5500, 7000, 8200, 9000, 9750, 9900, 10000
      },
      {
         74, 74, 74, 74, 67, 53, 60, 44, 30, 20, 11, 0
      }
   };
   /* result: min=0.0, max=55.5, IGN_4div3, limit=no */
   /* x axis: min=0.1, max=1.0, fac_10000 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'Iac_deltaDegIgn'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Iac_flgIgnCutoffReq'
 * ---------------------------------------------------------------------------*/
const uint8 Iac_flgIgnCutoffReq = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Iac_flgIgnCutoffReq'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Iac_pManiReqMin'
 * ---------------------------------------------------------------------------*/
const uint16 Iac_pManiReqMin = 20000;
   /* min=0.0, max=65535.0, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Iac_pManiReqMin'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'Iac_rpmEngSpdfacRelAir2degBase_MAP'
 * ---------------------------------------------------------------------------*/
const struct CharTable2_sint16_16_uint16_16_sint8_IGNITIONANGLE_IMPL_TYPE Iac_rpmEngSpdfacRelAir2degBase_MAP = {
      16,
      16,
      {
         1500, 2000, 2500, 3000, 3500, 4000, 4500, 5000, 5500, 6000, 7000, 8000, 9000,
         10000, 10500, 11600
      },
      {
         84, 104, 196, 257, 319, 376, 438, 499, 557, 618, 680, 737, 799, 860, 918, 979
      },
      {
         41, 40, 34, 28, 21, 16, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         41, 40, 34, 28, 21, 16, 8, 5, 0, 0, 0, 0, 0, 0, 0, 0,
         40, 40, 34, 28, 21, 16, 9, 6, 0, 0, 0, 0, 0, 0, 0, 0,
         40, 40, 35, 29, 22, 16, 10, 7, 0, 0, 0, 0, 0, 0, 0, 0,
         40, 40, 35, 29, 24, 20, 11, 7, 1, 0, 0, 0, 0, 0, 0, 0,
         40, 40, 34, 28, 25, 24, 11, 7, 2, 0, 0, 0, 0, 0, 0, 0,
         40, 40, 37, 30, 27, 25, 13, 8, 4, 1, 1, 0, 0, 0, 0, 0,
         40, 40, 39, 32, 29, 26, 14, 9, 6, 3, 1, 0, 0, 0, 0, 0,
         40, 40, 38, 31, 28, 24, 15, 11, 9, 5, 3, 2, 0, 0, 0, 0,
         40, 39, 36, 30, 27, 22, 15, 13, 11, 7, 5, 3, 0, 0, 0, 0,
         40, 38, 31, 30, 27, 23, 21, 16, 11, 6, 4, 2, 1, 0, 0, 0,
         34, 33, 28, 26, 23, 22, 21, 18, 14, 11, 6, 4, 2, 1, 0, 0,
         38, 37, 33, 30, 26, 23, 20, 14, 13, 11, 8, 5, 3, 2, 1, 0,
         40, 40, 37, 31, 28, 25, 22, 17, 13, 11, 8, 6, 4, 3, 2, 1,
         40, 40, 33, 30, 27, 25, 24, 20, 18, 14, 10, 7, 5, 4, 3, 2,
         40, 40, 34, 31, 28, 27, 26, 22, 20, 16, 11, 8, 6, 5, 4, 3
      }
   };
   /* result: min=-96.0, max=95.25, IGN_4div3, limit=no */
   /* x axis: min=0.0, max=16383.5, fac_2 */
   /* y axis: min=0.0, max=2.5, fac_512 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'Iac_rpmEngSpdfacRelAir2degBase_MAP'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP'
 * ---------------------------------------------------------------------------*/
const struct CharTable2_sint16_16_uint16_16_sint8_IGNITIONANGLE_IMPL_TYPE Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP = {
      16,
      16,
      {
         1500, 2000, 2500, 3000, 3500, 4000, 4500, 5000, 5500, 6000, 7000, 8000, 9000,
         10000, 10500, 11600
      },
      {
         84, 104, 196, 257, 319, 376, 438, 499, 557, 618, 680, 737, 799, 860, 918, 979
      },
      {
         41, 40, 34, 28, 21, 16, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         41, 40, 34, 28, 21, 16, 8, 5, 0, 0, 0, 0, 0, 0, 0, 0,
         40, 40, 34, 28, 21, 16, 9, 6, 0, 0, 0, 0, 0, 0, 0, 0,
         40, 40, 35, 29, 22, 16, 10, 7, 0, 0, 0, 0, 0, 0, 0, 0,
         40, 40, 35, 29, 24, 20, 11, 7, 1, 0, 0, 0, 0, 0, 0, 0,
         40, 40, 34, 28, 25, 24, 11, 7, 2, 0, 0, 0, 0, 0, 0, 0,
         40, 40, 37, 30, 27, 25, 13, 8, 4, 1, 1, 0, 0, 0, 0, 0,
         40, 40, 39, 32, 29, 26, 14, 9, 6, 3, 1, 0, 0, 0, 0, 0,
         40, 40, 38, 31, 28, 24, 15, 11, 9, 5, 3, 2, 0, 0, 0, 0,
         40, 39, 36, 30, 27, 22, 15, 13, 11, 7, 5, 3, 0, 0, 0, 0,
         40, 38, 31, 30, 27, 23, 21, 16, 11, 6, 4, 2, 1, 0, 0, 0,
         34, 33, 28, 26, 23, 22, 21, 18, 14, 11, 6, 4, 2, 1, 0, 0,
         38, 37, 33, 30, 26, 23, 20, 14, 13, 11, 8, 5, 3, 2, 1, 0,
         40, 40, 37, 31, 28, 25, 22, 17, 13, 11, 8, 6, 4, 3, 2, 1,
         40, 40, 33, 30, 27, 25, 24, 20, 18, 14, 10, 7, 5, 4, 3, 2,
         40, 40, 34, 31, 28, 27, 26, 22, 20, 16, 11, 8, 6, 5, 4, 3
      }
   };
   /* result: min=-96.0, max=95.25, IGN_4div3, limit=no */
   /* x axis: min=0.0, max=16383.5, fac_2 */
   /* y axis: min=0.0, max=2.5, fac_512 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP'
 ******************************************************************************/

/* END: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF MESSAGES
 * ----------------------------------------------------------------------------
 * Total size is [bytes]:........................4
 * ---------------------------------------------------------------------------*/
/* messages of memory class:............................................'RAM' */
/* messages of size [bytes]:................................................1 */
/* modelled as 'Iac_degIgn' */
sint8 Iac_degIgn;
/* modelled as 'Iac_degIgnIdleSpeed' */
sint8 Iac_degIgnIdleSpeed;
/* modelled as 'Iac_degMinAdvBestTq' */
sint8 Iac_degMinAdvBestTq;
/* modelled as 'Iac_flgIgnCutoff' */
uint8 Iac_flgIgnCutoff;
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF MESSAGES
 ******************************************************************************/

#define _Iac_degIgnBase Iac_degIgnBase
#define _Iac_degIgnOptOffset Iac_degIgnOptOffset
#define _Iac_deltaDegIgn Iac_deltaDegIgn
#define _Iac_deltaDegIgn_REF_ (&amp;(Iac_deltaDegIgn))
#define _Iac_flgIgnCutoffReq Iac_flgIgnCutoffReq
#define _Iac_pManiReqMin Iac_pManiReqMin
#define _Iac_rpmEngSpdfacRelAir2degBase_MAP Iac_rpmEngSpdfacRelAir2degBase_MAP
#define _Iac_rpmEngSpdfacRelAir2degBase_MAP_REF_ (&amp;(Iac_rpmEngSpdfacRelAir2degBase_MAP))
#define _Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP
#define _Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_REF_ (&amp;(Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP))

/* BEGIN: ASCET REGION "Component Functions" */
/******************************************************************************
 * BEGIN: FUNCTIONS OF COMPONENT
 ******************************************************************************/

/* BEGIN: ASCET REGION "Process Definition 'Iac_calc'" */
/******************************************************************************
 * BEGIN: DEFINITION OF PROCESS 'IGNITIONANGLE_IMPL_Iac_calc'
 * ----------------------------------------------------------------------------
 * model name:...................................'Iac_calc'
 * memory class:.................................'CODE'
 * ---------------------------------------------------------------------------*/
//#if defined(COMPILE_UNUSED_CODE) || defined(COMPILE_UNUSED__IGNITIONANGLE_IMPL_Iac_calc)
/* messages used by this process */

/* public Iac_calc []  */

void IGNITIONANGLE_IMPL_Iac_calc (void)
{
   /* temp. variables */
   sint8 _t1sint8;
   sint16 _t1sint16;
   uint32 _t1uint32;
   sint32 _t1sint32;
   uint32 _t2uint32;
   sint32 _t2sint32;
   sint32 _t3sint32;
   sint32 _t4sint32;
   uint16 _t1uint16;
   sint32 _t5sint32;
   uint8 _t1uint8;

   /* define local message copies */
   uint16 Amf_facRelAir__IGNITIONANGLE_IMPL_Iac_calc;
   sint16 Epm_rpmEngSpd__IGNITIONANGLE_IMPL_Iac_calc;
   sint8 Iac_degIgn__IGNITIONANGLE_IMPL_Iac_calc;
   sint8 Iac_degIgnIdleSpeed__IGNITIONANGLE_IMPL_Iac_calc;
   sint8 Iac_degMinAdvBestTq__IGNITIONANGLE_IMPL_Iac_calc;
   uint8 Iac_flgIgnCutoff__IGNITIONANGLE_IMPL_Iac_calc;
   uint8 Isc_flgIdleSpdCtrlActive__IGNITIONANGLE_IMPL_Iac_calc;
   uint16 Mpc_pManiFilt__IGNITIONANGLE_IMPL_Iac_calc;
   uint8 Stc_flgCatalyserHeating__IGNITIONANGLE_IMPL_Iac_calc;
   uint16 T2t_pManiReqFast__IGNITIONANGLE_IMPL_Iac_calc;
   /* receive messages implicitly */
   {
      DisableAllInterrupts();
      Amf_facRelAir__IGNITIONANGLE_IMPL_Iac_calc = Amf_facRelAir;
      Epm_rpmEngSpd__IGNITIONANGLE_IMPL_Iac_calc = Epm_rpmEngSpd;
      Iac_degIgn__IGNITIONANGLE_IMPL_Iac_calc = Iac_degIgn;
      Iac_degIgnIdleSpeed__IGNITIONANGLE_IMPL_Iac_calc = Iac_degIgnIdleSpeed;
      Iac_degMinAdvBestTq__IGNITIONANGLE_IMPL_Iac_calc = Iac_degMinAdvBestTq;
      Iac_flgIgnCutoff__IGNITIONANGLE_IMPL_Iac_calc = Iac_flgIgnCutoff;
      Isc_flgIdleSpdCtrlActive__IGNITIONANGLE_IMPL_Iac_calc = Isc_flgIdleSpdCtrlActive;
      Mpc_pManiFilt__IGNITIONANGLE_IMPL_Iac_calc = Mpc_pManiFilt;
      Stc_flgCatalyserHeating__IGNITIONANGLE_IMPL_Iac_calc = Stc_flgCatalyserHeating;
      T2t_pManiReqFast__IGNITIONANGLE_IMPL_Iac_calc = T2t_pManiReqFast;
      EnableAllInterrupts();
   }
   /* Iac_calc: sequence call #1  */
   /* assignment to Iac_degMinAdvBestTq: min=-128, max=127, hex=4/3phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   Iac_degMinAdvBestTq__IGNITIONANGLE_IMPL_Iac_calc
      = CharTable2_getAt_s16u16s8(_Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_REF_,Epm_rpmEngSpd__IGNITIONANGLE_IMPL_Iac_calc,Amf_facRelAir__IGNITIONANGLE_IMPL_Iac_calc);
   /* Iac_calc: sequence call #2  */
   _t1sint8
      = CharTable2_getAt_s16u16s8(_Iac_rpmEngSpdfacRelAir2degBase_MAP_REF_,Epm_rpmEngSpd__IGNITIONANGLE_IMPL_Iac_calc,Amf_facRelAir__IGNITIONANGLE_IMPL_Iac_calc);
   /* assignment to Iac_degIgnBase: min=-96, max=104, hex=4/3phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _Iac_degIgnBase
      = ((_t1sint8 &gt;= -96) ? ((_t1sint8 &lt;= 104) ? _t1sint8 : 104) : -96);
   /* Iac_calc: sequence call #3  */
   Iac_flgIgnCutoff__IGNITIONANGLE_IMPL_Iac_calc = _Iac_flgIgnCutoffReq;
   /* Iac_calc: sequence call #4  */
   _t1sint16 = (sint16)_Iac_degIgnOptOffset + _Iac_degIgnBase;
   /* assignment to Iac_degIgn: min=-96, max=104, hex=4/3phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   Iac_degIgn__IGNITIONANGLE_IMPL_Iac_calc
      = (sint8)(((_t1sint16 &gt;= -96) ? ((_t1sint16 &lt;= 104) ? _t1sint16 : 104) : -96));
   /* Iac_calc: sequence call #5  */
   _t1uint8
      = ((Isc_flgIdleSpdCtrlActive__IGNITIONANGLE_IMPL_Iac_calc || Stc_flgCatalyserHeating__IGNITIONANGLE_IMPL_Iac_calc) ? (_t1sint16
      = ((Stc_flgCatalyserHeating__IGNITIONANGLE_IMPL_Iac_calc) ? 2000 : 7000) ,  _t1uint32 = (uint32)Mpc_pManiFilt__IGNITIONANGLE_IMPL_Iac_calc &lt;&lt; 2 ,  _t1sint32 = (sint32)_t1uint32 - (sint32)_Iac_pManiReqMin ,  _t2uint32 = (uint32)T2t_pManiReqFast__IGNITIONANGLE_IMPL_Iac_calc &lt;&lt; 2 ,  _t2sint32 = ((sint32)_t2uint32 - (sint32)_Iac_pManiReqMin) * 5000 ,  _t3sint32
      = (_t1sint32 ,  ((_t1sint32 == 0) ? _t2sint32 : _t2sint32 / _t1sint32)) ,  _t4sint32
      = ((_t3sint32 &gt;= -1073741824) ? ((_t3sint32 &lt;= 5000) ? _t3sint32 &lt;&lt; 1 : 10000) : (sint32)SINT32_MIN) ,  _t5sint32
      = ((_t1sint16 &gt;= _t4sint32) ? (_t1uint16
      = ((Stc_flgCatalyserHeating__IGNITIONANGLE_IMPL_Iac_calc) ? 2000U : 7000U) ,  (sint32)_t1uint16) : _t4sint32) ,  CharTable1_getAt_u16u8(_Iac_deltaDegIgn_REF_,(uint16)_t5sint32)) : 0U);
   _t1sint16 = Iac_degIgn__IGNITIONANGLE_IMPL_Iac_calc - (sint16)_t1uint8;
   /* assignment to Iac_degIgnIdleSpeed: min=-96, max=104, hex=4/3phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   Iac_degIgnIdleSpeed__IGNITIONANGLE_IMPL_Iac_calc = (sint8)(((_t1sint16 > -96) ? _t1sint16 : -96));
   /* send messages implicitly */
   {
      DisableAllInterrupts();
      Iac_degIgn = Iac_degIgn__IGNITIONANGLE_IMPL_Iac_calc;
      Iac_degIgnIdleSpeed = Iac_degIgnIdleSpeed__IGNITIONANGLE_IMPL_Iac_calc;
      Iac_degMinAdvBestTq = Iac_degMinAdvBestTq__IGNITIONANGLE_IMPL_Iac_calc;
      Iac_flgIgnCutoff = Iac_flgIgnCutoff__IGNITIONANGLE_IMPL_Iac_calc;
      EnableAllInterrupts();
   }
}
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF PROCESS 'IGNITIONANGLE_IMPL_Iac_calc'
 ******************************************************************************/
#endif
/* END: ASCET REGION "Process Definition 'Iac_calc'" */


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
