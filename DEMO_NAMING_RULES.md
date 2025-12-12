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

## Additional Naming Rules

- **PascalCase**: Use PascalCase for all words in the directory name.
  - Example: `DirBased`, `FlexECU`, `ViewConcept`.
- **ALLCAPS for Abbreviations**: Use ALLCAPS for abbreviations.
  - Example: `EHBCB`, `CCODE`, `PDF`.

These rules ensure clarity and consistency across all demo directory names.
