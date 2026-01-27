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
 * Name:....................."FuelMass"
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
 * model name:...................................'Fmc'
 * reason:.......................................no local elements
 * ---------------------------------------------------------------------------*/

/* END: ASCET REGION "Module Data Definitions" */

/* BEGIN: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Fmc_facKFuelMassCorr'
 * ---------------------------------------------------------------------------*/
const real32 Fmc_facKFuelMassCorr = 0.001F;
   /* min=0.001, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Fmc_facKFuelMassCorr'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Fmc_flgFuelMassCorrEnable'
 * ---------------------------------------------------------------------------*/
const uint8 Fmc_flgFuelMassCorrEnable = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Fmc_flgFuelMassCorrEnable'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Fmc_flgFuelMassOverride'
 * ---------------------------------------------------------------------------*/
const uint8 Fmc_flgFuelMassOverride = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Fmc_flgFuelMassOverride'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Fmc_mFuelBase'
 * ---------------------------------------------------------------------------*/
uint16 Fmc_mFuelBase = 0;
   /* min=0.0, max=9.99984741210938e-1, fac_65536, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Fmc_mFuelBase'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Fmc_mFuelCalc'
 * ---------------------------------------------------------------------------*/
uint16 Fmc_mFuelCalc = 0;
   /* min=0.0, max=9.99984741210938e-1, fac_65536, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Fmc_mFuelCalc'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Fmc_mFuelCorr'
 * ---------------------------------------------------------------------------*/
sint16 Fmc_mFuelCorr = 0;
   /* min=-0.5, max=4.99984741210938e-1, fac_65536, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Fmc_mFuelCorr'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Fmc_mFuelKgPerHour'
 * ---------------------------------------------------------------------------*/
uint16 Fmc_mFuelKgPerHour = 0;
   /* min=0.0, max=31.99951171875, fac_2048, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Fmc_mFuelKgPerHour'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Fmc_mFuelMan'
 * ---------------------------------------------------------------------------*/
const uint16 Fmc_mFuelMan = 0;
   /* min=0.0, max=9.99984741210938e-1, fac_65536, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Fmc_mFuelMan'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Fmc_specific_fuel_consumption'
 * ---------------------------------------------------------------------------*/
uint16 Fmc_specific_fuel_consumption = 0;
   /* min=0.0, max=1023.984375, fac_64, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Fmc_specific_fuel_consumption'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Fmc_tiTFuelMassCorr'
 * ---------------------------------------------------------------------------*/
const real32 Fmc_tiTFuelMassCorr = 1.0F;
   /* min=0.001, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Fmc_tiTFuelMassCorr'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Fmc_tiTaFuelMassCorr'
 * ---------------------------------------------------------------------------*/
real64 Fmc_tiTaFuelMassCorr = 0.001;
   /* min=0.001, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Fmc_tiTaFuelMassCorr'
 ******************************************************************************/

/* END: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF MESSAGES
 * ----------------------------------------------------------------------------
 * Total size is [bytes]:........................2
 * ---------------------------------------------------------------------------*/
/* messages of memory class:............................................'RAM' */
/* messages of size [bytes]:................................................2 */
/* modelled as 'Fmc_mFuel' */
uint16 Fmc_mFuel;
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF MESSAGES
 ******************************************************************************/

#define _DT1 DT1_Fmc
#define _DT1_REF_ (&amp;(DT1_Fmc))
#define _Fmc_facKFuelMassCorr Fmc_facKFuelMassCorr
#define _Fmc_flgFuelMassCorrEnable Fmc_flgFuelMassCorrEnable
#define _Fmc_flgFuelMassOverride Fmc_flgFuelMassOverride
#define _Fmc_mFuelBase Fmc_mFuelBase
#define _Fmc_mFuelCalc Fmc_mFuelCalc
#define _Fmc_mFuelCorr Fmc_mFuelCorr
#define _Fmc_mFuelKgPerHour Fmc_mFuelKgPerHour
#define _Fmc_mFuelMan Fmc_mFuelMan
#define _Fmc_specific_fuel_consumption Fmc_specific_fuel_consumption
#define _Fmc_tiTaFuelMassCorr Fmc_tiTaFuelMassCorr
#define _Fmc_tiTFuelMassCorr Fmc_tiTFuelMassCorr

/* BEGIN: ASCET REGION "Component Functions" */
/******************************************************************************
 * BEGIN: FUNCTIONS OF COMPONENT
 ******************************************************************************/

/* BEGIN: ASCET REGION "Process Definition 'Fmc_calc'" */
/******************************************************************************
 * BEGIN: DEFINITION OF PROCESS 'FUELMASS_IMPL_Fmc_calc'
 * ----------------------------------------------------------------------------
 * model name:...................................'Fmc_calc'
 * memory class:.................................'CODE'
 * ---------------------------------------------------------------------------*/
//#if defined(COMPILE_UNUSED_CODE) || defined(COMPILE_UNUSED__FUELMASS_IMPL_Fmc_calc)
/* messages used by this process */

/* public Fmc_calc []  */

void FUELMASS_IMPL_Fmc_calc (void)
{
   /* temp. variables */
   real64 _t1real64;
   sint32 _t1sint32;
   uint16 _t1uint16;
   uint32 _t1uint32;
   sint32 _t2sint32;
   sint16 _t1sint16;

   /* define local message copies */
   uint16 Afr_facRatio__FUELMASS_IMPL_Fmc_calc;
   uint16 Amf_mAirPerStr__FUELMASS_IMPL_Fmc_calc;
   sint16 Epm_rpmEngSpd__FUELMASS_IMPL_Fmc_calc;
   uint16 Fmc_mFuel__FUELMASS_IMPL_Fmc_calc;
   sint16 Itc_tiInjOffset__FUELMASS_IMPL_Fmc_calc;
   uint16 Lcc_facLambdaCorr__FUELMASS_IMPL_Fmc_calc;
   sint16 Tqs_tqReq__FUELMASS_IMPL_Fmc_calc;
   /* receive messages implicitly */
   {
      DisableAllInterrupts();
      Afr_facRatio__FUELMASS_IMPL_Fmc_calc = Afr_facRatio;
      Amf_mAirPerStr__FUELMASS_IMPL_Fmc_calc = Amf_mAirPerStr;
      Epm_rpmEngSpd__FUELMASS_IMPL_Fmc_calc = Epm_rpmEngSpd;
      Fmc_mFuel__FUELMASS_IMPL_Fmc_calc = Fmc_mFuel;
      Itc_tiInjOffset__FUELMASS_IMPL_Fmc_calc = Itc_tiInjOffset;
      Lcc_facLambdaCorr__FUELMASS_IMPL_Fmc_calc = Lcc_facLambdaCorr;
      Tqs_tqReq__FUELMASS_IMPL_Fmc_calc = Tqs_tqReq;
      EnableAllInterrupts();
   }
   /* Fmc_calc: sequence call #1  */
   /* assignment to Fmc_mFuelBase: min=0, max=65535, hex=65536phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _Fmc_mFuelBase
      = (uint16)(((uint32)Amf_mAirPerStr__FUELMASS_IMPL_Fmc_calc &lt;&lt; 11) / Afr_facRatio__FUELMASS_IMPL_Fmc_calc);
   /* Fmc_calc: sequence call #2  */
   if (_Fmc_flgFuelMassCorrEnable)
   {
      /* If-block: sequence call #2/Then #1  */
      _t1real64
         = (((real64)Epm_rpmEngSpd__FUELMASS_IMPL_Fmc_calc == 0.0) ? 80.0 : 80.0 / (real64)Epm_rpmEngSpd__FUELMASS_IMPL_Fmc_calc);
      /* assignment to Fmc_tiTaFuelMassCorr: min=0, max=+oo, hex=phys, limit=n.a., zero incl.=true  */
      _Fmc_tiTaFuelMassCorr = ((_t1real64 &lt;= 40.0) ? _t1real64 : 40.0);
      /* If-block: sequence call #2/Then #2  */
      DT1_IMPL_compute((real64)_Fmc_mFuelBase * 1.52587890625e-5, (real64)_Fmc_facKFuelMassCorr, (real64)_Fmc_tiTFuelMassCorr, _Fmc_tiTaFuelMassCorr);
   }
   else
   {
      /* If-block: sequence call #2/Else #1  */
      DT1_IMPL_reset(0.0);
   } /* end if */
   /* Fmc_calc: sequence call #4  */
   _t1real64 = DT1_IMPL_out() * 65536.0;
   _t1real64 = ((_t1real64 &lt; 0.0) ? _t1real64 - 0.5 : _t1real64 + 0.5);
   /* assignment to Fmc_mFuelCorr: min=-32768, max=32767, hex=65536phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _Fmc_mFuelCorr
      = ((_t1real64 >= -32768.0) ? ((_t1real64 &lt;= 32767.0) ? (sint16)_t1real64 : 32767) : -32768);
   /* Fmc_calc: sequence call #5  */
   _t1sint32
      = (_Fmc_mFuelCorr + (sint32)_Fmc_mFuelBase) * (sint32)Lcc_facLambdaCorr__FUELMASS_IMPL_Fmc_calc;
   _t1sint32
      = ((_t1sint32 >= 0) ? (((uint32)_t1sint32 &lt;= 134215680U) ? _t1sint32 >> 11 : 65535) : 0);
   /* assignment to Fmc_mFuelCalc: min=0, max=65535, hex=65536phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _Fmc_mFuelCalc = (uint16)_t1sint32;
   /* Fmc_calc: sequence call #6  */
   /* assignment to Fmc_mFuel: min=0, max=65535, hex=65536phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   Fmc_mFuel__FUELMASS_IMPL_Fmc_calc
      = ((_Fmc_flgFuelMassOverride) ? _Fmc_mFuelMan : _Fmc_mFuelCalc);
   /* Fmc_calc: sequence call #7  */
   _t1sint32 = (sint32)Tqs_tqReq__FUELMASS_IMPL_Fmc_calc * 3141 / 16000;
   _t1uint16
      = ((_Fmc_flgFuelMassOverride) ? _Fmc_mFuelMan : _Fmc_mFuelCalc);
   _t1uint32 = (uint32)_t1uint16 * 63281U / 3U;
   _t2sint32
      = (sint32)_t1uint32 + ((sint32)Itc_tiInjOffset__FUELMASS_IMPL_Fmc_calc * 6681 >> 1);
   _t2sint32 = ((_t1sint32 == 0) ? _t2sint32 : _t2sint32 / _t1sint32);
   _t1sint32
      = ((_t2sint32 >= 0) ? ((_t2sint32 &lt;= 65535) ? _t2sint32 : 65535) : 0);
   /* assignment to Fmc_specific_fuel_consumption: min=0, max=65535, hex=64phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _Fmc_specific_fuel_consumption = (uint16)_t1sint32;
   /* Fmc_calc: sequence call #8  */
   _t1uint16
      = (((_Fmc_flgFuelMassOverride) ? _Fmc_mFuelMan : _Fmc_mFuelCalc)) >> 1;
   _t1sint16
      = (sint16)(Itc_tiInjOffset__FUELMASS_IMPL_Fmc_calc * 193328L / 9765625L) &lt;&lt; 2;
   _t2sint32
      = ((sint32)_t1uint16 + _t1sint16) * Epm_rpmEngSpd__FUELMASS_IMPL_Fmc_calc;
   _t1sint32
      = ((_t2sint32 >= 0) ? (((uint32)_t2sint32 &lt;= 23301333U) ? _t2sint32 * 9 / 3200 : 65535) : 0);
   /* assignment to Fmc_mFuelKgPerHour: min=0, max=65535, hex=2048phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _Fmc_mFuelKgPerHour = (uint16)_t1sint32;
   /* send messages implicitly */
   {
      Fmc_mFuel = Fmc_mFuel__FUELMASS_IMPL_Fmc_calc;
   }
}
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF PROCESS 'FUELMASS_IMPL_Fmc_calc'
 ******************************************************************************/
#endif
/* END: ASCET REGION "Process Definition 'Fmc_calc'" */


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
