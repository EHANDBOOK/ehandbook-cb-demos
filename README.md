# EHANDBOOK Container-Build Demos

This repository contains a comprehensive set of demos showcasing the capabilities of EHANDBOOK Container-Build (EHB-CB), a tool for automatically generating technical documentation from various source formats including Simulink models, C-Code, AUTOSAR specifications, and more.

Additional information on EHANDBOOK Container-Build can be found in the comprehensive documentation at <https://docs.etas.com/ehandbook/ehandbook/container_build.html>.

## Table of Contents

- [What You'll Need](#what-youll-need)
- [Getting Started](#getting-started)
  - [Clone Repository](#clone-repository)
  - [Setup](#setup)
- [How to Run a Demo](#how-to-run-a-demo)
- [Repository Structure](#repository-structure)
- [AI-Generated Code Notice](#ai-generated-code-notice)

## What You'll Need

Before you begin, ensure you have:

- ✅ **EHANDBOOK Container-Build tools** (latest version recommended)
- ✅ **EHANDBOOK-UGG tools** (if running UGG demos)
- ✅ **MATLAB/Simulink** (R2021a or later, required for Simulink demos)
- ✅ **Docker** (for running the containerized build environment)
- ✅ **Git** (for cloning the repository)
- ⏱️ **Estimated setup time:** 15-20 minutes

## Getting Started

### Clone Repository

A guide on how to setup SSH for cloning the repository can be found here: <https://confluence.etas-dev.com/display/ETASDEVU/SSH+Git+Access+to+Bitbucket#SSHGitAccesstoBitbucket-Createpublicandprivatekeypair>.

### Setup

After cloning the repository, you first should adapt the file `set_tool_paths.bat` to match your local environment.

**Example configuration:**

```batch
set EHB_CB_PATH=C:\ETAS\EHANDBOOK-Container-Build_10.0.0-Windows
set EHB_UGG_PATH=C:\ETAS\EHANDBOOK-UGG_10.0.0-Windows
set MATLAB_PATH=C:\Program Files\MATLAB\R2021a
```

**To configure:**

1. Open `set_tool_paths.bat` in a text editor
2. Update `EHB_CB_PATH` to point to your EHANDBOOK Container-Build installation directory
3. Update `EHB_UGG_PATH` to point to your EHANDBOOK-UGG installation directory (if applicable)
4. Update `MATLAB_PATH` to point to your MATLAB installation directory (if running Simulink demos)
5. Save the file

## How to Run a Demo

Each demo folder contains a batch file `build.bat` which invokes the EHANDBOOK Container-Build tool(s) on the given input data.

**Steps to run any demo:**

1. Open a command prompt or PowerShell terminal
2. Navigate to the demo folder (e.g., `cd Demo_DirBased_CCode_simple`)
3. Execute the build script: `build.bat`
4. Wait for the build to complete
5. Find the generated output in the `Output/` folder within the demo directory

**Expected output:** The build generates an EHANDBOOK Container file and - where configured - a corresponding PDF document.

## Demo Index

This repository is organized into demo folders, each showcasing specific features or use cases.

| Demo | Technology/Use Case | Complexity | Description |
| :--- | :--- | :--- | :--- |
| [Demo_ASAM_SL_simple](./Demo_ASAM_SL_simple/README.md) | `ASAM`, `Simulink` | Beginner | Illustrates a simple ASAM-based build for a single Simulink function. |
| [Demo_ASAMBased_ASET_PDF_FlexECU](./Demo_ASAMBased_ASET_PDF_FlexECU/README.md) | `ASAM`, `ASET`, `PDF`, `FlexECU` | Advanced | Shows an ASAM-based build with ASET, PDF output, and FlexECU integration. |
| [Demo_Ascet_AddOn_Toolbox](./Demo_Ascet_AddOn_Toolbox/README.md) | `ASCET` | Intermediate | Demonstrates the use of the ASCET Add-On Toolbox. |
| [Demo_AsciiDoc](./Demo_AsciiDoc/README.md) | `AsciiDoc` | Beginner | Shows how to generate documentation from AsciiDoc source files. |
| [Demo_AUTOSAR_MATLAB](./Demo_AUTOSAR_MATLAB/README.md) | `AUTOSAR`, `MATLAB` | Intermediate | Covers generating documentation for AUTOSAR components using MATLAB. |
| [Demo_AUTOSAR_Signal_Mapping](./Demo_AUTOSAR_Signal_Mapping/README.md) | `AUTOSAR` | Intermediate | Focuses on signal mapping within an AUTOSAR project. |
| [Demos_AUTOSAR_Classic](./Demos_AUTOSAR_Classic/README.md) | `AUTOSAR` | Advanced | Provides a set of demos for the AUTOSAR Classic platform. |
| [Demo_DirBased_ASCET_SL_CCode](./Demo_DirBased_ASCET_SL_CCode/README.md) | `ASCET`, `Simulink`, `C-Code` | Advanced | A complex demo mixing ASCET, Simulink, and C-Code in a directory-based structure. |
| [Demo_DirBased_CCode_simple](./Demo_DirBased_CCode_simple/README.md) | `C-Code` | Beginner | A fundamental example of documenting a simple C-code project. |
| [Demo_DirBased_CCode_references](./Demo_DirBased_CCode_references/README.md) | `C-Code` | Intermediate | Demonstrates handling of code hierarchies and references in a C-Code project. |
| [Demo_DirBased_custom_tocs](./Demo_DirBased_custom_tocs/README.md) | `Customization` | Intermediate | Shows how to create custom table of contents structures. |
| [Demo_DirBased_language_support](./Demo_DirBased_language_support/README.md) | `Customization`, `Localization` | Intermediate | Illustrates support for multiple languages in the output. |
| [Demo_DirBased_m-script](./Demo_DirBased_m-script/README.md) | `MATLAB`, `M-Script` | Intermediate | Shows how to process MATLAB m-scripts to generate documentation. |
| [Demo_DirBased_m-script_DocBlocks_to_AsciiDoc](./Demo_DirBased_m-script_DocBlocks_to_AsciiDoc/README.md) | `MATLAB`, `AsciiDoc` | Advanced | Converts documentation blocks from m-scripts into AsciiDoc format. |
| [Demo_DirBased_mixed_models](./Demo_DirBased_mixed_models/README.md) | `Simulink`, `C-Code` | Intermediate | A demo showcasing a mix of different model and code types. |
| [Demo_DirBased_Nested_TOC](./Demo_DirBased_Nested_TOC/README.md) | `Customization` | Intermediate | Focuses on creating a table of contents with multiple nested levels. |
| [Demo_DirBased_SL_AsciiDoc_Japanese](./Demo_DirBased_SL_AsciiDoc_Japanese/README.md) | `Simulink`, `AsciiDoc`, `Localization` | Advanced | A Simulink demo featuring AsciiDoc and Japanese language support. |
| [Demo_DirBased_SL_enhanced](./Demo_DirBased_SL_enhanced/README.md) | `Simulink` | Intermediate | Showcases enhanced features for Simulink model documentation. |
| [Demo_DirBased_SL_FlexECU](./Demo_DirBased_SL_FlexECU/README.md) | `Simulink`, `FlexECU` | Intermediate | A Simulink-based demo with FlexECU integration. |
| [Demo_DirBased_SL_Libraries](./Demo_DirBased_SL_Libraries/README.md) | `Simulink` | Intermediate | Demonstrates the handling and documentation of Simulink libraries. |
| [Demo_DirBased_SL_referencedModels](./Demo_DirBased_SL_referencedModels/README.md) | `Simulink` | Intermediate | Shows how to handle Simulink projects containing referenced models. |
| [Demo_DirBased_SL_ViewConcept](./Demo_DirBased_SL_ViewConcept/README.md) | `Simulink` | Advanced | Illustrates the "View Concept" for structuring Simulink documentation. |
| [Demo_DirBased_TargetLink_Library](./Demo_DirBased_TargetLink_Library/README.md) | `TargetLink`, `Simulink` | Advanced | A demo for documenting TargetLink libraries. |
| [Demo_EHB_CB_AddOn_for_MATLAB_Simulink](./Demo_EHB_CB_AddOn_for_MATLAB_Simulink/README.md) | `Simulink`, `MATLAB` | Intermediate | Demonstrates the EHANDBOOK Add-On for MATLAB/Simulink. |
| [Demo_PDF](./Demo_PDF/README.md) | `PDF`, `Customization` | Intermediate | Focuses on features and configurations for PDF output generation. |
| [Demo_UGG_iCB](./Demo_UGG_iCB/README.md) | `UGG` | Intermediate | Shows the integration of the Universal Generic Generator (UGG). |

## AI-generated code notice

Use of generative AI in this repository:

The repository partially contains AI-generated code by using GitHub Copilot Business.

This notice needs to remain attached to any reproduction of this repository.
