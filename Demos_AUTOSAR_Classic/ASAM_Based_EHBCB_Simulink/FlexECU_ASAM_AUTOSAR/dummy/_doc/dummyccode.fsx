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
 * Name:....................."Dummy"
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
 * model name:...................................'dummy'
 * reason:.......................................no local elements
 * ---------------------------------------------------------------------------*/

/* END: ASCET REGION "Module Data Definitions" */

/* BEGIN: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'dummy_StarterReq'
 * ---------------------------------------------------------------------------*/
const uint8 dummy_StarterReq = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'dummy_StarterReq'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'dummy_facAirPumpRateReq'
 * ---------------------------------------------------------------------------*/
const uint16 dummy_facAirPumpRateReq = 500;
   /* min=0.05, max=0.95, fac_10000, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'dummy_facAirPumpRateReq'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'dummy_facChOverVlvRateReq'
 * ---------------------------------------------------------------------------*/
const uint16 dummy_facChOverVlvRateReq = 500;
   /* min=0.05, max=0.95, fac_10000, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'dummy_facChOverVlvRateReq'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'dummy_flgInterCoolerOverride'
 * ---------------------------------------------------------------------------*/
const uint8 dummy_flgInterCoolerOverride = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'dummy_flgInterCoolerOverride'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'dummy_flgKl50Override'
 * ---------------------------------------------------------------------------*/
const uint8 dummy_flgKl50Override = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'dummy_flgKl50Override'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'dummy_flgT2tOverride'
 * ---------------------------------------------------------------------------*/
const uint8 dummy_flgT2tOverride = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'dummy_flgT2tOverride'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'dummy_rpmFuelPumpMin'
 * ---------------------------------------------------------------------------*/
const sint16 dummy_rpmFuelPumpMin = 200;
   /* min=0.0, max=16383.5, fac_2, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'dummy_rpmFuelPumpMin'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'dummy_stAirInjReacPumpReq'
 * ---------------------------------------------------------------------------*/
const uint8 dummy_stAirInjReacPumpReq = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'dummy_stAirInjReacPumpReq'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'dummy_stFuelPumpReq'
 * ---------------------------------------------------------------------------*/
const uint8 dummy_stFuelPumpReq = true;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'dummy_stFuelPumpReq'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'dummy_stIntercoolerReq'
 * ---------------------------------------------------------------------------*/
const uint8 dummy_stIntercoolerReq = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'dummy_stIntercoolerReq'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'dummy_stMainRelaisReq'
 * ---------------------------------------------------------------------------*/
const uint8 dummy_stMainRelaisReq = true;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'dummy_stMainRelaisReq'
 ******************************************************************************/

/* END: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF MESSAGES
 * ----------------------------------------------------------------------------
 * Total size is [bytes]:........................11
 * ---------------------------------------------------------------------------*/
/* messages of memory class:............................................'RAM' */
/* messages of size [bytes]:................................................2 */
/* modelled as 'dummy_facAirPumpRate' */
uint16 dummy_facAirPumpRate;
/* modelled as 'dummy_facChOverVlvRate' */
uint16 dummy_facChOverVlvRate;
/* modelled as 'dummy_facThrValveReq' */
sint16 dummy_facThrValveReq;
/* messages of size [bytes]:................................................1 */
/* modelled as 'dummy_Starter' */
uint8 dummy_Starter;
/* modelled as 'dummy_stAirInjReacPump' */
uint8 dummy_stAirInjReacPump;
/* modelled as 'dummy_stFuelPump' */
uint8 dummy_stFuelPump;
/* modelled as 'dummy_stIntercooler' */
uint8 dummy_stIntercooler;
/* modelled as 'dummy_stMainRelais' */
uint8 dummy_stMainRelais;
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF MESSAGES
 ******************************************************************************/

#define _dummy_facAirPumpRateReq dummy_facAirPumpRateReq
#define _dummy_facChOverVlvRateReq dummy_facChOverVlvRateReq
#define _dummy_flgInterCoolerOverride dummy_flgInterCoolerOverride
#define _dummy_flgKl50Override dummy_flgKl50Override
#define _dummy_flgT2tOverride dummy_flgT2tOverride
#define _dummy_rpmFuelPumpMin dummy_rpmFuelPumpMin
#define _dummy_stAirInjReacPumpReq dummy_stAirInjReacPumpReq
#define _dummy_StarterReq dummy_StarterReq
#define _dummy_stFuelPumpReq dummy_stFuelPumpReq
#define _dummy_stIntercoolerReq dummy_stIntercoolerReq
#define _dummy_stMainRelaisReq dummy_stMainRelaisReq

/* BEGIN: ASCET REGION "Component Functions" */
/******************************************************************************
 * BEGIN: FUNCTIONS OF COMPONENT
 ******************************************************************************/

/* BEGIN: ASCET REGION "Process Definition 'dummy_calc'" */
/******************************************************************************
 * BEGIN: DEFINITION OF PROCESS 'DUMMY_IMPL_dummy_calc'
 * ----------------------------------------------------------------------------
 * model name:...................................'dummy_calc'
 * memory class:.................................'CODE'
 * ---------------------------------------------------------------------------*/
//#if defined(COMPILE_UNUSED_CODE) || defined(COMPILE_UNUSED__DUMMY_IMPL_dummy_calc)
/* messages used by this process */

/* public dummy_calc []  */

void DUMMY_IMPL_dummy_calc (void)
{
   /* define local message copies */
   uint16 Egc_facEgas__DUMMY_IMPL_dummy_calc;
   sint16 Epm_rpmEngSpd__DUMMY_IMPL_dummy_calc;
   uint8 ICC_flgInterCooler__DUMMY_IMPL_dummy_calc;
   uint8 Kl50_stKlemme50__DUMMY_IMPL_dummy_calc;
   sint16 T2t_facThrValveReq__DUMMY_IMPL_dummy_calc;
   uint8 dummy_Starter__DUMMY_IMPL_dummy_calc;
   uint16 dummy_facAirPumpRate__DUMMY_IMPL_dummy_calc;
   uint16 dummy_facChOverVlvRate__DUMMY_IMPL_dummy_calc;
   sint16 dummy_facThrValveReq__DUMMY_IMPL_dummy_calc;
   uint8 dummy_stAirInjReacPump__DUMMY_IMPL_dummy_calc;
   uint8 dummy_stFuelPump__DUMMY_IMPL_dummy_calc;
   uint8 dummy_stIntercooler__DUMMY_IMPL_dummy_calc;
   uint8 dummy_stMainRelais__DUMMY_IMPL_dummy_calc;
   /* receive messages implicitly */
   {
      DisableAllInterrupts();
      Egc_facEgas__DUMMY_IMPL_dummy_calc = Egc_facEgas;
      Epm_rpmEngSpd__DUMMY_IMPL_dummy_calc = Epm_rpmEngSpd;
      ICC_flgInterCooler__DUMMY_IMPL_dummy_calc = ICC_flgInterCooler;
      Kl50_stKlemme50__DUMMY_IMPL_dummy_calc = Kl50_stKlemme50;
      T2t_facThrValveReq__DUMMY_IMPL_dummy_calc = T2t_facThrValveReq;
      dummy_Starter__DUMMY_IMPL_dummy_calc = dummy_Starter;
      dummy_facAirPumpRate__DUMMY_IMPL_dummy_calc = dummy_facAirPumpRate;
      dummy_facChOverVlvRate__DUMMY_IMPL_dummy_calc = dummy_facChOverVlvRate;
      dummy_facThrValveReq__DUMMY_IMPL_dummy_calc = dummy_facThrValveReq;
      dummy_stAirInjReacPump__DUMMY_IMPL_dummy_calc = dummy_stAirInjReacPump;
      dummy_stFuelPump__DUMMY_IMPL_dummy_calc = dummy_stFuelPump;
      dummy_stIntercooler__DUMMY_IMPL_dummy_calc = dummy_stIntercooler;
      dummy_stMainRelais__DUMMY_IMPL_dummy_calc = dummy_stMainRelais;
      EnableAllInterrupts();
   }
   /* dummy_calc: sequence call #1  */
   /* assignment to dummy_facThrValveReq: min=-66, max=512, hex=512phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   dummy_facThrValveReq__DUMMY_IMPL_dummy_calc
      = ((_dummy_flgT2tOverride) ? (sint16)Egc_facEgas__DUMMY_IMPL_dummy_calc : T2t_facThrValveReq__DUMMY_IMPL_dummy_calc);
   /* dummy_calc: sequence call #3  */
   /* assignment to dummy_facAirPumpRate: min=500, max=9500, hex=10000phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   dummy_facAirPumpRate__DUMMY_IMPL_dummy_calc = _dummy_facAirPumpRateReq;
   /* dummy_calc: sequence call #4  */
   /* assignment to dummy_facChOverVlvRate: min=500, max=9500, hex=10000phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   dummy_facChOverVlvRate__DUMMY_IMPL_dummy_calc = _dummy_facChOverVlvRateReq;
   /* dummy_calc: sequence call #5  */
   dummy_stMainRelais__DUMMY_IMPL_dummy_calc = _dummy_stMainRelaisReq;
   /* dummy_calc: sequence call #6  */
   dummy_stFuelPump__DUMMY_IMPL_dummy_calc
      = _dummy_stFuelPumpReq &amp;&amp; Epm_rpmEngSpd__DUMMY_IMPL_dummy_calc > _dummy_rpmFuelPumpMin;
   /* dummy_calc: sequence call #8  */
   dummy_stIntercooler__DUMMY_IMPL_dummy_calc
      = ((_dummy_flgInterCoolerOverride) ? _dummy_stIntercoolerReq : ICC_flgInterCooler__DUMMY_IMPL_dummy_calc);
   /* dummy_calc: sequence call #9  */
   dummy_stAirInjReacPump__DUMMY_IMPL_dummy_calc = _dummy_stAirInjReacPumpReq;
   /* dummy_calc: sequence call #10  */
   dummy_Starter__DUMMY_IMPL_dummy_calc
      = ((_dummy_flgKl50Override) ? _dummy_StarterReq : Kl50_stKlemme50__DUMMY_IMPL_dummy_calc);
   /* send messages implicitly */
   {
      DisableAllInterrupts();
      dummy_Starter = dummy_Starter__DUMMY_IMPL_dummy_calc;
      dummy_facAirPumpRate = dummy_facAirPumpRate__DUMMY_IMPL_dummy_calc;
      dummy_facChOverVlvRate = dummy_facChOverVlvRate__DUMMY_IMPL_dummy_calc;
      dummy_facThrValveReq = dummy_facThrValveReq__DUMMY_IMPL_dummy_calc;
      dummy_stAirInjReacPump = dummy_stAirInjReacPump__DUMMY_IMPL_dummy_calc;
      dummy_stFuelPump = dummy_stFuelPump__DUMMY_IMPL_dummy_calc;
      dummy_stIntercooler = dummy_stIntercooler__DUMMY_IMPL_dummy_calc;
      dummy_stMainRelais = dummy_stMainRelais__DUMMY_IMPL_dummy_calc;
      EnableAllInterrupts();
   }
}
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF PROCESS 'DUMMY_IMPL_dummy_calc'
 ******************************************************************************/
#endif
/* END: ASCET REGION "Process Definition 'dummy_calc'" */


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
