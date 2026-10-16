/* BEGIN: ASCET REGION "Type Definitions" */
/* definition of characteristic table type: 'CharTable1_uint16_17_uint16_INJECTIONTIME_IMPL_TYPE' */
struct CharTable1_uint16_17_uint16_INJECTIONTIME_IMPL_TYPE {
   uint16 xSize;
   uint16 xDist [17];
   uint16 values [17];
};
   /* result: min=0.0, max=26214.0, ident, limit=yes */
   /* x axis: min=0.0, max=31.99951171875, fac_2048 */

/* definition of characteristic table type: 'CharTable1_uint16_3_uint32_INJECTIONTIME_IMPL_TYPE' */
struct CharTable1_uint16_3_uint32_INJECTIONTIME_IMPL_TYPE {
   uint16 xSize;
   uint16 xDist [3];
   uint32 values [3];
};
   /* result: min=0.0, max=3300000.0, ident, limit=no */
   /* x axis: min=0.0, max=9.99984741210938e-1, fac_65536 */


/******************************************************************************
 * BEGIN: DEFINITION OF MEMORY CLASS STRUCTURE FOR MODULE 'INJECTIONTIME_IMPL'
 * ----------------------------------------------------------------------------
 * memory class:.................................'RAM'
 * ---------------------------------------------------------------------------*/
struct INJECTIONTIME_IMPL_RAM_SUBSTRUCT {
   struct HYSTERESIS_DELTA_RSP_IMPL_RAM_SUBSTRUCT Hysteresis_Delta_RSP;
};
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF MEMORY CLASS STRUCTURE FOR MODULE 'INJECTIONTIME_IMPL'
 ******************************************************************************/


/******************************************************************************
 * BEGIN: DEFINITION OF MAIN STRUCTURE FOR MODULE 'INJECTIONTIME_IMPL'
 * ----------------------------------------------------------------------------
 * memory class:.................................'ROM'
 * ---------------------------------------------------------------------------*/
struct INJECTIONTIME_IMPL {
   struct HYSTERESIS_DELTA_RSP_IMPL Hysteresis_Delta_RSP;
};
/* ----------------------------------------------------------------------------
 * END: DEFINITION OF MAIN STRUCTURE FOR MODULE 'INJECTIONTIME_IMPL'
 ******************************************************************************/

/* Following DEFINE signalizes the completion of definition                   */
/* of data structs for component: .........................INJECTIONTIME_IMPL */
#define _INJECTIONTIME_IMPL_TYPE_DEF_
/* END: ASCET REGION "Type Definitions" */

/* BEGIN: ASCET REGION "Declarations" */

/* forward declaration of substruct variable 'Itc_RAM' */
/* containing 'RAM' memory class tree */
extern struct INJECTIONTIME_IMPL_RAM_SUBSTRUCT Itc_RAM;

/* forward declaration of component variable 'Itc' */
/* containing 'ROM' memory class tree */
extern const struct INJECTIONTIME_IMPL Itc;
/******************************************************************************
 * BEGIN: declaration of global C variables exported by module INJECTIONTIME_IMPL
 ******************************************************************************/
extern const uint8 Itc_flgInjCutoffMan;
   /* min=0, max=1, Identity, limit=yes */
extern const uint8 Itc_flgInjTimeOverride;
   /* min=0, max=1, Identity, limit=yes */
extern const struct CharTable1_uint16_3_uint32_INJECTIONTIME_IMPL_TYPE Itc_mFuelMass2tiInjBase_CUR;
   /* result: min=0.0, max=3300000.0, ident, limit=no */
   /* x axis: min=0.0, max=9.99984741210938e-1, fac_65536 */
extern const uint32 Itc_pManiFiltMax;
   /* min=0.0, max=4294967295.0, ident, limit=yes */
extern const real32 Itc_rpmEngSpdHyst;
   /* min=0.0, max=+oo, ident, limit=yes */
extern const real32 Itc_rpmEngSpdMax;
   /* min=0.0, max=+oo, ident, limit=yes */
extern uint32 Itc_tiInjCalc;
   /* min=0.0, max=3300000.0, ident, limit=yes */
extern const uint32 Itc_tiInjMan;
   /* min=0.0, max=3300000.0, ident, limit=yes */
extern const uint16 Itc_tiInjMin;
   /* min=0.0, max=65535.0, ident, limit=yes */
extern const sint16 Itc_tiInjOffsetMan;
   /* min=-10000.0, max=10000.0, ident, limit=yes */
extern const struct CharTable1_uint16_17_uint16_INJECTIONTIME_IMPL_TYPE Itc_uBatt2tiBattDelay_CUR;
   /* result: min=0.0, max=26214.0, ident, limit=yes */
   /* x axis: min=0.0, max=31.99951171875, fac_2048 */


/* declaration of messages */
extern uint8 Itc_flgInjCutoff;
   /* min=0, max=1, Identity, limit=yes */
extern uint16 Itc_tiBattDelay;
   /* min=0.0, max=26214.0, ident, limit=yes */
extern uint32 Itc_tiInj;
   /* min=0.0, max=3300000.0, ident, limit=yes */
extern sint16 Itc_tiInjOffset;
   /* min=-10000.0, max=10000.0, ident, limit=yes */

/******************************************************************************
 * BEGIN: declaration of global C functions defined by module INJECTIONTIME_IMPL
 ******************************************************************************/
#if defined(COMPILE_UNUSED_CODE) || defined(COMPILE_UNUSED__INJECTIONTIME_IMPL_Itc_calc)
extern void INJECTIONTIME_IMPL_Itc_calc (void);
#endif


/* END: ASCET REGION "Declarations" */
