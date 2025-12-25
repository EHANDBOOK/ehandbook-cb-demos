# EHANDBOOK Container-Build Demos

This repository contains a set of demos showcasing the capabilities of EHANDBOOK Container-Build (EHB-CB), a tool for automatically generating technical documentation in EHANDBOOK format from various source formats including Simulink models, C-Code, AUTOSAR specifications, and more.

Visit <http://ehandbook.etas.com> for a general overview on the ETAS EHANDBOOK solution.

Detailed information on EHANDBOOK Container-Build can be found in the documentation at <https://docs.etas.com/ehandbook/ehandbook/container_build.html>.

## What Each Demo Contains

Each demo folder is self-contained and includes:

- **README.md** – Comprehensive documentation covering:
  - Description of what the demo illustrates
  - Key features showcased
  - Step-by-step instructions on how to run the demo
  - Directory and file structure of input data and configurations
- **build.bat** – Batch script for building the demo
- **Input/** – Source files and configuration data specific to the demo
- **Output/** – Pre-built EHANDBOOK Container (`.ehb` file) that can be explored immediately with EHANDBOOK-NAVIGATOR

## Table of Contents

- [What Each Demo Contains](#what-each-demo-contains)
- [What You'll Need](#what-youll-need)
- [Product Evaluations](#product-evaluations)
- [Getting Started](#getting-started)  
  - [Clone Repository](#clone-repository)
  - [Setup](#setup)
- [How to Run a Demo](#how-to-run-a-demo)
- [Demo Overview](#demo-overview)
- [AI-Generated Code Notice](#ai-generated-code-notice)

## What You'll Need

Before you begin, ensure you have:

- ✅ **EHANDBOOK Container-Build tools** (latest version recommended)
- ✅ **EHANDBOOK-NAVIGATOR tool** for viewing generated EHB Containers (latest version recommended)
- ✅ **MATLAB/Simulink** (R2021a or later, optional for Simulink demos)
- ✅ **Git** (for cloning the repository)
- ⏱️ **Estimated setup time:** 15-20 minutes

## Product Evaluations

ETAS offers time-limited evaluations for EHANDBOOK products free of charge.

Visit [https://license.etas.com](https://license.etas.com) and navigate to **Product Evaluation** or go to the [product evaluation page](https://license.etas.com/LandingPage/htm/evalproducts.jsp?lang=English) directly.

## Getting Started

### Clone Repository

A guide on how to setup SSH for cloning the repository can be found here: <https://confluence.etas-dev.com/display/ETASDEVU/SSH+Git+Access+to+Bitbucket#SSHGitAccesstoBitbucket-Createpublicandprivatekeypair>.

### Setup

After cloning the repository, you first should adapt the file `set_tool_paths.bat` to match your local environment.

**Example configuration:**

```batch
set EHB_CB_PATH=C:\ETAS\EHANDBOOK-Container-Build_13.5.0_Windows
set EHB_UGG_PATH=C:\ETAS\EHANDBOOK-Container-Build_13.5.0_Windows
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

## Demo Overview

This repository is organized into demo folders, each showcasing specific features or use cases.

The table below lists all available demos, grouped by the **EHB-CB Approach** (e.g., Directory-Based, ASAM-Based). Each entry includes a link to the demo's `README.md`, a download link for the generated output, a short description, the technology used, and the skill level.

| # | Demo | Download .ehb | Description | EHB-CB Approach | Technology/Use Case | Skill Level |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| 1  | [Demo_EHBCB_DirBased_ASCET_SL_CCODE](./Demo_EHBCB_DirBased_ASCET_SL_CCODE/README.md) | [Download](./Demo_EHBCB_DirBased_ASCET_SL_CCODE/Output/Demo_EHBCB_DirBased_ASCET_SL_CCODE.ehb) | Generates a single container from mixed sources: ASCET model, Simulink model, and C-Code. | Directory-Based | `ASCET`, `Simulink`, `C-Code` | Advanced |
| 2  | [Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed](./Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed/README.md) | [Download](./Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed/Output/Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed.ehb) | Combines function specifications from ASCET, Simulink, and C-Code in a single build. | Directory-Based | `ASCET`, `Simulink`, `C-Code` | Advanced |
| 3  | [Demo_EHBCB_DirBased_SL_FlexECU](./Demo_EHBCB_DirBased_SL_FlexECU/README.md) | [Download](./Demo_EHBCB_DirBased_SL_FlexECU/Output/Demo_EHBCB_DirBased_SL_FlexECU.ehb) | A comprehensive example of generating complete ECU software documentation with 15 Simulink-based functions. | Directory-Based | `Simulink`, `FlexECU` | Intermediate |
| 4  | [Demo_EHBCB_DirBased_SL_Enhanced](./Demo_EHBCB_DirBased_SL_Enhanced/README.md) | [Download](./Demo_EHBCB_DirBased_SL_Enhanced/Output/Demo_EHBCB_DirBased_SL_Enhanced.ehb) | Demonstrates advanced Simulink processing features, including custom table configurations and Simulink library support. | Directory-Based | `Simulink` | Advanced |
| 5  | [Demo_EHBCB_DirBased_SL_ReferencedModels](./Demo_EHBCB_DirBased_SL_ReferencedModels/README.md) | [Download](./Demo_EHBCB_DirBased_SL_ReferencedModels/Output/Demo_EHBCB_DirBased_SL_ReferencedModels.ehb) | Shows how to handle Simulink projects containing referenced models. | Directory-Based | `Simulink` | Intermediate |
| 6  | [Demo_EHBCB_DirBased_SL_Libraries](./Demo_EHBCB_DirBased_SL_Libraries/README.md) | [Download](./Demo_EHBCB_DirBased_SL_Libraries/Output/Demo_EHBCB_DirBased_SL_Libraries.ehb) | Demonstrates the handling and documentation of Simulink libraries with view configuration for know-how protection. | Directory-Based | `Simulink` | Intermediate |
| 7  | [Demo_EHBCB_DirBased_SL_TargetLink_Library](./Demo_EHBCB_DirBased_SL_TargetLink_Library/README.md) | [Download](./Demo_EHBCB_DirBased_SL_TargetLink_Library/Output/Demo_EHBCB_DirBased_SL_TargetLink_Library.ehb) | Demonstrates support for Simulink models containing dSPACE TargetLink blocks. | Directory-Based | `TargetLink`, `Simulink` | Advanced |
| 8  | [Demo_EHBCB_DirBased_SL_ViewConcept](./Demo_EHBCB_DirBased_SL_ViewConcept/README.md) | [Download (Internal)](./Demo_EHBCB_DirBased_SL_ViewConcept/Output/Demo_EHBCB_DirBased_SL_ViewConcept_Internal.ehb), [Download (External)](./Demo_EHBCB_DirBased_SL_ViewConcept/Output/Demo_EHBCB_DirBased_SL_ViewConcept_External.ehb) | Illustrates the Simulink View Concept to generate different EHANDBOOK variants from a single model, enabling know-how protection. | Directory-Based | `Simulink` | Advanced |
| 9  | [Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese](./Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese/README.md) | [Download](./Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese/Output/Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese.ehb) | A Simulink demo featuring AsciiDoc and Japanese language support. | Directory-Based | `Simulink`, `AsciiDoc`, `Localization` | Advanced |
| 10 | [Demo_EHBCB_DirBased_SL_Mscript](./Demo_EHBCB_DirBased_SL_Mscript/README.md) | [Download](./Demo_EHBCB_DirBased_SL_Mscript/Output/Demo_EHBCB_DirBased_SL_Mscript.ehb) | Uses a MATLAB script to generate input files for EHANDBOOK Container-Build from Simulink models. | Directory-Based | `MATLAB`, `Simulink` | Intermediate |
| 11 | [Demo_EHBCB_DirBased_SL_MScript_DocBlocks_To_AsciiDoc](./Demo_EHBCB_DirBased_SL_MScript_DocBlocks_To_AsciiDoc/README.md) | [Download](./Demo_EHBCB_DirBased_SL_MScript_DocBlocks_To_AsciiDoc/Output/Demo_EHBCB_DirBased_SL_MScript_DocBlocks_To_AsciiDoc.ehb) | Converts documentation blocks from m-scripts into AsciiDoc format. | Directory-Based | `MATLAB`, `AsciiDoc` | Advanced |
| 12 | [Demo_EHBCB_DirBased_CCODE_Simple](./Demo_EHBCB_DirBased_CCODE_Simple/README.md) | [Download](./Demo_EHBCB_DirBased_CCODE_Simple/Output/Demo_EHBCB_DirBased_CCODE_Simple.ehb) | A fundamental example of documenting a simple C-code project. | Directory-Based | `C-Code` | Beginner |
| 13 | [Demo_EHBCB_DirBased_CCODE_References](./Demo_EHBCB_DirBased_CCODE_References/README.md) | [Download (With Hierarchies)](./Demo_EHBCB_DirBased_CCODE_References/Output/Demo_EHBCB_DirBased_CCODE_References_With_Hierarchies.ehb), [Download (Without Hierarchies)](./Demo_EHBCB_DirBased_CCODE_References/Output/Demo_EHBCB_DirBased_CCODE_References_Without_Hierarchies.ehb) | Demonstrates handling of code hierarchies and references in a C-Code project. | Directory-Based | `C-Code` | Intermediate |
| 14 | [Demo_EHBCB_DirBased_AUTOSAR](./Demo_EHBCB_DirBased_AUTOSAR/README.md) | [Download](./Demo_EHBCB_DirBased_AUTOSAR/Output/Demo_EHBCB_DirBased_AUTOSAR.ehb) | Directory-based build for AUTOSAR Classic architecture with ASCET models for Software Components. | Directory-Based | `AUTOSAR`, `ASCET` | Advanced |
| 23 | [Demo_EHBCB_DirBased_AUTOSAR_SL](./Demo_EHBCB_DirBased_AUTOSAR_SL/README.md) | [Download](./Demo_EHBCB_DirBased_AUTOSAR_SL/Output/Demo_EHBCB_DirBased_AUTOSAR_SL.ehb) | Documents AUTOSAR Classic SWC with Simulink implementation. | Directory-Based | `AUTOSAR`, `Simulink` | Advanced |
| 15 | [Demo_EHBCB_DirBased_AUTOSAR_CCODE](./Demo_EHBCB_DirBased_AUTOSAR_CCODE/README.md) | [Download](./Demo_EHBCB_DirBased_AUTOSAR_CCODE/Output/Demo_EHBCB_DirBased_AUTOSAR_CCODE.ehb) | Documents an AUTOSAR Classic system from RTA-CAR Starter Kit with C-Code implementations. | Directory-Based | `AUTOSAR`, `C-Code` | Advanced |
| 16 | [Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config](./Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config/README.md) | [Download](./Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config/Output/Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config.ehb) | Detailed example of C-Code configuration to visually enhance AUTOSAR RTE API calls with custom icons. | Directory-Based | `AUTOSAR`, `C-Code` | Advanced |
| 17 | [Demo_EHBCB_DirBased_AUTOSAR_Excerpt](./Demo_EHBCB_DirBased_AUTOSAR_Excerpt/README.md) | [Download](./Demo_EHBCB_DirBased_AUTOSAR_Excerpt/Output/Demo_EHBCB_DirBased_AUTOSAR_Excerpt.ehb) | Documents an excerpt or subset of a larger AUTOSAR Classic system. | Directory-Based | `AUTOSAR`, `ASCET` | Intermediate |
| 18 | [Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only](./Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only/README.md) | [Download](./Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only/Output/Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only.ehb) | Documents only AUTOSAR architecture from ARXML files without implementation details. | Directory-Based | `AUTOSAR` | Intermediate |
| 19 | [Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only](./Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only/README.md) | [Download](./Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only/Output/Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only.ehb) | Two-step workflow using -ar2ehbcbinput flag to document AUTOSAR architecture only. | Directory-Based | `AUTOSAR` | Intermediate |
| 20 | [Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU](./Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU/README.md) | [Download](./Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU/Output/Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU.ehb) | Generates container for AUTOSAR software component specified by a Simulink model. | Directory-Based | `AUTOSAR`, `Simulink` | Intermediate |
| 21 | [Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only](./Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only/README.md) | [Download](./Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only/Output/Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only.ehb) | Two-step workflow to document AUTOSAR architecture from RTA-RTE case study. | Directory-Based | `AUTOSAR` | Intermediate |
| 22 | [Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping](./Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping/README.md) | [Download](./Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping/Output/Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping.ehb) | Establishes and visualizes connections between components from different domains using component mapping. | Directory-Based | `AUTOSAR` | Advanced |
| 24 | [Demo_EHBCB_DirBased_AsciiDoc](./Demo_EHBCB_DirBased_AsciiDoc/README.md) | [Download](./Demo_EHBCB_DirBased_AsciiDoc/Output/Demo_EHBCB_DirBased_AsciiDoc.ehb) | Showcases generating an EHANDBOOK container from textual content written in AsciiDoc format. | Directory-Based | `AsciiDoc` | Beginner |
| 25 | [Demo_EHBCB_DirBased_Language_Support](./Demo_EHBCB_DirBased_Language_Support/README.md) | [Download](./Demo_EHBCB_DirBased_Language_Support/Output/Demo_EHBCB_DirBased_Language_Support.ehb) | Illustrates support for multiple languages in the output. | Directory-Based | `Customization`, `Localization` | Intermediate |
| 26 | [Demo_EHBCB_DirBased_Custom_Tocs](./Demo_EHBCB_DirBased_Custom_Tocs/README.md) | [Download](./Demo_EHBCB_DirBased_Custom_ToCs/Output/Demo_EHBCB_DirBased_Custom_Tocs.ehb) | Shows how to create custom table of contents structures. | Directory-Based | `Customization` | Intermediate |
| 27 | [Demo_EHBCB_DirBased_Nested_ToC](./Demo_EHBCB_DirBased_Nested_ToC/README.md) | [Download](./Demo_EHBCB_DirBased_Nested_ToC/Output/Demo_EHBCB_DirBased_Nested_ToC.ehb) | Creates deeply nested, hierarchical Tables of Contents using a tocs.yaml file. | Directory-Based | `Customization` | Intermediate |
| 28 | [Demo_EHBCB_DirBased_UGG_iCB](./Demo_EHBCB_DirBased_UGG_iCB/README.md) | [Download](./Demo_EHBCB_DirBased_UGG_iCB/Output_iCB/Demo_EHBCB_DirBased_UGG_iCB.ehb) | Demonstrates the use of the Unified Graphics Generator (UGG) to speed up the EHB-CB process by pre-generating model graphics and data. | Directory-Based | `UGG`, `Mixed Models` | Intermediate |
| 29 | [Demo_EHBCB_ASAMBased_SL_Simple](./Demo_EHBCB_ASAMBased_SL_Simple/README.md) | [Download](./Demo_EHBCB_ASAMBased_SL_Simple/Output/Demo_EHBCB_ASAMBased_SL_Simple.ehb) | Demonstrates generating an EHANDBOOK container using ASAM-based input formats for a single Simulink-based ECU function. | ASAM-Based | `ASAM`, `Simulink` | Beginner |
| 30 | [Demo_EHBCB_ASAMBased_AUTOSAR](./Demo_EHBCB_ASAMBased_AUTOSAR/README.md) | [Download](./Demo_EHBCB_ASAMBased_AUTOSAR/Output/Demo_EHBCB_ASAMBased_AUTOSAR.ehb) | ASAM-based build for AUTOSAR Classic architecture with ASCET models for Software Components. | ASAM-Based | `ASAM`, `AUTOSAR`, `ASCET` | Advanced |
| 31 | [Demo_EHBCB_ASAMBased_AUTOSAR_SL](./Demo_EHBCB_ASAMBased_AUTOSAR_SL/README.md) | [Download](./Demo_EHBCB_ASAMBased_AUTOSAR_SL/Output/Demo_EHBCB_ASAMBased_AUTOSAR_SL.ehb) | ASAM-based build for AUTOSAR Classic architecture with Simulink models for Software Components. | ASAM-Based | `ASAM`, `AUTOSAR`, `Simulink` | Advanced |
| 32 | [Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU](./Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU/README.md) | [Download](./Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU/Output/Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU.ehb) | Generates an EHANDBOOK Container and PDF for a complex multi-component project with both ASCET and Simulink models. | ASAM-Based | `ASAM`, `ASCET`, `Simulink`, `PDF` | Advanced |
| 33 | [Demo_EHBCB_AddOn_ASCET_Toolbox](./Demo_EHBCB_AddOn_ASCET_Toolbox/README.md) | *(no .ehb found)* | Placeholder: No README.md available. | Add-On | `ASCET` | Intermediate |
| 34 | [Demo_EHBCB_AddOn_SL_Toolbox](./Demo_EHBCB_AddOn_SL_Toolbox/) | *(no .ehb found)* | Placeholder: No README.md available. | Add-On | `Simulink` | Intermediate |

## AI-generated code notice

Use of generative AI in this repository:

The repository partially contains AI-generated code by using GitHub Copilot Business.

This notice needs to remain attached to any reproduction of this repository.
