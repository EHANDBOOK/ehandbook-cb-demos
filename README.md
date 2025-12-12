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

| # | Demo | Technology/Use Case | Skill Level | EHB-CB Approach | Feature/Aspect | Description |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| 1 | [Demo_EHBCB_AddOn_ASCET_Toolbox](./Demo_EHBCB_AddOn_ASCET_Toolbox/) | `ASCET` | Intermediate | Add-On | Toolbox | Placeholder: No README.md available. |
| 2 | [Demo_EHBCB_AddOn_SL_Toolbox](./Demo_EHBCB_AddOn_SL_Toolbox/) | `Simulink` | Intermediate | Add-On | Toolbox | Placeholder: No README.md available. |
| 3 | [Demo_EHBCB_ASAMBased_SL_Simple](./Demo_EHBCB_ASAMBased_SL_Simple/README.md) | `ASAM`, `Simulink` | Beginner | ASAM-Based | Single Function | Demonstrates generating an EHANDBOOK container using ASAM-based input formats for a single Simulink-based ECU function. |
| 4 | [Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU](./Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU/README.md) | `ASAM`, `ASCET`, `Simulink`, `PDF` | Advanced | ASAM-Based | Multi-Component with PDF | Generates an EHANDBOOK Container and PDF for a complex multi-component project with both ASCET and Simulink models. |
| 5 | [Demo_EHBCB_ASAMBased_AUTOSAR](./Demo_EHBCB_ASAMBased_AUTOSAR/README.md) | `ASAM`, `AUTOSAR`, `ASCET` | Advanced | ASAM-Based | AUTOSAR with ASCET | ASAM-based build for AUTOSAR Classic architecture with ASCET models for Software Components. |
| 6 | [Demo_EHBCB_ASAMBased_AUTOSAR_SL](./Demo_EHBCB_ASAMBased_AUTOSAR_SL/README.md) | `ASAM`, `AUTOSAR`, `Simulink` | Advanced | ASAM-Based | AUTOSAR with Simulink | ASAM-based build for AUTOSAR Classic architecture with Simulink models for Software Components. |
| 7 | [Demo_EHBCB_DirBased_AsciiDoc](./Demo_EHBCB_DirBased_AsciiDoc/README.md) | `AsciiDoc` | Beginner | Directory-Based | Documentation | Showcases generating an EHANDBOOK container from textual content written in AsciiDoc format. |
| 8 | [Demo_EHBCB_DirBased_CCODE_Simple](./Demo_EHBCB_DirBased_CCODE_Simple/README.md) | `C-Code` | Beginner | Directory-Based | Simple Example | A fundamental example of documenting a simple C-code project. |
| 9 | [Demo_EHBCB_DirBased_CCODE_References](./Demo_EHBCB_DirBased_CCODE_References/README.md) | `C-Code` | Intermediate | Directory-Based | Code Hierarchies | Demonstrates handling of code hierarchies and references in a C-Code project. |
| 10 | [Demo_EHBCB_DirBased_Custom_Tocs](./Demo_EHBCB_DirBased_Custom_Tocs/README.md) | `Customization` | Intermediate | Directory-Based | Custom TOCs | Shows how to create custom table of contents structures. |
| 11 | [Demo_EHBCB_DirBased_Language_Support](./Demo_EHBCB_DirBased_Language_Support/README.md) | `Customization`, `Localization` | Intermediate | Directory-Based | Multi-Language Support | Illustrates support for multiple languages in the output. |
| 12 | [Demo_EHBCB_DirBased_Nested_ToC](./Demo_EHBCB_DirBased_Nested_ToC/README.md) | `Customization` | Intermediate | Directory-Based | Nested TOCs | Creates deeply nested, hierarchical Tables of Contents using a tocs.yaml file. |
| 13 | [Demo_EHBCB_DirBased_PDF](./Demo_EHBCB_DirBased_PDF/README.md) | `PDF`, `AsciiDoc` | Intermediate | Directory-Based | PDF Embedding | Embeds content from external PDF documents into an EHANDBOOK container by converting PDF pages into SVG images. |
| 14 | [Demo_EHBCB_DirBased_SL_Mscript](./Demo_EHBCB_DirBased_SL_Mscript/README.md) | `MATLAB`, `Simulink` | Intermediate | Directory-Based | Script Automation | Uses a MATLAB script to generate input files for EHANDBOOK Container-Build from Simulink models. |
| 15 | [Demo_EHBCB_DirBased_SL_MScript_DocBlocks_To_AsciiDoc](./Demo_EHBCB_DirBased_SL_MScript_DocBlocks_To_AsciiDoc/README.md) | `MATLAB`, `AsciiDoc` | Advanced | Directory-Based | DocBlock Conversion | Converts documentation blocks from m-scripts into AsciiDoc format. |
| 16 | [Demo_EHBCB_DirBased_UGG_iCB](./Demo_EHBCB_DirBased_UGG_iCB/README.md) | `UGG`, `Mixed Models` | Intermediate | Directory-Based | Accelerated Builds | Demonstrates the use of the Unified Graphics Generator (UGG) to speed up the EHB-CB process by pre-generating model graphics and data. |
| 17 | [Demo_EHBCB_DirBased_ASCET_SL_CCODE](./Demo_EHBCB_DirBased_ASCET_SL_CCODE/README.md) | `ASCET`, `Simulink`, `C-Code` | Advanced | Directory-Based | Mixed Models | Generates a single container from mixed sources: ASCET model, Simulink model, and C-Code. |
| 18 | [Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed](./Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed/README.md) | `ASCET`, `Simulink`, `C-Code` | Advanced | Directory-Based | Mixed Models | Combines function specifications from ASCET, Simulink, and C-Code in a single build. |
| 19 | [Demo_EHBCB_DirBased_SL_Enhanced](./Demo_EHBCB_DirBased_SL_Enhanced/README.md) | `Simulink` | Advanced | Directory-Based | Advanced Features | Demonstrates advanced Simulink processing features, including custom table configurations and Simulink library support. |
| 20 | [Demo_EHBCB_DirBased_SL_ViewConcept](./Demo_EHBCB_DirBased_SL_ViewConcept/README.md) | `Simulink` | Advanced | Directory-Based | View Concept | Illustrates the Simulink View Concept to generate different EHANDBOOK variants from a single model, enabling know-how protection. |
| 21 | [Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese](./Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese/README.md) | `Simulink`, `AsciiDoc`, `Localization` | Advanced | Directory-Based | Japanese Support | A Simulink demo featuring AsciiDoc and Japanese language support. |
| 22 | [Demo_EHBCB_DirBased_SL_FlexECU](./Demo_EHBCB_DirBased_SL_FlexECU/README.md) | `Simulink`, `FlexECU` | Intermediate | Directory-Based | Complete FlexECU Project | A comprehensive example of generating complete ECU software documentation with 15 Simulink-based functions. |
| 23 | [Demo_EHBCB_DirBased_SL_Libraries](./Demo_EHBCB_DirBased_SL_Libraries/README.md) | `Simulink` | Intermediate | Directory-Based | Library Handling | Demonstrates the handling and documentation of Simulink libraries with view configuration for know-how protection. |
| 24 | [Demo_EHBCB_DirBased_SL_ReferencedModels](./Demo_EHBCB_DirBased_SL_ReferencedModels/README.md) | `Simulink` | Intermediate | Directory-Based | Referenced Models | Shows how to handle Simulink projects containing referenced models. |
| 25 | [Demo_EHBCB_DirBased_SL_TargetLink_Library](./Demo_EHBCB_DirBased_SL_TargetLink_Library/README.md) | `TargetLink`, `Simulink` | Advanced | Directory-Based | TargetLink Libraries | Demonstrates support for Simulink models containing dSPACE TargetLink blocks. |
| 26 | [Demo_EHBCB_DirBased_AUTOSAR](./Demo_EHBCB_DirBased_AUTOSAR/README.md) | `AUTOSAR`, `ASCET` | Advanced | Directory-Based | AUTOSAR with ASCET | Directory-based build for AUTOSAR Classic architecture with ASCET models for Software Components. |
| 27 | [Demo_EHBCB_DirBased_AUTOSAR_CCODE](./Demo_EHBCB_DirBased_AUTOSAR_CCODE/README.md) | `AUTOSAR`, `C-Code` | Advanced | Directory-Based | AUTOSAR with C-Code | Documents an AUTOSAR Classic system from RTA-CAR Starter Kit with C-Code implementations. |
| 28 | [Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config](./Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config/README.md) | `AUTOSAR`, `C-Code` | Advanced | Directory-Based | RTE Visualization | Detailed example of C-Code configuration to visually enhance AUTOSAR RTE API calls with custom icons. |
| 29 | [Demo_EHBCB_DirBased_AUTOSAR_Excerpt](./Demo_EHBCB_DirBased_AUTOSAR_Excerpt/README.md) | `AUTOSAR`, `ASCET` | Intermediate | Directory-Based | System Subset | Documents an excerpt or subset of a larger AUTOSAR Classic system. |
| 30 | [Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only](./Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only/README.md) | `AUTOSAR` | Intermediate | Directory-Based | Architecture Only | Documents only AUTOSAR architecture from ARXML files without implementation details. |
| 31 | [Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only](./Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only/README.md) | `AUTOSAR` | Intermediate | Directory-Based | Architecture Only | Two-step workflow using -ar2ehbcbinput flag to document AUTOSAR architecture only. |
| 32 | [Demo_EHBCB_DirBased_AUTOSAR_MATLAB](./Demo_EHBCB_DirBased_AUTOSAR_MATLAB/README.md) | `AUTOSAR`, `Simulink` | Intermediate | Directory-Based | AUTOSAR with Simulink | Generates container for AUTOSAR software component specified by a Simulink model. |
| 33 | [Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only](./Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only/README.md) | `AUTOSAR` | Intermediate | Directory-Based | RTA-RTE Architecture | Two-step workflow to document AUTOSAR architecture from RTA-RTE case study. |
| 34 | [Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping](./Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping/README.md) | `AUTOSAR` | Advanced | Directory-Based | Signal Mapping | Establishes and visualizes connections between components from different domains using component mapping. |
| 35 | [Demo_EHBCB_DirBased_AUTOSAR_SL](./Demo_EHBCB_DirBased_AUTOSAR_SL/README.md) | `AUTOSAR`, `Simulink` | Advanced | Directory-Based | AUTOSAR with Simulink | Documents AUTOSAR Classic SWC with Simulink implementation. |

## AI-generated code notice

Use of generative AI in this repository:

The repository partially contains AI-generated code by using GitHub Copilot Business.

This notice needs to remain attached to any reproduction of this repository.
