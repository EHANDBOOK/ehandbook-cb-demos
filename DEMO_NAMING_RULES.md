# Naming Rules for Demo Directories

This document defines the new naming convention for demo directories in the EHANDBOOK Container-Build repository. The goal is to make demo directory names self-explanatory, consistent, and easy to search and categorize.

## Naming Pattern

```plain
Demo_[EHBCB|EHBCB_AddOn]_[DirBased|ASAMBased]_[ASCET|SL|CCODE|ASCET_SL_CCODE|...]_[FeatureOrAspect]
```

- `Demo_`: All demo folders start with this prefix.
- `EHBCB` or `EHBCB_AddOn`: Indicates if it’s a standard EHB-CB demo or one using an add-on.
- For add-ons: `ASCET` or `SL` specifies the add-on type.
- For EHBCB: `DirBased` or `ASAMBased` specifies the build system.
- Model language: `ASCET`, `SL` (Simulink), `CCODE`, or combinations (e.g., `ASCET_SL_CCODE`).
- `FeatureOrAspect`: A short description of the specific feature, workflow, or integration demonstrated (e.g., `custom_tocs`, `language_support`, `FlexECU`, `PDF`, `ViewConcept`, etc.).

## Mapping Table: Existing vs. New Directory Names

| Existing Directory Name | New Directory Name (Naming Rules) |
|------------------------|------------------------------------|
| Demo_ASAMBased_ASCET_PDF_FlexECU | Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU |
| Demo_ASAM_SL_simple | Demo_EHBCB_ASAMBased_SL_simple |
| Demo_Ascet_AddOn_Toolbox | Demo_EHBCB_AddOn_ASCET_Toolbox |
| Demo_AsciiDoc | Demo_EHBCB_DirBased_AsciiDoc |
| Demo_AUTOSAR_MATLAB | Demo_EHBCB_DirBased_AUTOSAR_MATLAB |
| Demo_AUTOSAR_Signal_Mapping | Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping |
| Demo_DirBased_ASCET_SL_CCode | Demo_EHBCB_DirBased_ASCET_SL_CCODE |
| Demo_DirBased_CCode_references | Demo_EHBCB_DirBased_CCODE_references |
| Demo_DirBased_CCode_simple | Demo_EHBCB_DirBased_CCODE_simple |
| Demo_DirBased_custom_tocs | Demo_EHBCB_DirBased_custom_tocs |
| Demo_DirBased_language_support | Demo_EHBCB_DirBased_language_support |
| Demo_DirBased_m-script | Demo_EHBCB_DirBased_SL_mscript |
| Demo_DirBased_m-script_DocBlocks_to_AsciiDoc | Demo_EHBCB_DirBased_SL_mscript_DocBlocks_to_AsciiDoc |
| Demo_DirBased_mixed_models | Demo_EHBCB_DirBased_ASCET_SL_CCODE_mixed |
| Demo_DirBased_Nested_TOC | Demo_EHBCB_DirBased_Nested_TOC |
| Demo_DirBased_SL_AsciiDoc_Japanese | Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese |
| Demo_DirBased_SL_enhanced | Demo_EHBCB_DirBased_SL_enhanced |
| Demo_DirBased_SL_FlexECU | Demo_EHBCB_DirBased_SL_FlexECU |
| Demo_DirBased_SL_Libraries | Demo_EHBCB_DirBased_SL_Libraries |
| Demo_DirBased_SL_referencedModels | Demo_EHBCB_DirBased_SL_referencedModels |
| Demo_DirBased_SL_ViewConcept | Demo_EHBCB_DirBased_SL_ViewConcept |
| Demo_DirBased_TargetLink_Library | Demo_EHBCB_DirBased_SL_TargetLink_Library |
| Demo_EHB_CB_AddOn_for_MATLAB_Simulink | Demo_EHBCB_AddOn_SL |
| Demo_PDF | Demo_EHBCB_DirBased_PDF |
| Demo_UGG_iCB | Demo_EHBCB_DirBased_UGG_iCB |
| Demos_AUTOSAR_Classic/ASAM_Based_EHBCB | Demo_EHBCB_ASAMBased_AUTOSAR |
| Demos_AUTOSAR_Classic/ASAM_Based_EHBCB_Simulink | Demo_EHBCB_ASAMBased_SL |
| Demos_AUTOSAR_Classic/Dir_Based_EHBCB | Demo_EHBCB_DirBased_AUTOSAR |
| Demos_AUTOSAR_Classic/Dir_Based_EHBCB_CCode | Demo_EHBCB_DirBased_AUTOSAR_CCODE |
| Demos_AUTOSAR_Classic/Dir_Based_EHBCB_CCode_Config_for_AUTOSAR | Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config |
| Demos_AUTOSAR_Classic/Dir_Based_EHBCB_excerpt | Demo_EHBCB_DirBased_AUTOSAR_excerpt |
| Demos_AUTOSAR_Classic/Dir_Based_EHBCB_excerpt_AR_only | Demo_EHBCB_DirBased_AUTOSAR_excerpt_AR_only |
| Demos_AUTOSAR_Classic/Dir_Based_EHBCB_FlexECU_AUTOSAR_only_Demo | Demo_EHBCB_DirBased_AUTOSAR_FlexECU_only |
| Demos_AUTOSAR_Classic/Dir_Based_EHBCB_RTA_RTE_AUTOSAR_only_Demo | Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_only |
| Demos_AUTOSAR_Classic/Dir_Based_EHBCB_Simulink_Example | Demo_EHBCB_DirBased_AUTOSAR_SL |

> Note: The new names are suggestions based on the rules and may be further refined for clarity or brevity.
