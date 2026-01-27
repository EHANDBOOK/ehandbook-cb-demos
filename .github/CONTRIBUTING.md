# Contributing to EHANDBOOK Container-Build Demos

Thank you for your interest in contributing to this repository! This guide will help you understand how to add new demos or modify existing ones.

## Table of Contents

- [Demo Naming Conventions](#demo-naming-conventions)
- [Creating a New Demo](#creating-a-new-demo)
- [Demo Structure](#demo-structure)
- [Getting Help](#getting-help)

## Demo Naming Conventions

This repository follows a consistent naming convention for demo directories to make them self-explanatory, searchable, and easy to categorize.

### Naming Pattern

```plain
Demo_[EHBCB|EHBCB_AddOn]_[DirBased|ASAMBased]_[ASCET|SL|CCODE|ASCET_SL_CCODE|...]_[FeatureOrAspect]
```

**Pattern Components:**

- `Demo_`: All demo folders start with this prefix.
- `EHBCB` or `EHBCB_AddOn`: Indicates if it's a standard EHB-CB demo or one using an add-on.
  - For add-ons: `ASCET` or `SL` specifies the add-on type.
- `DirBased` or `ASAMBased`: Specifies the build system (only for standard EHBCB demos).
- Model language: `ASCET`, `SL` (Simulink), `CCODE`, or combinations (e.g., `ASCET_SL_CCODE`).
- `FeatureOrAspect`: A short description of the specific feature, workflow, or integration demonstrated (e.g., `CustomTocs`, `LanguageSupport`, `FlexECU`, `PDF`, `ViewConcept`, etc.).

### Naming Rules

- **PascalCase**: Use PascalCase for all words in the directory name.
  - Example: `DirBased`, `FlexECU`, `ViewConcept`.
- **ALLCAPS for Abbreviations**: Use ALLCAPS for abbreviations.
  - Example: `EHBCB`, `CCODE`, `PDF`, `AUTOSAR`.

### Examples

- `Demo_EHBCB_DirBased_CCODE_Simple` – Directory-based demo with simple C-code.
- `Demo_EHBCB_ASAMBased_AUTOSAR` – ASAM-based demo with AUTOSAR.
- `Demo_EHBCB_DirBased_SL_ViewConcept` – Directory-based Simulink demo showcasing the View Concept.
- `Demo_EHBCB_AddOn_SL_Toolbox` – Add-on demo for Simulink Toolbox.

## Creating a New Demo

### Step 1: Plan Your Demo

Before creating the directory, decide:

1. **Type**: Is this a Directory-Based or ASAM-Based demo?
2. **Technologies**: Which source formats does it use (Simulink, C-code, AUTOSAR, ASCET, etc.)?
3. **Feature Focus**: What specific feature(s) does it demonstrate?
4. **Audience Level**: Is it Beginner, Intermediate, or Advanced?

### Step 2: Create the Demo Directory

Using the naming convention above, create a new folder in the repository root.

Example:

```bash
mkdir Demo_EHBCB_DirBased_MyFeature
```

### Step 3: Create the README.md

Use the [demo template](../docs/demo-template.md) as your guide. Copy it into your demo folder as `README.md` and fill in all sections. The README should explain:

- What the demo illustrates
- Key features showcased
- How to run the demo
- Directory and file structure
- Configuration deep dive

### Step 4: Add Input Files

Create an `Input/` folder containing all source files and configurations needed for the build.

### Step 5: Add the Build Script

Create a `build.bat` script (or `.ps1` for PowerShell) that invokes EHANDBOOK Container-Build on your input files.

### Step 6: Build and Verify

1. Run the `build.bat` script locally to ensure it works.
2. Verify the output is generated in the `Output/` folder.
3. Test the generated EHANDBOOK Container with EHANDBOOK-NAVIGATOR.

### Step 7: Commit and Push

Add your new demo to the repository:

```bash
git add Demo_EHBCB_DirBased_MyFeature/
git commit -m "Add Demo_EHBCB_DirBased_MyFeature demo"
git push
```

Don't forget to update the main [README.md](../README.md) with your new demo in the demo table.

## Demo Structure

Each demo folder should follow this structure:

```plain
Demo_EHBCB_[Type]_[Technologies]_[Feature]/
├── README.md                    # Demo documentation (use template)
├── build.bat                    # Windows batch build script
├── build.ps1                    # PowerShell build script (optional)
├── Input/                       # Source files and configurations
│   ├── [source files]
│   ├── config.json              # Main EHB-CB configuration
│   └── [other configs as needed]
├── Output/                      # Generated output (created after build)
│   └── [demo_name].ehb          # Pre-built EHANDBOOK Container
└── [optional: additional folders for styling, includes, etc.]
```

### Input Folder Guidelines

- Place all source files (C-code, Simulink models, ARXML, etc.) here.
- Include all configuration files (JSON, YAML, XML).
- Organize files logically to reflect the documentation structure.
- Keep file sizes reasonable; avoid extremely large models or datasets.

### Output Folder Guidelines

- Include a pre-built `.ehb` file so users can explore the demo without building.
- Optionally include a PDF if the demo demonstrates PDF generation.
- Create this folder by running the `build.bat` script.

## Getting Help

If you have questions:

1. Check the [EHANDBOOK Container-Build documentation](https://docs.etas.com/ehandbook/ehandbook/container_build.html).
2. Review similar existing demos for reference.
3. Consult the [main README](../README.md) for overview information.

Thank you for contributing!
