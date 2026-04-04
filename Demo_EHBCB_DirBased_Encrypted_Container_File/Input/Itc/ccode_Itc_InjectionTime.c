
/* BEGIN: ASCET REGION "Generation Information" */
/******************************************************************************
 * BEGIN: Generation Information
 *-----------------------------------------------------------------------------
 * Component:................Module
 * Name:....................."InjectionTime"
 * Implementation:..........."Impl"
 * Dataset:.................."Data"
 * Specification:............Block Diagram
 * Version:..................<empty String>
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
 * Prefix for Component Names [<empty String>]:......................<empty String>
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
 * Public directive [<empty String>]:................................<empty String>
 *-----------------------------------------------------------------------------
 *    Code.FixedPoint
 *-----------------------------------------------------------------------------
 * Allow Double bit Size for Division Numerators [true]:.............true
 * Allow Limit Service for Assignment Limitation [true]:.............true
 * Arithmetic Service Set [<None>]:..................................<None>
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
 * genDate [<undef>]:................................................<undef>
 * genTime [<undef>]:................................................<undef>
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
 * messageOverloadInitValues [<undef>]:..............................<undef>
 * messageUsageVariant [OPT_COPY]:...................................NON_OPT_COPY
 * modularMessageUse [false]:........................................false
 * osAppModePattern ["%name%"]:......................................"appmode_%name%"
 * osStartupFunction [<undef>]:......................................<undef>
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
 * BEGIN: DEFINITION OF SUBSTRUCT VARIABLE 'Itc_RAM'
 * ----------------------------------------------------------------------------
 * memory class:.................................'RAM'
 * model name:...................................'Itc'
 * data set:.....................................'INJECTIONTIME_IMPL_Data'
 * ---------------------------------------------------------------------------*/
struct INJECTIONTIME_IMPL_RAM_SUBSTRUCT Itc_RAM = {
   /* substruct: Itc_RAM.Hysteresis_Delta_RSP (modeled as:'Hysteresis_Delta_RSP.Itc') */
   {
      /* struct element:'Itc_RAM.Hysteresis_Delta_RSP.hysterese' (modeled as:'hysterese.Hysteresis_Delta_RSP.Itc') */
      false
   }
};
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF SUBSTRUCT VARIABLE 'Itc_RAM'
 ******************************************************************************/

/******************************************************************************
 * BEGIN: DEFINITION OF COMPONENT VARIABLE 'Itc'
 * ----------------------------------------------------------------------------
 * memory class:.................................'ROM'
 * model name:...................................'Itc'
 * data set:.....................................'INJECTIONTIME_IMPL_Data'
 * ---------------------------------------------------------------------------*/
const struct INJECTIONTIME_IMPL Itc = {
   /* substruct: Itc.Hysteresis_Delta_RSP (modeled as:'Hysteresis_Delta_RSP.Itc') */
   {
      /* type descriptor pointer 'HYSTERESIS_DELTA_RSP_IMPL_RAM' for memory class substruct for 'RAM' */
      &Itc_RAM.Hysteresis_Delta_RSP
   }
};
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF COMPONENT VARIABLE 'Itc'
 ******************************************************************************/

/* END: ASCET REGION "Module Data Definitions" */

/* BEGIN: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Itc_flgInjCutoffMan'
 * ---------------------------------------------------------------------------*/
const uint8 Itc_flgInjCutoffMan = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Itc_flgInjCutoffMan'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Itc_flgInjTimeOverride'
 * ---------------------------------------------------------------------------*/
const uint8 Itc_flgInjTimeOverride = false;
   /* min=0, max=1, Identity, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Itc_flgInjTimeOverride'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'Itc_mFuelMass2tiInjBase_CUR'
 * ---------------------------------------------------------------------------*/
const struct CharTable1_uint16_3_uint32_INJECTIONTIME_IMPL_TYPE Itc_mFuelMass2tiInjBase_CUR = {
      3,
      {
         32, 38, 7798
      },
      {
         0, 174, 49174
      }
   };
   /* result: min=0.0, max=3300000.0, ident, limit=no */
   /* x axis: min=0.0, max=9.99984741210938e-1, fac_65536 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'Itc_mFuelMass2tiInjBase_CUR'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Itc_pManiFiltMax'
 * ---------------------------------------------------------------------------*/
const uint32 Itc_pManiFiltMax = 200000U;
   /* min=0.0, max=4294967295.0, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Itc_pManiFiltMax'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Itc_rpmEngSpdHyst'
 * ---------------------------------------------------------------------------*/
const real32 Itc_rpmEngSpdHyst = 150.0F;
   /* min=0.0, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Itc_rpmEngSpdHyst'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Itc_rpmEngSpdMax'
 * ---------------------------------------------------------------------------*/
const real32 Itc_rpmEngSpdMax = 6000.0F;
   /* min=0.0, max=+oo, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Itc_rpmEngSpdMax'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Itc_tiInjCalc'
 * ---------------------------------------------------------------------------*/
uint32 Itc_tiInjCalc = 0;
   /* min=0.0, max=3300000.0, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Itc_tiInjCalc'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Itc_tiInjMan'
 * ---------------------------------------------------------------------------*/
const uint32 Itc_tiInjMan = 0;
   /* min=0.0, max=3300000.0, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Itc_tiInjMan'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Itc_tiInjMin'
 * ---------------------------------------------------------------------------*/
const uint16 Itc_tiInjMin = 1000;
   /* min=0.0, max=65535.0, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Itc_tiInjMin'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF VARIABLE 'Itc_tiInjOffsetMan'
 * ---------------------------------------------------------------------------*/
const sint16 Itc_tiInjOffsetMan = 0;
   /* min=-10000.0, max=10000.0, ident, limit=yes */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF VARIABLE 'Itc_tiInjOffsetMan'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF CHARACTERISTIC TABLE 'Itc_uBatt2tiBattDelay_CUR'
 * ---------------------------------------------------------------------------*/
const struct CharTable1_uint16_17_uint16_INJECTIONTIME_IMPL_TYPE Itc_uBatt2tiBattDelay_CUR = {
      17,
      {
         0, 3338, 6656, 9994, 13332, 16671, 19988, 23327, 26665, 30003, 33321, 36659,
         39997, 43336, 46653, 49992, 53330
      },
      {
         2460, 2460, 2460, 2460, 2220, 1100, 620, 380, 100, 0, 0, 0, 0, 0, 0, 0, 0
      }
   };
   /* result: min=0.0, max=26214.0, ident, limit=yes */
   /* x axis: min=0.0, max=31.99951171875, fac_2048 */
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF CHARACTERISTIC TABLE 'Itc_uBatt2tiBattDelay_CUR'
 ******************************************************************************/

/* END: ASCET REGION "Exported Data Definitions" */

/******************************************************************************
 * BEGIN: DEFINITION OF MESSAGES
 * ----------------------------------------------------------------------------
 * Total size is [bytes]:........................9
 * ---------------------------------------------------------------------------*/
/* messages of memory class:............................................'RAM' */
/* messages of size [bytes]:................................................4 */
/* modelled as 'Itc_tiInj' */
uint32 Itc_tiInj;
/* messages of size [bytes]:................................................2 */
/* modelled as 'Itc_tiBattDelay' */
uint16 Itc_tiBattDelay;
/* modelled as 'Itc_tiInjOffset' */
sint16 Itc_tiInjOffset;
/* messages of size [bytes]:................................................1 */
/* modelled as 'Itc_flgInjCutoff' */
uint8 Itc_flgInjCutoff;
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF MESSAGES
 ******************************************************************************/

#define _Hysteresis_Delta_RSP Itc.Hysteresis_Delta_RSP
#define _Hysteresis_Delta_RSP_REF_ (&(Itc.Hysteresis_Delta_RSP))
#define _Itc_flgInjCutoffMan Itc_flgInjCutoffMan
#define _Itc_flgInjTimeOverride Itc_flgInjTimeOverride
#define _Itc_mFuelMass2tiInjBase_CUR Itc_mFuelMass2tiInjBase_CUR
#define _Itc_mFuelMass2tiInjBase_CUR_REF_ (&(Itc_mFuelMass2tiInjBase_CUR))
#define _Itc_pManiFiltMax Itc_pManiFiltMax
#define _Itc_rpmEngSpdHyst Itc_rpmEngSpdHyst
#define _Itc_rpmEngSpdMax Itc_rpmEngSpdMax
#define _Itc_tiInjCalc Itc_tiInjCalc
#define _Itc_tiInjMan Itc_tiInjMan
#define _Itc_tiInjMin Itc_tiInjMin
#define _Itc_tiInjOffsetMan Itc_tiInjOffsetMan
#define _Itc_uBatt2tiBattDelay_CUR Itc_uBatt2tiBattDelay_CUR
#define _Itc_uBatt2tiBattDelay_CUR_REF_ (&(Itc_uBatt2tiBattDelay_CUR))

/* BEGIN: ASCET REGION "Component Functions" */
/******************************************************************************
 * BEGIN: FUNCTIONS OF COMPONENT
 ******************************************************************************/

/* BEGIN: ASCET REGION "Process Definition 'Itc_calc'" */
/******************************************************************************
 * BEGIN: DEFINITION OF PROCESS 'INJECTIONTIME_IMPL_Itc_calc'
 * ----------------------------------------------------------------------------
 * model name:...................................'Itc_calc'
 * memory class:.................................'CODE'
 * ---------------------------------------------------------------------------*/
//#if defined(COMPILE_UNUSED_CODE) || defined(COMPILE_UNUSED__INJECTIONTIME_IMPL_Itc_calc)
/* messages used by this process */

/* public Itc_calc []  */

void INJECTIONTIME_IMPL_Itc_calc (void)
{
   /* temp. variables */
   uint32 _t1uint32;
   sint32 _t1sint32;

   /* define local message copies */
   uint16 Bvc_uBatt__INJECTIONTIME_IMPL_Itc_calc;
   sint16 Epm_rpmEngSpd__INJECTIONTIME_IMPL_Itc_calc;
   uint16 Fmc_mFuel__INJECTIONTIME_IMPL_Itc_calc;
   uint8 Iac_flgIgnCutoff__INJECTIONTIME_IMPL_Itc_calc;
   uint8 Isc_flgFuelCutoff__INJECTIONTIME_IMPL_Itc_calc;
   uint8 Itc_flgInjCutoff__INJECTIONTIME_IMPL_Itc_calc;
   uint16 Itc_tiBattDelay__INJECTIONTIME_IMPL_Itc_calc;
   uint32 Itc_tiInj__INJECTIONTIME_IMPL_Itc_calc;
   sint16 Itc_tiInjOffset__INJECTIONTIME_IMPL_Itc_calc;
   uint16 Mpc_pManiFilt__INJECTIONTIME_IMPL_Itc_calc;
   uint16 Stc_facFuelCorr__INJECTIONTIME_IMPL_Itc_calc;
   /* receive messages implicitly */
   {
      DisableAllInterrupts();
      Bvc_uBatt__INJECTIONTIME_IMPL_Itc_calc = Bvc_uBatt;
      Epm_rpmEngSpd__INJECTIONTIME_IMPL_Itc_calc = Epm_rpmEngSpd;
      Fmc_mFuel__INJECTIONTIME_IMPL_Itc_calc = Fmc_mFuel;
      Iac_flgIgnCutoff__INJECTIONTIME_IMPL_Itc_calc = Iac_flgIgnCutoff;
      Isc_flgFuelCutoff__INJECTIONTIME_IMPL_Itc_calc = Isc_flgFuelCutoff;
      Itc_flgInjCutoff__INJECTIONTIME_IMPL_Itc_calc = Itc_flgInjCutoff;
      Itc_tiBattDelay__INJECTIONTIME_IMPL_Itc_calc = Itc_tiBattDelay;
      Itc_tiInj__INJECTIONTIME_IMPL_Itc_calc = Itc_tiInj;
      Itc_tiInjOffset__INJECTIONTIME_IMPL_Itc_calc = Itc_tiInjOffset;
      Mpc_pManiFilt__INJECTIONTIME_IMPL_Itc_calc = Mpc_pManiFilt;
      Stc_facFuelCorr__INJECTIONTIME_IMPL_Itc_calc = Stc_facFuelCorr;
      EnableAllInterrupts();
   }
   /* Itc_calc: sequence call #1  */
   /* assignment to Itc_tiInjCalc: min=0, max=3300000, hex=phys, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   _Itc_tiInjCalc
      = CharTable1_getAt_u16u32(_Itc_mFuelMass2tiInjBase_CUR_REF_,Fmc_mFuel__INJECTIONTIME_IMPL_Itc_calc);
   /* Itc_calc: sequence call #2  */
   _t1sint32
      = ((_Itc_flgInjTimeOverride) ? (sint32)_Itc_tiInjMan : (_t1uint32
      = (_Itc_tiInjCalc >> 3) * Stc_facFuelCorr__INJECTIONTIME_IMPL_Itc_calc / 125U ,  (sint32)_t1uint32 + _Itc_tiInjOffsetMan));
   /* assignment to Itc_tiInj: min=0, max=3300000, hex=phys, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   Itc_tiInj__INJECTIONTIME_IMPL_Itc_calc
      = ((_t1sint32 >= 0) ? (((uint32)_t1sint32 <= 3300000U) ? (uint32)_t1sint32 : 3300000U) : 0U);
   /* Itc_calc: sequence call #3  */
   Itc_flgInjCutoff__INJECTIONTIME_IMPL_Itc_calc
      = (((_Itc_flgInjTimeOverride) ? (sint32)_Itc_tiInjMan : (_t1uint32
      = (_Itc_tiInjCalc >> 3) * Stc_facFuelCorr__INJECTIONTIME_IMPL_Itc_calc / 125U ,  (sint32)_t1uint32 + _Itc_tiInjOffsetMan))) < (sint32)_Itc_tiInjMin || Epm_rpmEngSpd__INJECTIONTIME_IMPL_Itc_calc < 60
      || HYSTERESIS_DELTA_RSP_IMPL_out(_Hysteresis_Delta_RSP_REF_, (real64)Epm_rpmEngSpd__INJECTIONTIME_IMPL_Itc_calc * 0.5, (real64)_Itc_rpmEngSpdHyst, (real64)_Itc_rpmEngSpdMax)
      || (uint32)Mpc_pManiFilt__INJECTIONTIME_IMPL_Itc_calc << 2 > _Itc_pManiFiltMax || Iac_flgIgnCutoff__INJECTIONTIME_IMPL_Itc_calc || _Itc_flgInjCutoffMan || Isc_flgFuelCutoff__INJECTIONTIME_IMPL_Itc_calc;
   /* Itc_calc: sequence call #4  */
   /* assignment to Itc_tiBattDelay: min=0, max=26214, hex=phys, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   Itc_tiBattDelay__INJECTIONTIME_IMPL_Itc_calc
      = CharTable1_getAt_u16u16(_Itc_uBatt2tiBattDelay_CUR_REF_,Bvc_uBatt__INJECTIONTIME_IMPL_Itc_calc);
   /* Itc_calc: sequence call #5  */
   /* assignment to Itc_tiInjOffset: min=-10000, max=10000, hex=phys, limit=(maxBitLength: true, assign: true), zero incl.=true  */
   Itc_tiInjOffset__INJECTIONTIME_IMPL_Itc_calc = _Itc_tiInjOffsetMan;
   /* send messages implicitly */
   {
      DisableAllInterrupts();
      Itc_flgInjCutoff = Itc_flgInjCutoff__INJECTIONTIME_IMPL_Itc_calc;
      Itc_tiBattDelay = Itc_tiBattDelay__INJECTIONTIME_IMPL_Itc_calc;
      Itc_tiInj = Itc_tiInj__INJECTIONTIME_IMPL_Itc_calc;
      Itc_tiInjOffset = Itc_tiInjOffset__INJECTIONTIME_IMPL_Itc_calc;
      EnableAllInterrupts();
   }
}
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF PROCESS 'INJECTIONTIME_IMPL_Itc_calc'
 ******************************************************************************/
#endif
/* END: ASCET REGION "Process Definition 'Itc_calc'" */


/* ****************************************************************************
 * END: FUNCTIONS OF COMPONENT
 ******************************************************************************/
/* END: ASCET REGION "Component Functions" */

