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
 * Name:....................."LambdaControl"
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
 * BEGIN: DEFINITION OF SUBSTRUCT VARIABLE 'Lcc_RAM'
 * ----------------------------------------------------------------------------
 * memory class:.................................'RAM'
 * model name:...................................'Lcc'
 * data set:.....................................'LAMBDACONTROL_IMPL_Data'
 * ---------------------------------------------------------------------------*/
struct LAMBDACONTROL_IMPL_RAM_SUBSTRUCT Lcc_RAM = {
   /* substruct: Lcc_RAM.EdgeFalling (modeled as:'EdgeFalling.Lcc') */
   {
      /* struct element:'Lcc_RAM.EdgeFalling.buffer1' (modeled as:'buffer1.EdgeFalling.Lcc') */
      false,
      /* struct element:'Lcc_RAM.EdgeFalling.oldSignal1' (modeled as:'oldSignal1.EdgeFalling.Lcc') */
      false
   },
   /* substruct: Lcc_RAM.EdgeFalling_1 (modeled as:'EdgeFalling_1.Lcc') */
   {
      /* struct element:'Lcc_RAM.EdgeFalling_1.buffer1' (modeled as:'buffer1.EdgeFalling_1.Lcc') */
      false,
      /* struct element:'Lcc_RAM.EdgeFalling_1.oldSignal1' (modeled as:'oldSignal1.EdgeFalling_1.Lcc') */
      false
   },
   /* substruct: Lcc_RAM.EdgeRising (modeled as:'EdgeRising.Lcc') */
   {
      /* struct element:'Lcc_RAM.EdgeRising.buffer' (modeled as:'buffer.EdgeRising.Lcc') */
      false,
      /* struct element:'Lcc_RAM.EdgeRising.oldSignal' (modeled as:'oldSignal.EdgeRising.Lcc') */
      true
   },
   /* substruct: Lcc_RAM.EdgeRising_1 (modeled as:'EdgeRising_1.Lcc') */
   {
      /* struct element:'Lcc_RAM.EdgeRising_1.buffer' (modeled as:'buffer.EdgeRising_1.Lcc') */
      false,
      /* struct element:'Lcc_RAM.EdgeRising_1.oldSignal' (modeled as:'oldSignal.EdgeRising_1.Lcc') */
      true
   },
   /* substruct: Lcc_RAM.Integrator (modeled as:'Integrator.Lcc') */
   {
      /* struct element:'Lcc_RAM.Integrator.memory' (modeled as:'memory.Integrator.Lcc') */
      0.0
   },
   /* substruct: Lcc_RAM.PID_Limit_AWU (modeled as:'PID_Limit_AWU.Lcc') */
   {
      /* struct element:'Lcc_RAM.PID_Limit_AWU.inOLD' (modeled as:'inOLD.PID_Limit_AWU.Lcc') */
      0.0,
      /* struct element:'Lcc_RAM.PID_Limit_AWU.memory1' (modeled as:'memory1.PID_Limit_AWU.Lcc') */
      0.0,
      /* struct element:'Lcc_RAM.PID_Limit_AWU.memory2' (modeled as:'memory2.PID_Limit_AWU.Lcc') */
      0.0
   }
};
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF SUBSTRUCT VARIABLE 'Lcc_RAM'
 ******************************************************************************/

/******************************************************************************
 * BEGIN: DEFINITION OF COMPONENT VARIABLE 'Lcc'
 * ----------------------------------------------------------------------------
 * memory class:.................................'ROM'
 * model name:...................................'Lcc'
 * data set:.....................................'LAMBDACONTROL_IMPL_Data'
 * ---------------------------------------------------------------------------*/
const struct LAMBDACONTROL_IMPL Lcc = {
   /* substruct: Lcc.EdgeFalling (modeled as:'EdgeFalling.Lcc') */
   {
      /* type descriptor pointer 'EDGEFALLING_IMPL_RAM' for memory class substruct for 'RAM' */
      &amp;Lcc_RAM.EdgeFalling
   },
   /* substruct: Lcc.EdgeFalling_1 (modeled as:'EdgeFalling_1.Lcc') */
   {
      /* type descriptor pointer 'EDGEFALLING_IMPL_RAM' for memory class substruct for 'RAM' */
      &amp;Lcc_RAM.EdgeFalling_1
   },
   /* substruct: Lcc.EdgeRising (modeled as:'EdgeRising.Lcc') */
   {
      /* type descriptor pointer 'EDGERISING_IMPL_RAM' for memory class substruct for 'RAM' */
      &amp;Lcc_RAM.EdgeRising
   },
   /* substruct: Lcc.EdgeRising_1 (modeled as:'EdgeRising_1.Lcc') */
   {
      /* type descriptor pointer 'EDGERISING_IMPL_RAM' for memory class substruct for 'RAM' */
      &amp;Lcc_RAM.EdgeRising_1
   },
   /* substruct: Lcc.Integrator (modeled as:'Integrator.Lcc') */
   {
      /* type descriptor pointer 'INTEGRATOR_IMPL_RAM' for memory class substruct for 'RAM' */
      &amp;Lcc_RAM.Integrator
   },
   /* substruct: Lcc.PID_Limit_AWU (modeled as:'PID_Limit_AWU.Lcc') */
   {
      /* type descriptor pointer 'PID_LIMIT_AWU_IMPL_RAM' for memory class substruct for 'RAM' */
      &amp;Lcc_RAM.PID_Limit_AWU
   }
};
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF COMPONENT VARIABLE 'Lcc'
 ******************************************************************************/

/* END: ASCET REGION "Module Data Definitions" */

/* BEGIN: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'Lcc_EngSpd2facIntegrator_CUR'
 * ---------------------------------------------------------------------------*/
const struct CharTable1_real64_7_real64_LAMBDACONTROL_IMPL_TYPE Lcc_EngSpd2facIntegrator_CUR = {
      7,
      {
         400.0, 1000.0, 2000.0, 3000.0, 4000.0, 5000.0, 6000.0
      },
      {
         0.15, 0.22, 0.3, 0.45, 0.52, 0.6, 0.68
      }
   };
   /* result: min=-oo, max=+oo, ident, limit=no */
   /* x axis: min=-oo, max=+oo, ident */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'Lcc_EngSpd2facIntegrator_CUR'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Lcc_IntInitValvue'
 * ---------------------------------------------------------------------------*/
real64 Lcc_IntInitValvue = 0.0;
   /* min=-oo, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Lcc_IntInitValvue'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Lcc_IntStartValueTPC'
 * ---------------------------------------------------------------------------*/
const real64 Lcc_IntStartValueTPC = 1.0;
   /* min=-oo, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Lcc_IntStartValueTPC'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Lcc_LambdaCorrMaxPID'
 * ---------------------------------------------------------------------------*/
const real64 Lcc_LambdaCorrMaxPID = 2.0;
   /* min=-oo, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Lcc_LambdaCorrMaxPID'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Lcc_LambdaCorrMaxTPC'
 * ---------------------------------------------------------------------------*/
const real64 Lcc_LambdaCorrMaxTPC = 2.0;
   /* min=-oo, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Lcc_LambdaCorrMaxTPC'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Lcc_LambdaCorrMinPID'
 * ---------------------------------------------------------------------------*/
const real64 Lcc_LambdaCorrMinPID = 0.5;
   /* min=-oo, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Lcc_LambdaCorrMinPID'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Lcc_LambdaCorrMinTPC'
 * ---------------------------------------------------------------------------*/
const real64 Lcc_LambdaCorrMinTPC = 0.5;
   /* min=-oo, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Lcc_LambdaCorrMinTPC'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Lcc_StartValuePID'
 * ---------------------------------------------------------------------------*/
const real64 Lcc_StartValuePID = 1.0;
   /* min=-oo, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Lcc_StartValuePID'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Lcc_facInitValue'
 * ---------------------------------------------------------------------------*/
const real64 Lcc_facInitValue = 0.03;
   /* min=-oo, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Lcc_facInitValue'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'Lcc_facKLambdaCorrPID_MAP'
 * ---------------------------------------------------------------------------*/
const struct CharTable2_real64_12_real64_10_real64_LAMBDACONTROL_IMPL_TYPE Lcc_facKLambdaCorrPID_MAP = {
      12,
      10,
      {
         500.0, 1000.0, 1500.0, 2000.0, 2500.0, 3000.0, 3500.0, 4000.0, 4500.0, 5000.0,
         5500.0, 6000.0
      },
      {
         20000.0, 50000.0, 70000.0, 90000.0, 110000.0, 130000.0, 150000.0, 170000.0,
         190000.0, 210000.0
      },
      {
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0
      }
   };
   /* result: min=-oo, max=+oo, ident, limit=no */
   /* x axis: min=-oo, max=+oo, ident */
   /* y axis: min=-oo, max=+oo, ident */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'Lcc_facKLambdaCorrPID_MAP'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Lcc_flgLambdaControlActive'
 * ---------------------------------------------------------------------------*/
const uint8 Lcc_flgLambdaControlActive = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Lcc_flgLambdaControlActive'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Lcc_flgLambdacontrolActive_1'
 * ---------------------------------------------------------------------------*/
uint8 Lcc_flgLambdacontrolActive_1 = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Lcc_flgLambdacontrolActive_1'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Lcc_flgSwitch2PIDController'
 * ---------------------------------------------------------------------------*/
const uint8 Lcc_flgSwitch2PIDController = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Lcc_flgSwitch2PIDController'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'Lcc_tiTnLambdaCorrPID_MAP'
 * ---------------------------------------------------------------------------*/
const struct CharTable2_real64_12_real64_10_real64_LAMBDACONTROL_IMPL_TYPE Lcc_tiTnLambdaCorrPID_MAP = {
      12,
      10,
      {
         500.0, 1000.0, 1500.0, 2000.0, 2500.0, 3000.0, 3500.0, 4000.0, 4500.0, 5000.0,
         5500.0, 6000.0
      },
      {
         20000.0, 50000.0, 70000.0, 90000.0, 110000.0, 130000.0, 150000.0, 170000.0,
         190000.0, 210000.0
      },
      {
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
         1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0
      }
   };
   /* result: min=-oo, max=+oo, ident, limit=no */
   /* x axis: min=-oo, max=+oo, ident */
   /* y axis: min=-oo, max=+oo, ident */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'Lcc_tiTnLambdaCorrPID_MAP'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'Lcc_tiTvLambdaCorrPID_MAP'
 * ---------------------------------------------------------------------------*/
const struct CharTable2_real64_12_real64_10_real64_LAMBDACONTROL_IMPL_TYPE Lcc_tiTvLambdaCorrPID_MAP = {
      12,
      10,
      {
         500.0, 1000.0, 1500.0, 2000.0, 2500.0, 3000.0, 3500.0, 4000.0, 4500.0, 5000.0,
         5500.0, 6000.0
      },
      {
         20000.0, 50000.0, 70000.0, 90000.0, 110000.0, 130000.0, 150000.0, 170000.0,
         190000.0, 210000.0
      },
      {
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
         0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0
      }
   };
   /* result: min=-oo, max=+oo, ident, limit=no */
   /* x axis: min=-oo, max=+oo, ident */
   /* y axis: min=-oo, max=+oo, ident */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'Lcc_tiTvLambdaCorrPID_MAP'
 ******************************************************************************/

/* END: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF MESSAGES
 * ----------------------------------------------------------------------------
 * Total size is [bytes]:........................2
 * ---------------------------------------------------------------------------*/
/* messages of memory class:............................................'RAM' */
/* messages of size [bytes]:................................................2 */
/* modelled as 'Lcc_facLambdaCorr' */
uint16 Lcc_facLambdaCorr;
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF MESSAGES
 ******************************************************************************/

#define _EdgeFalling Lcc.EdgeFalling
#define _EdgeFalling_1 Lcc.EdgeFalling_1
#define _EdgeFalling_1_REF_ (&amp;(Lcc.EdgeFalling_1))
#define _EdgeFalling_REF_ (&amp;(Lcc.EdgeFalling))
#define _EdgeRising Lcc.EdgeRising
#define _EdgeRising_1 Lcc.EdgeRising_1
#define _EdgeRising_1_REF_ (&amp;(Lcc.EdgeRising_1))
#define _EdgeRising_REF_ (&amp;(Lcc.EdgeRising))
#define _Integrator Lcc.Integrator
#define _Integrator_REF_ (&amp;(Lcc.Integrator))
#define _Lcc_EngSpd2facIntegrator_CUR Lcc_EngSpd2facIntegrator_CUR
#define _Lcc_EngSpd2facIntegrator_CUR_REF_ (&amp;(Lcc_EngSpd2facIntegrator_CUR))
#define _Lcc_facInitValue Lcc_facInitValue
#define _Lcc_facKLambdaCorrPID_MAP Lcc_facKLambdaCorrPID_MAP
#define _Lcc_facKLambdaCorrPID_MAP_REF_ (&amp;(Lcc_facKLambdaCorrPID_MAP))
#define _Lcc_flgLambdaControlActive Lcc_flgLambdaControlActive
#define _Lcc_flgLambdacontrolActive_1 Lcc_flgLambdacontrolActive_1
#define _Lcc_flgSwitch2PIDController Lcc_flgSwitch2PIDController
#define _Lcc_IntInitValvue Lcc_IntInitValvue
#define _Lcc_IntStartValueTPC Lcc_IntStartValueTPC
#define _Lcc_LambdaCorrMaxPID Lcc_LambdaCorrMaxPID
#define _Lcc_LambdaCorrMaxTPC Lcc_LambdaCorrMaxTPC
#define _Lcc_LambdaCorrMinPID Lcc_LambdaCorrMinPID
#define _Lcc_LambdaCorrMinTPC Lcc_LambdaCorrMinTPC
#define _Lcc_StartValuePID Lcc_StartValuePID
#define _Lcc_tiTnLambdaCorrPID_MAP Lcc_tiTnLambdaCorrPID_MAP
#define _Lcc_tiTnLambdaCorrPID_MAP_REF_ (&amp;(Lcc_tiTnLambdaCorrPID_MAP))
#define _Lcc_tiTvLambdaCorrPID_MAP Lcc_tiTvLambdaCorrPID_MAP
#define _Lcc_tiTvLambdaCorrPID_MAP_REF_ (&amp;(Lcc_tiTvLambdaCorrPID_MAP))
#define _PID_Limit_AWU Lcc.PID_Limit_AWU
#define _PID_Limit_AWU_REF_ (&amp;(Lcc.PID_Limit_AWU))

/* BEGIN: ASCET REGION "Component Functions" */
/******************************************************************************
 * BEGIN: FUNCTIONS OF COMPONENT
 ******************************************************************************/

/* BEGIN: ASCET REGION "Process Definition 'Lcc_calc'" */
/******************************************************************************
 * BEGIN: DEFINITION OF PROCESS 'LAMBDACONTROL_IMPL_Lcc_calc'
 * ----------------------------------------------------------------------------
 * model name:...................................'Lcc_calc'
 * memory class:.................................'CODE'
 * ---------------------------------------------------------------------------*/
//#if defined(COMPILE_UNUSED_CODE) || defined(COMPILE_UNUSED__LAMBDACONTROL_IMPL_Lcc_calc)
/* messages used by this process */

/* public Lcc_calc []  */

void LAMBDACONTROL_IMPL_Lcc_calc (void)
{
   /* temp. variables */
   real64 _t1real64;

   /* define local message copies */
   uint16 Afr_facLambdaReq__LAMBDACONTROL_IMPL_Lcc_calc;
   sint16 Epm_rpmEngSpd__LAMBDACONTROL_IMPL_Lcc_calc;
   uint8 Isc_flgFuelCutoff__LAMBDACONTROL_IMPL_Lcc_calc;
   uint16 Lamsoni__LAMBDACONTROL_IMPL_Lcc_calc;
   uint16 Lcc_facLambdaCorr__LAMBDACONTROL_IMPL_Lcc_calc;
   uint16 Mpc_pManiFilt__LAMBDACONTROL_IMPL_Lcc_calc;
   uint8 Stc_flgFuelCorrActive__LAMBDACONTROL_IMPL_Lcc_calc;
   /* receive messages implicitly */
   {
      DisableAllInterrupts();
      Afr_facLambdaReq__LAMBDACONTROL_IMPL_Lcc_calc = Afr_facLambdaReq;
      Epm_rpmEngSpd__LAMBDACONTROL_IMPL_Lcc_calc = Epm_rpmEngSpd;
      Isc_flgFuelCutoff__LAMBDACONTROL_IMPL_Lcc_calc = Isc_flgFuelCutoff;
      Lamsoni__LAMBDACONTROL_IMPL_Lcc_calc = Lamsoni;
      Lcc_facLambdaCorr__LAMBDACONTROL_IMPL_Lcc_calc = Lcc_facLambdaCorr;
      Mpc_pManiFilt__LAMBDACONTROL_IMPL_Lcc_calc = Mpc_pManiFilt;
      Stc_flgFuelCorrActive__LAMBDACONTROL_IMPL_Lcc_calc = Stc_flgFuelCorrActive;
      EnableAllInterrupts();
   }
   /* Lcc_calc: sequence call #1  */
   _Lcc_flgLambdacontrolActive_1
      = !Isc_flgFuelCutoff__LAMBDACONTROL_IMPL_Lcc_calc &amp;&amp; _Lcc_flgLambdaControlActive &amp;&amp; !Stc_flgFuelCorrActive__LAMBDACONTROL_IMPL_Lcc_calc;
   /* Lcc_calc: sequence call #2  */
   /* assignment to Lcc_IntInitValvue: min=-oo, max=+oo, hex=phys, limit=n.a., zero incl.=true  */
   _Lcc_IntInitValvue
      = ((EDGERISING_IMPL_compute(_EdgeRising_1_REF_, _Lcc_flgLambdacontrolActive_1)
      || EDGEFALLING_IMPL_compute(_EdgeFalling_1_REF_, _Lcc_flgSwitch2PIDController)) ? _Lcc_IntStartValueTPC : (((!_Lcc_flgLambdacontrolActive_1) ? 0.0 : ((Lamsoni__LAMBDACONTROL_IMPL_Lcc_calc &lt; Afr_facLambdaReq__LAMBDACONTROL_IMPL_Lcc_calc) ? -_Lcc_facInitValue : _Lcc_facInitValue))) + INTEGRATOR_IMPL_out(_Integrator_REF_));
   /* Lcc_calc: sequence call #3  */
   INTEGRATOR_IMPL_reset(_Integrator_REF_, _Lcc_IntInitValvue, EDGEFALLING_IMPL_compute(_EdgeFalling_REF_, Lamsoni__LAMBDACONTROL_IMPL_Lcc_calc &lt; Afr_facLambdaReq__LAMBDACONTROL_IMPL_Lcc_calc)
      || EDGERISING_IMPL_compute(_EdgeRising_REF_, Lamsoni__LAMBDACONTROL_IMPL_Lcc_calc &lt; Afr_facLambdaReq__LAMBDACONTROL_IMPL_Lcc_calc));
   /* Lcc_calc: sequence call #4  */
   if (_Lcc_flgLambdacontrolActive_1 &amp;&amp; _Lcc_flgSwitch2PIDController)
   {
      /* If-block: sequence call #4/Then #1  */
      _t1real64
         = (((real64)Epm_rpmEngSpd__LAMBDACONTROL_IMPL_Lcc_calc == 0.0) ? 80.0 : 80.0 / (real64)Epm_rpmEngSpd__LAMBDACONTROL_IMPL_Lcc_calc);
      PID_LIMIT_AWU_IMPL_compute(_PID_Limit_AWU_REF_, ((real64)Lamsoni__LAMBDACONTROL_IMPL_Lcc_calc - (real64)Afr_facLambdaReq__LAMBDACONTROL_IMPL_Lcc_calc) * 0.00048828125, CharTable2_getAt_r64r64r64(_Lcc_facKLambdaCorrPID_MAP_REF_,(real64)Epm_rpmEngSpd__LAMBDACONTROL_IMPL_Lcc_calc * 0.5,(real64)Mpc_pManiFilt__LAMBDACONTROL_IMPL_Lcc_calc * 4.0), CharTable2_getAt_r64r64r64(_Lcc_tiTvLambdaCorrPID_MAP_REF_,(real64)Epm_rpmEngSpd__LAMBDACONTROL_IMPL_Lcc_calc * 0.5,(real64)Mpc_pManiFilt__LAMBDACONTROL_IMPL_Lcc_calc * 4.0), CharTable2_getAt_r64r64r64(_Lcc_tiTnLambdaCorrPID_MAP_REF_,(real64)Epm_rpmEngSpd__LAMBDACONTROL_IMPL_Lcc_calc * 0.5,(real64)Mpc_pManiFilt__LAMBDACONTROL_IMPL_Lcc_calc * 4.0), ((_t1real64 &lt;= 40.0) ? _t1real64 : 40.0), _Lcc_LambdaCorrMaxPID, _Lcc_LambdaCorrMinPID);
   }
   else
   {
      /* If-block: sequence call #4/Else #1  */
      PID_LIMIT_AWU_IMPL_reset(_PID_Limit_AWU_REF_, _Lcc_StartValuePID);
   } /* end if */
   /* Lcc_calc: sequence call #5  */
   _t1real64
      = (((real64)Epm_rpmEngSpd__LAMBDACONTROL_IMPL_Lcc_calc == 0.0) ? 80.0 : 80.0 / (real64)Epm_rpmEngSpd__LAMBDACONTROL_IMPL_Lcc_calc);
   INTEGRATOR_IMPL_compute(_Integrator_REF_, ((!_Lcc_flgLambdacontrolActive_1) ? 0.0 : ((Lamsoni__LAMBDACONTROL_IMPL_Lcc_calc &lt; Afr_facLambdaReq__LAMBDACONTROL_IMPL_Lcc_calc) ? -CharTable1_getAt_r64r64(_Lcc_EngSpd2facIntegrator_CUR_REF_,(real64)Epm_rpmEngSpd__LAMBDACONTROL_IMPL_Lcc_calc * 0.5) : CharTable1_getAt_r64r64(_Lcc_EngSpd2facIntegrator_CUR_REF_,(real64)Epm_rpmEngSpd__LAMBDACONTROL_IMPL_Lcc_calc * 0.5))), _Lcc_flgLambdacontrolActive_1, ((_t1real64 &lt;= 40.0) ? _t1real64 : 40.0), _Lcc_LambdaCorrMaxTPC, _Lcc_LambdaCorrMinTPC);
   /* Lcc_calc: sequence call #6  */
   _t1real64
      = ((!_Lcc_flgLambdacontrolActive_1) ? 2048.0 : (((_Lcc_flgSwitch2PIDController) ? PID_LIMIT_AWU_IMPL_out(_PID_Limit_AWU_REF_) : INTEGRATOR_IMPL_out(_Integrator_REF_))) * 2048.0);
   _t1real64 = ((_t1real64 &lt; 0.0) ? _t1real64 - 0.5 : _t1real64 + 0.5);
   /* assignment to Lcc_facLambdaCorr: min=0, max=4096, hex=2048phys+0, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   Lcc_facLambdaCorr__LAMBDACONTROL_IMPL_Lcc_calc
      = ((_t1real64 >= 0.0) ? ((_t1real64 &lt;= 4096.0) ? (uint16)_t1real64 : 4096U) : 0U);
   /* send messages implicitly */
   {
      Lcc_facLambdaCorr = Lcc_facLambdaCorr__LAMBDACONTROL_IMPL_Lcc_calc;
   }
}
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF PROCESS 'LAMBDACONTROL_IMPL_Lcc_calc'
 ******************************************************************************/
#endif
/* END: ASCET REGION "Process Definition 'Lcc_calc'" */


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
