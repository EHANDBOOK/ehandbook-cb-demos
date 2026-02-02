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

Clone the repository using Git:

```bash
git clone https://github.com/EHANDBOOK/ehandbook-cb-demos.git
cd ehandbook-cb-demos
```

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

This repository is organized into demo folders, each showcasing specific features or use cases. Browse **33+ demos** organized by technology and use case below.

---

### 🔀 Mixed Models & Advanced Integration

<details>
<summary><strong>ASCET + Simulink + C-Code (2 demos)</strong></summary>

**[Demo_EHBCB_DirBased_ASCET_SL_CCODE](./Demo_EHBCB_DirBased_ASCET_SL_CCODE/README.md)** · `Advanced`  
Generates a single container from mixed sources: ASCET model, Simulink model, and C-Code.  
📦 Technologies: `ASCET`, `Simulink`, `C-Code` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_ASCET_SL_CCODE/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_ASCET_SL_CCODE/Output/Demo_EHBCB_DirBased_ASCET_SL_CCODE.ehb)

**[Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed](./Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed/README.md)** · `Advanced`  
Combines function specifications from ASCET, Simulink, and C-Code in a single build.  
📦 Technologies: `ASCET`, `Simulink`, `C-Code` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed/Output/Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed.ehb)

</details>

---

### 🎯 Simulink Demos

<details>
<summary><strong>Simulink Projects & Models (10 demos)</strong></summary>

**[Demo_EHBCB_DirBased_SL_FlexECU](./Demo_EHBCB_DirBased_SL_FlexECU/README.md)** · `Intermediate`  
A comprehensive example of generating complete ECU software documentation with 15 Simulink-based functions.  
📦 Technologies: `Simulink`, `FlexECU` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_SL_FlexECU/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_SL_FlexECU/Output/Demo_EHBCB_DirBased_SL_FlexECU.ehb)

**[Demo_EHBCB_DirBased_SL_Enhanced](./Demo_EHBCB_DirBased_SL_Enhanced/README.md)** · `Advanced`  
Demonstrates advanced Simulink processing features, including custom table configurations and Simulink library support.  
📦 Technologies: `Simulink` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_SL_Enhanced/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_SL_Enhanced/Output/Demo_EHBCB_DirBased_SL_Enhanced.ehb)

**[Demo_EHBCB_DirBased_SL_ReferencedModels](./Demo_EHBCB_DirBased_SL_ReferencedModels/README.md)** · `Intermediate`  
Shows how to handle Simulink projects containing referenced models.  
📦 Technologies: `Simulink` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_SL_ReferencedModels/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_SL_ReferencedModels/Output/Demo_EHBCB_DirBased_SL_ReferencedModels.ehb)

**[Demo_EHBCB_DirBased_SL_Libraries](./Demo_EHBCB_DirBased_SL_Libraries/README.md)** · `Intermediate`  
Demonstrates the handling and documentation of Simulink libraries with view configuration for know-how protection.  
📦 Technologies: `Simulink` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_SL_Libraries/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_SL_Libraries/Output/Demo_EHBCB_DirBased_SL_Libraries.ehb)

**[Demo_EHBCB_DirBased_SL_ViewConcept](./Demo_EHBCB_DirBased_SL_ViewConcept/README.md)** · `Advanced`  
Illustrates the Simulink View Concept to generate different EHANDBOOK variants from a single model, enabling know-how protection.  
📦 Technologies: `Simulink` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_SL_ViewConcept/README.md) · [⬇️ Download Internal](./Demo_EHBCB_DirBased_SL_ViewConcept/Output/Demo_EHBCB_DirBased_SL_ViewConcept_Internal.ehb) · [⬇️ Download External](./Demo_EHBCB_DirBased_SL_ViewConcept/Output/Demo_EHBCB_DirBased_SL_ViewConcept_External.ehb)

**[Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese](./Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese/README.md)** · `Advanced`  
A Simulink demo featuring AsciiDoc and Japanese language support.  
📦 Technologies: `Simulink`, `AsciiDoc`, `Localization` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese/Output/Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese.ehb)

**[Demo_EHBCB_DirBased_SL_Mscript](./Demo_EHBCB_DirBased_SL_Mscript/README.md)** · `Intermediate`  
Uses a MATLAB script to generate input files for EHANDBOOK Container-Build from Simulink models.  
📦 Technologies: `MATLAB`, `Simulink` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_SL_Mscript/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_SL_Mscript/Output/Demo_EHBCB_DirBased_SL_Mscript.ehb)

**[Demo_EHBCB_DirBased_SL_MScript_DocBlocks_To_AsciiDoc](./Demo_EHBCB_DirBased_SL_MScript_DocBlocks_To_AsciiDoc/README.md)** · `Advanced`  
Converts documentation blocks from m-scripts into AsciiDoc format.  
📦 Technologies: `MATLAB`, `AsciiDoc` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_SL_MScript_DocBlocks_To_AsciiDoc/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_SL_MScript_DocBlocks_To_AsciiDoc/Output/Demo_EHBCB_DirBased_SL_MScript_DocBlocks_To_AsciiDoc.ehb)

**[Demo_EHBCB_DirBased_UGG_iCB](./Demo_EHBCB_DirBased_UGG_iCB/README.md)** · `Intermediate`  
Demonstrates the use of the Unified Graphics Generator (UGG) to speed up the EHB-CB process by pre-generating model graphics and data.  
📦 Technologies: `UGG`, `Mixed Models` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_UGG_iCB/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_UGG_iCB/Output_iCB/Demo_EHBCB_DirBased_UGG_iCB.ehb)

**[Demo_EHBCB_ASAMBased_SL_Simple](./Demo_EHBCB_ASAMBased_SL_Simple/README.md)** · `Beginner`  
Demonstrates generating an EHANDBOOK container using ASAM-based input formats for a single Simulink-based ECU function.  
📦 Technologies: `ASAM`, `Simulink` · 📋 ASAM-Based  
[📖 Documentation](./Demo_EHBCB_ASAMBased_SL_Simple/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_ASAMBased_SL_Simple/Output/Demo_EHBCB_ASAMBased_SL_Simple.ehb)

</details>

---

### 💻 C-Code Demos

<details>
<summary><strong>C-Code Documentation (2 demos)</strong></summary>

**[Demo_EHBCB_DirBased_CCODE_Simple](./Demo_EHBCB_DirBased_CCODE_Simple/README.md)** · `Beginner`  
A fundamental example of documenting a simple C-code project.  
📦 Technologies: `C-Code` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_CCODE_Simple/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_CCODE_Simple/Output/Demo_EHBCB_DirBased_CCODE_Simple.ehb)

**[Demo_EHBCB_DirBased_CCODE_References](./Demo_EHBCB_DirBased_CCODE_References/README.md)** · `Intermediate`  
Demonstrates handling of code hierarchies and references in a C-Code project.  
📦 Technologies: `C-Code` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_CCODE_References/README.md) · [⬇️ Download With Hierarchies](./Demo_EHBCB_DirBased_CCODE_References/Output/Demo_EHBCB_DirBased_CCODE_References_With_Hierarchies.ehb) · [⬇️ Download Without Hierarchies](./Demo_EHBCB_DirBased_CCODE_References/Output/Demo_EHBCB_DirBased_CCODE_References_Without_Hierarchies.ehb)

</details>

---

### 🚗 AUTOSAR Demos

<details>
<summary><strong>AUTOSAR Classic Architecture (10 demos)</strong></summary>

**[Demo_EHBCB_DirBased_AUTOSAR](./Demo_EHBCB_DirBased_AUTOSAR/README.md)** · `Advanced`  
Directory-based build for AUTOSAR Classic architecture with ASCET models for Software Components.  
📦 Technologies: `AUTOSAR`, `ASCET` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_AUTOSAR/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_AUTOSAR/Output/Demo_EHBCB_DirBased_AUTOSAR.ehb)

**[Demo_EHBCB_DirBased_AUTOSAR_SL](./Demo_EHBCB_DirBased_AUTOSAR_SL/README.md)** · `Advanced`  
Documents AUTOSAR Classic SWC with Simulink implementation.  
📦 Technologies: `AUTOSAR`, `Simulink` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_AUTOSAR_SL/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_AUTOSAR_SL/Output/Demo_EHBCB_DirBased_AUTOSAR_SL.ehb)

**[Demo_EHBCB_DirBased_AUTOSAR_CCODE](./Demo_EHBCB_DirBased_AUTOSAR_CCODE/README.md)** · `Advanced`  
Documents an AUTOSAR Classic system from RTA-CAR Starter Kit with C-Code implementations.  
📦 Technologies: `AUTOSAR`, `C-Code` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_AUTOSAR_CCODE/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_AUTOSAR_CCODE/Output/Demo_EHBCB_DirBased_AUTOSAR_CCODE.ehb)

**[Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config](./Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config/README.md)** · `Advanced`  
Detailed example of C-Code configuration to visually enhance AUTOSAR RTE API calls with custom icons.  
📦 Technologies: `AUTOSAR`, `C-Code` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config/Output/Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config.ehb)

**[Demo_EHBCB_DirBased_AUTOSAR_Excerpt](./Demo_EHBCB_DirBased_AUTOSAR_Excerpt/README.md)** · `Intermediate`  
Documents an excerpt or subset of a larger AUTOSAR Classic system.  
📦 Technologies: `AUTOSAR`, `ASCET` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_AUTOSAR_Excerpt/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_AUTOSAR_Excerpt/Output/Demo_EHBCB_DirBased_AUTOSAR_Excerpt.ehb)

**[Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only](./Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only/README.md)** · `Intermediate`  
Documents only AUTOSAR architecture from ARXML files without implementation details.  
📦 Technologies: `AUTOSAR` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only/Output/Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only.ehb)

**[Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only](./Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only/README.md)** · `Intermediate`  
Two-step workflow using -ar2ehbcbinput flag to document AUTOSAR architecture only.  
📦 Technologies: `AUTOSAR` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only/Output/Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only.ehb)

**[Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU](./Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU/README.md)** · `Intermediate`  
Generates container for AUTOSAR software component specified by a Simulink model.  
📦 Technologies: `AUTOSAR`, `Simulink` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU/Output/Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU.ehb)

**[Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only](./Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only/README.md)** · `Intermediate`  
Two-step workflow to document AUTOSAR architecture from RTA-RTE case study.  
📦 Technologies: `AUTOSAR` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only/Output/Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only.ehb)

**[Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping](./Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping/README.md)** · `Advanced`  
Establishes and visualizes connections between components from different domains using component mapping.  
📦 Technologies: `AUTOSAR` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping/Output/Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping.ehb)

</details>

---

### 📝 Documentation & Customization

<details>
<summary><strong>AsciiDoc, Localization & Table of Contents (3 demos)</strong></summary>

**[Demo_EHBCB_DirBased_AsciiDoc](./Demo_EHBCB_DirBased_AsciiDoc/README.md)** · `Beginner`  
Showcases generating an EHANDBOOK container from textual content written in AsciiDoc format.  
📦 Technologies: `AsciiDoc` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_AsciiDoc/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_AsciiDoc/Output/Demo_EHBCB_DirBased_AsciiDoc.ehb)

**[Demo_EHBCB_DirBased_Language_Support](./Demo_EHBCB_DirBased_Language_Support/README.md)** · `Intermediate`  
Illustrates support for multiple languages in the output.  
📦 Technologies: `Customization`, `Localization` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_Language_Support/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_Language_Support/Output/Demo_EHBCB_DirBased_Language_Support.ehb)

**[Demo_EHBCB_DirBased_Custom_Tocs](./Demo_EHBCB_DirBased_Custom_Tocs/README.md)** · `Intermediate`  
Shows how to create custom table of contents structures.  
📦 Technologies: `Customization` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_Custom_Tocs/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_Custom_Tocs/Output/Demo_EHBCB_DirBased_Custom_Tocs.ehb)

**[Demo_EHBCB_DirBased_Nested_ToC](./Demo_EHBCB_DirBased_Nested_ToC/README.md)** · `Intermediate`  
Creates deeply nested, hierarchical Tables of Contents using a tocs.yaml file.  
📦 Technologies: `Customization` · 📁 Directory-Based  
[📖 Documentation](./Demo_EHBCB_DirBased_Nested_ToC/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_DirBased_Nested_ToC/Output/Demo_EHBCB_DirBased_Nested_ToC.ehb)

</details>

---

### 📋 ASAM-Based Demos

<details>
<summary><strong>ASAM-Based Workflows (3 demos)</strong></summary>

**[Demo_EHBCB_ASAMBased_AUTOSAR](./Demo_EHBCB_ASAMBased_AUTOSAR/README.md)** · `Advanced`  
ASAM-based build for AUTOSAR Classic architecture with ASCET models for Software Components.  
📦 Technologies: `ASAM`, `AUTOSAR`, `ASCET` · 📋 ASAM-Based  
[📖 Documentation](./Demo_EHBCB_ASAMBased_AUTOSAR/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_ASAMBased_AUTOSAR/Output/Demo_EHBCB_ASAMBased_AUTOSAR.ehb)

**[Demo_EHBCB_ASAMBased_AUTOSAR_SL](./Demo_EHBCB_ASAMBased_AUTOSAR_SL/README.md)** · `Advanced`  
ASAM-based build for AUTOSAR Classic architecture with Simulink models for Software Components.  
📦 Technologies: `ASAM`, `AUTOSAR`, `Simulink` · 📋 ASAM-Based  
[📖 Documentation](./Demo_EHBCB_ASAMBased_AUTOSAR_SL/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_ASAMBased_AUTOSAR_SL/Output/Demo_EHBCB_ASAMBased_AUTOSAR_SL.ehb)

**[Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU](./Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU/README.md)** · `Advanced`  
Generates an EHANDBOOK Container and PDF for a complex multi-component project with both ASCET and Simulink models.  
📦 Technologies: `ASAM`, `ASCET`, `Simulink`, `PDF` · 📋 ASAM-Based  
[📖 Documentation](./Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU/README.md) · [⬇️ Download .ehb](./Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU/Output/Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU.ehb)

</details>

---

### 🔧 Add-On Tools

<details>
<summary><strong>Toolbox Integrations (2 demos)</strong></summary>

**[Demo_EHBCB_AddOn_ASCET_Toolbox](./Demo_EHBCB_AddOn_ASCET_Toolbox/README.md)** · `Intermediate`  
Documents the EHANDBOOK Container-Build Add-On for ASCET Toolbox.
📦 Technologies: `ASCET` · 🔧 Add-On  
[📖 Documentation](./Demo_EHBCB_AddOn_ASCET_Toolbox/README.md)

**[Demo_EHBCB_AddOn_SL_Toolbox](./Demo_EHBCB_AddOn_SL_Toolbox/)** · `Intermediate`  
Placeholder: No README.md available.  
📦 Technologies: `Simulink` · 🔧 Add-On

</details>

## AI-generated code notice

Use of generative AI in this repository:

The repository partially contains AI-generated code by using GitHub Copilot Business.

This notice needs to remain attached to any reproduction of this repository.
