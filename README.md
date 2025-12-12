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

| Demo | Technology/Use Case | Skill Level | Build System | Feature/Aspect | Description |
| :--- | :--- | :--- | :--- | :--- | :--- |
| [Demo_EHBCB_AddOn_ASCET_Toolbox](./Demo_EHBCB_AddOn_ASCET_Toolbox/) | `ASCET` | Intermediate | Add-On | Toolbox | Placeholder: No README.md available. |
| [Demo_EHBCB_AddOn_SL_Toolbox](./Demo_EHBCB_AddOn_SL_Toolbox/) | `Simulink` | Intermediate | Add-On | Toolbox | Placeholder: No README.md available. |
| [Demo_EHBCB_ASAMBased_SL_Simple](./Demo_EHBCB_ASAMBased_SL_Simple/README.md) | `ASAM`, `Simulink` | Beginner | ASAM-Based | Single Function | Demonstrates generating an EHANDBOOK container using ASAM-based input formats for a single Simulink-based ECU function. |
| [Demo_DirBased_CCode_simple](./Demo_DirBased_CCode_simple/README.md) | `C-Code` | Beginner | Directory-Based | Simple Example | A fundamental example of documenting a simple C-code project. |
| [Demo_EHBCB_DirBased_AsciiDoc](./Demo_EHBCB_DirBased_AsciiDoc/README.md) | `AsciiDoc` | Beginner | Directory-Based | Documentation | Showcases generating an EHANDBOOK container from textual content written in AsciiDoc format. |
| [Demo_DirBased_CCode_references](./Demo_DirBased_CCode_references/README.md) | `C-Code` | Intermediate | Directory-Based | Code Hierarchies | Demonstrates handling of code hierarchies and references in a C-Code project. |
| [Demo_DirBased_custom_tocs](./Demo_DirBased_custom_tocs/README.md) | `Customization` | Intermediate | Directory-Based | Custom TOCs | Shows how to create custom table of contents structures. |
| [Demo_DirBased_language_support](./Demo_DirBased_language_support/README.md) | `Customization`, `Localization` | Intermediate | Directory-Based | Multi-Language Support | Illustrates support for multiple languages in the output. |
| [Demo_EHBCB_DirBased_PDF](./Demo_EHBCB_DirBased_PDF/README.md) | `PDF`, `AsciiDoc` | Intermediate | Directory-Based | PDF Embedding | Embeds content from external PDF documents into an EHANDBOOK container by converting PDF pages into SVG images. |
| [Demo_EHBCB_DirBased_SL_Mscript](./Demo_EHBCB_DirBased_SL_Mscript/README.md) | `MATLAB`, `Simulink` | Intermediate | Directory-Based | Script Automation | Uses a MATLAB script to generate input files for EHANDBOOK Container-Build from Simulink models. |
| [Demo_EHBCB_DirBased_UGG_iCB](./Demo_EHBCB_DirBased_UGG_iCB/README.md) | `UGG`, `Mixed Models` | Intermediate | Directory-Based | Accelerated Builds | Demonstrates the use of the Unified Graphics Generator (UGG) to speed up the EHB-CB process by pre-generating model graphics and data. |
| [Demo_EHBCB_DirBased_SL_Enhanced](./Demo_EHBCB_DirBased_SL_Enhanced/README.md) | `Simulink` | Advanced | Directory-Based | Advanced Features | Demonstrates advanced Simulink processing features, including custom table configurations and Simulink library support. |
| [Demo_EHBCB_DirBased_SL_ViewConcept](./Demo_EHBCB_DirBased_SL_ViewConcept/README.md) | `Simulink` | Advanced | Directory-Based | View Concept | Illustrates the Simulink View Concept to generate different EHANDBOOK variants from a single model, enabling know-how protection. |
| [Demo_DirBased_ASCET_SL_CCode](./Demo_DirBased_ASCET_SL_CCode/README.md) | `ASCET`, `Simulink`, `C-Code` | Advanced | Directory-Based | Mixed Models | A complex demo mixing ASCET, Simulink, and C-Code in a directory-based structure. |
| [Demo_DirBased_m-script_DocBlocks_to_AsciiDoc](./Demo_DirBased_m-script_DocBlocks_to_AsciiDoc/README.md) | `MATLAB`, `AsciiDoc` | Advanced | Directory-Based | DocBlock Conversion | Converts documentation blocks from m-scripts into AsciiDoc format. |
| [Demo_DirBased_SL_AsciiDoc_Japanese](./Demo_DirBased_SL_AsciiDoc_Japanese/README.md) | `Simulink`, `AsciiDoc`, `Localization` | Advanced | Directory-Based | Japanese Support | A Simulink demo featuring AsciiDoc and Japanese language support. |
| [Demo_DirBased_SL_FlexECU](./Demo_DirBased_SL_FlexECU/README.md) | `Simulink`, `FlexECU` | Intermediate | Directory-Based | FlexECU Integration | A Simulink-based demo with FlexECU integration. |
| [Demo_DirBased_SL_Libraries](./Demo_DirBased_SL_Libraries/README.md) | `Simulink` | Intermediate | Directory-Based | Library Handling | Demonstrates the handling and documentation of Simulink libraries. |
| [Demo_DirBased_SL_referencedModels](./Demo_DirBased_SL_referencedModels/README.md) | `Simulink` | Intermediate | Directory-Based | Referenced Models | Shows how to handle Simulink projects containing referenced models. |
| [Demo_DirBased_TargetLink_Library](./Demo_DirBased_TargetLink_Library/README.md) | `TargetLink`, `Simulink` | Advanced | Directory-Based | TargetLink Libraries | A demo for documenting TargetLink libraries. |

## AI-generated code notice

Use of generative AI in this repository:

The repository partially contains AI-generated code by using GitHub Copilot Business.

This notice needs to remain attached to any reproduction of this repository.
