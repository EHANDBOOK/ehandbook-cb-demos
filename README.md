# EHANDBOOK Container-Build Demos

This repository contains a set of demos showcasing the capabilities of EHANDBOOK Container-Build (EHB-CB), a tool for automatically generating technical documentation in EHANDBOOK format from various source formats including Simulink models, C-Code, AUTOSAR specifications, and more.

Visit <http://ehandbook.etas.com> for a general overview on the ETAS EHANDBOOK solution.

Detailed information on EHANDBOOK Container-Build can be found in the documentation at <https://docs.etas.com/ehandbook/ehandbook/container_build.html>.

## Table of Contents

- [What Each Demo Contains](#what-each-demo-contains)
- [What You'll Need](#what-youll-need)
- [Product Evaluations](#product-evaluations)
- [Getting Started](#getting-started)
  - [Scenario A: Run Demos with CLI Product (Local)](#scenario-a-run-demos-with-cli-product-local)
  - [Scenario B: Run Demos with Cloud Service (SaaS)](#scenario-b-run-demos-with-cloud-service-saas)
- [Demo Overview](#demo-overview)
- [AI-Generated Code Notice](#ai-generated-code-notice)

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

## What You'll Need

Prerequisites depend on the scenario you choose:

### Scenario A: CLI Product (Local)

- ✅ **EHANDBOOK Container-Build tools** (latest version recommended)
- ✅ **EHANDBOOK-NAVIGATOR tool** for viewing generated EHB Containers (latest version recommended)
- ✅ **MATLAB/Simulink** (R2021a or later, optional for Simulink demos)
- ✅ **Git** (to clone the repository locally)
- ⏱️ **Estimated setup time:** 15-20 minutes

### Scenario B: Cloud Service (SaaS)

- ✅ **Git repository URL** for this demo repository (public or accessible from your cloud service environment)

## Product Evaluations

ETAS offers time-limited evaluation licenses for the local EHANDBOOK CLI products free of charge.

These evaluation licenses apply to local installations only (Scenario A: CLI Product). Cloud service usage (Scenario B, technically SaaS) is handled via your cloud service account/subscription and does not use local evaluation licenses.

For local CLI product evaluations, visit [https://license.etas.com](https://license.etas.com) and navigate to **Product Evaluation** or go to the [product evaluation page](https://license.etas.com/LandingPage/htm/evalproducts.jsp?lang=English) directly.

## Getting Started

Choose one of the following scenarios:

1. **Scenario A:** Run demos with local CLI product
2. **Scenario B:** Run demos with Cloud Service (SaaS)

### Scenario A: Run Demos with CLI Product (Local)

Use this scenario to run demos locally with full control and scriptable execution.

**What you need:**

1. A local clone of this repository
2. Installed EHANDBOOK CLI tools (and optional MATLAB/Simulink for Simulink demos)
3. A local `set_tool_paths.bat` configuration matching your environment

**Steps:**

1. Clone the repository:

```bash
git clone https://github.com/EHANDBOOK/ehandbook-cb-demos.git
cd ehandbook-cb-demos
```

2. Adapt `set_tool_paths.bat` to match your local environment.

Example configuration:

```batch
set EHB_CB_PATH=C:\ETAS\EHANDBOOK-Container-Build_13.5.0_Windows
set EHB_UGG_PATH=C:\ETAS\EHANDBOOK-Container-Build_13.5.0_Windows
set MATLAB_PATH=C:\Program Files\MATLAB\R2021a
```

To configure:

1. Open `set_tool_paths.bat` in a text editor
2. Update `EHB_CB_PATH` to point to your EHANDBOOK Container-Build installation directory
3. Update `EHB_UGG_PATH` to point to your EHANDBOOK-UGG installation directory (if applicable)
4. Update `MATLAB_PATH` to point to your MATLAB installation directory (if running Simulink demos)
5. Save the file

6. Open a command prompt or PowerShell terminal.
7. Run `set_tool_paths.bat`.
8. Navigate to the demo folder (e.g., `cd 01-C-Code/01-Basic`).
9. Execute the build script: `build.bat`.
10. Wait for the build to complete and find the generated output in the `Output/` folder within the demo directory.

Additional notes:

1. Run `set_tool_paths.bat` and `build.bat` in the **same** command prompt or PowerShell terminal session.
2. The environment variables set by `set_tool_paths.bat` are available **only for the current terminal session**.
3. If you open a new command prompt or PowerShell window, run `set_tool_paths.bat` again before executing `build.bat`.
4. Otherwise, the required tool paths may not be detected, and the container build may fail.

### Scenario B: Run Demos with Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### **Internal Container Build Workflow (Admin / Collaborator)**

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [EHANDBOOK Container Request](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `04-AUTOSAR/10-With-Simulink-FlexECU/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `04-AUTOSAR/10-With-Simulink-FlexECU/config.txt`

**Expected output:** The build generates an EHANDBOOK Container (.ehb) and a PDF when -pdf is specified in config.txt.

---

#### **Public Container Build Request (Anyone)**

The container generation is initiated by creating a GitHub Issue using the **EHANDBOOK Container Request** issue form.

Direct request link: [EHANDBOOK Container Request](https://github.com/EHANDBOOK/ehandbook-cb-demos/issues/new?template=ehb-container-request.yml)

> The issue form must be available from the repository's default branch and stored under `.github/ISSUE_TEMPLATE/`.

##### How to request a container

1. Open the **EHANDBOOK Container Request** issue form using the direct link above.
2. Enter the required **Demo folder**.
3. Optionally enter the **Configuration file**.
4. Confirm that the demo folder is a valid EHANDBOOK demo.
5. Click **Submit new issue**.

##### Example values

1. `Demo folder`:  
   `04-AUTOSAR/10-With-Simulink-FlexECU/Input`

2. `Configuration file`:  
   `04-AUTOSAR/10-With-Simulink-FlexECU/config.txt`

The **storage type** and **repository URL** are managed by the workflow and are not entered by the requester.

Internally, the trusted workflow uses:

- `storage_type`: `GIT`
- `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`

**Expected output:** The build generates an EHANDBOOK Container (.ehb) and a PDF when -pdf is specified in config.txt.

## Demo Overview

This repository is organized into demo folders, each showcasing specific features or use cases. Browse **35+ demos** organized by technology and use case below.

---

### 🧩 ASCET6 Demos

<details>
<summary><strong>ASCET6 Documentation (1 demo)</strong></summary>

**[Throttle-Valve-Control](./03-ASCET/02-Throttle-Valve-Control/README.md)** · `Advanced`  
Shows how to set up a directory-based EHANDBOOK Container-Build for an ASCET6 AXL model file.  
📦 Technologies: `ASCET` · 📁 Directory-Based  
[📖 Documentation](./03-ASCET/02-Throttle-Valve-Control/README.md) · [⬇️ Download .ehb](./03-ASCET/02-Throttle-Valve-Control/ThrottleValveControl_ehbcb_out/ThrottleValveControl.ehb)

</details>

---

### 🔀 Mixed Models & Advanced Integration

<details>
<summary><strong>ASCET + Simulink + C-Code (2 demos)</strong></summary>

**[ASCET-SL-CCode](./06-Mixed-Sources/01-ASCET-SL-CCode/README.md)** · `Advanced`  
Generates a single container from mixed sources: ASCET model, Simulink model, and C-Code.  
📦 Technologies: `ASCET`, `Simulink`, `C-Code` · 📁 Directory-Based  
[📖 Documentation](./06-Mixed-Sources/01-ASCET-SL-CCode/README.md) · [⬇️ Download .ehb](./06-Mixed-Sources/01-ASCET-SL-CCode/Output/06-Mixed-Sources/01-ASCET-SL-CCode.ehb)

**[ASCET-SL-CCode-Mixed](./06-Mixed-Sources/02-ASCET-SL-CCode-Mixed/README.md)** · `Advanced`  
Combines function specifications from ASCET, Simulink, and C-Code in a single build.  
📦 Technologies: `ASCET`, `Simulink`, `C-Code` · 📁 Directory-Based  
[📖 Documentation](./06-Mixed-Sources/02-ASCET-SL-CCode-Mixed/README.md) · [⬇️ Download .ehb](./06-Mixed-Sources/02-ASCET-SL-CCode-Mixed/Output/06-Mixed-Sources/02-ASCET-SL-CCode-Mixed.ehb)

</details>

---

### 🎯 Simulink Demos

<details>
<summary><strong>Simulink Projects & Models (10 demos)</strong></summary>

**[FlexECU](./02-Simulink/03-FlexECU/README.md)** · `Intermediate`  
A comprehensive example of generating complete ECU software documentation with 15 Simulink-based functions.  
📦 Technologies: `Simulink`, `FlexECU` · 📁 Directory-Based  
[📖 Documentation](./02-Simulink/03-FlexECU/README.md) · [⬇️ Download .ehb](./02-Simulink/03-FlexECU/Output/02-Simulink/03-FlexECU.ehb)

**[Basic](./02-Simulink/01-Basic/README.md)** · `Advanced`  
Demonstrates advanced Simulink processing features, including custom table configurations and Simulink library support.  
📦 Technologies: `Simulink` · 📁 Directory-Based  
[📖 Documentation](./02-Simulink/01-Basic/README.md) · [⬇️ Download .ehb](./02-Simulink/01-Basic/Output/02-Simulink/01-Basic.ehb)

**[Referenced-Models](./02-Simulink/07-Referenced-Models/README.md)** · `Intermediate`  
Shows how to handle Simulink projects containing referenced models.  
📦 Technologies: `Simulink` · 📁 Directory-Based  
[📖 Documentation](./02-Simulink/07-Referenced-Models/README.md) · [⬇️ Download .ehb](./02-Simulink/07-Referenced-Models/Output/02-Simulink/07-Referenced-Models.ehb)

**[Libraries](./02-Simulink/05-Libraries/README.md)** · `Intermediate`  
Demonstrates the handling and documentation of Simulink libraries with view configuration for know-how protection.  
📦 Technologies: `Simulink` · 📁 Directory-Based  
[📖 Documentation](./02-Simulink/05-Libraries/README.md) · [⬇️ Download .ehb](./02-Simulink/05-Libraries/Output/02-Simulink/05-Libraries.ehb)

**[View-Concept](./02-Simulink/08-View-Concept/README.md)** · `Advanced`  
Illustrates the Simulink View Concept to generate different EHANDBOOK variants from a single model, enabling know-how protection.  
📦 Technologies: `Simulink` · 📁 Directory-Based  
[📖 Documentation](./02-Simulink/08-View-Concept/README.md) · [⬇️ Download Internal](./02-Simulink/08-View-Concept/Output/02-Simulink/08-View-Concept_Internal.ehb) · [⬇️ Download External](./02-Simulink/08-View-Concept/Output/02-Simulink/08-View-Concept_External.ehb)

**[With-AsciiDoc-Japanese](./02-Simulink/10-With-AsciiDoc-Japanese/README.md)** · `Advanced`  
A Simulink demo featuring AsciiDoc and Japanese language support.  
📦 Technologies: `Simulink`, `AsciiDoc`, `Localization` · 📁 Directory-Based  
[📖 Documentation](./02-Simulink/10-With-AsciiDoc-Japanese/README.md) · [⬇️ Download .ehb](./02-Simulink/10-With-AsciiDoc-Japanese/Output/02-Simulink/10-With-AsciiDoc-Japanese.ehb)

**[With-MScript](./02-Simulink/11-With-MScript/README.md)** · `Intermediate`  
Uses a MATLAB script to generate input files for EHANDBOOK Container-Build from Simulink models.  
📦 Technologies: `MATLAB`, `Simulink` · 📁 Directory-Based  
[📖 Documentation](./02-Simulink/11-With-MScript/README.md) · [⬇️ Download .ehb](./02-Simulink/11-With-MScript/Output/02-Simulink/11-With-MScript.ehb)

**[MScript-DocBlocks](./02-Simulink/06-MScript-DocBlocks/README.md)** · `Advanced`  
Converts documentation blocks from m-scripts into AsciiDoc format.  
📦 Technologies: `MATLAB`, `AsciiDoc` · 📁 Directory-Based  
[📖 Documentation](./02-Simulink/06-MScript-DocBlocks/README.md) · [⬇️ Download .ehb](./02-Simulink/06-MScript-DocBlocks/Output/02-Simulink/06-MScript-DocBlocks.ehb)

**[UGG-iCB](./07-Advanced-Features/07-UGG-iCB/README.md)** · `Intermediate`  
Demonstrates the use of the Unified Graphics Generator (UGG) to speed up the EHB-CB process by pre-generating model graphics and data.  
📦 Technologies: `UGG`, `Mixed Models` · 📁 Directory-Based  
[📖 Documentation](./07-Advanced-Features/07-UGG-iCB/README.md) · [⬇️ Download .ehb](./07-Advanced-Features/07-UGG-iCB/Output_iCB/07-Advanced-Features/07-UGG-iCB.ehb)

**[Basic](./09-ASAM-Based/01-Simulink-Basic/README.md)** · `Beginner`  
Demonstrates generating an EHANDBOOK container using ASAM-based input formats for a single Simulink-based ECU function.  
📦 Technologies: `ASAM`, `Simulink` · 📋 ASAM-Based  
[📖 Documentation](./09-ASAM-Based/01-Simulink-Basic/README.md) · [⬇️ Download .ehb](./09-ASAM-Based/01-Simulink-Basic/Output/09-ASAM-Based/01-Simulink-Basic.ehb)

</details>

---

### 💻 C-Code Demos

<details>
<summary><strong>C-Code Documentation (3 demos)</strong></summary>

**[Basic](./01-C-Code/01-Basic/README.md)** · `Beginner`  
A fundamental example of documenting a simple C-code project.  
📦 Technologies: `C-Code` · 📁 Directory-Based  
[📖 Documentation](./01-C-Code/01-Basic/README.md) · [⬇️ Download .ehb](./01-C-Code/01-Basic/Output/01-C-Code/01-Basic.ehb)

**[References](./01-C-Code/03-References/README.md)** · `Intermediate`  
Demonstrates handling of code hierarchies and references in a C-Code project.  
📦 Technologies: `C-Code` · 📁 Directory-Based  
[📖 Documentation](./01-C-Code/03-References/README.md) · [⬇️ Download With Hierarchies](./01-C-Code/03-References/Output/01-C-Code/03-References_With_Hierarchies.ehb) · [⬇️ Download Without Hierarchies](./01-C-Code/03-References/Output/01-C-Code/03-References_Without_Hierarchies.ehb)

**[Custom-Block-Config](./01-C-Code/02-Custom-Block-Config/README.md)** · `Intermediate`  
Demonstrates customizing of block visualization in a C-Code project.  
📦 Technologies: `C-Code` · 📁 Directory-Based  
[📖 Documentation](./01-C-Code/02-Custom-Block-Config/README.md) · [⬇️ Download .ehb](./01-C-Code/02-Custom-Block-Config/Output/Demo_EHBCB_DirBased_CCODE_ConfigExample.ehb)

</details>

---

### 🚗 AUTOSAR Demos

<details>
<summary><strong>AUTOSAR Classic Architecture (10 demos)</strong></summary>

**[Basic](./04-AUTOSAR/01-Basic/README.md)** · `Advanced`  
Directory-based build for AUTOSAR Classic architecture with ASCET models for Software Components.  
📦 Technologies: `AUTOSAR`, `ASCET` · 📁 Directory-Based  
[📖 Documentation](./04-AUTOSAR/01-Basic/README.md) · [⬇️ Download .ehb](./04-AUTOSAR/01-Basic/Output/04-AUTOSAR/01-Basic.ehb)

**[With-Simulink](./04-AUTOSAR/09-With-Simulink/README.md)** · `Advanced`  
Documents AUTOSAR Classic SWC with Simulink implementation.  
📦 Technologies: `AUTOSAR`, `Simulink` · 📁 Directory-Based  
[📖 Documentation](./04-AUTOSAR/09-With-Simulink/README.md) · [⬇️ Download .ehb](./04-AUTOSAR/09-With-Simulink/Output/04-AUTOSAR/09-With-Simulink.ehb)

**[With-C-Code](./04-AUTOSAR/07-With-C-Code/README.md)** · `Advanced`  
Documents an AUTOSAR Classic system from RTA-CAR Starter Kit with C-Code implementations.  
📦 Technologies: `AUTOSAR`, `C-Code` · 📁 Directory-Based  
[📖 Documentation](./04-AUTOSAR/07-With-C-Code/README.md) · [⬇️ Download .ehb](./04-AUTOSAR/07-With-C-Code/Output/04-AUTOSAR/07-With-C-Code.ehb)

**[With-C-Code-Config](./04-AUTOSAR/08-With-C-Code-Config/README.md)** · `Advanced`  
Detailed example of C-Code configuration to visually enhance AUTOSAR RTE API calls with custom icons.  
📦 Technologies: `AUTOSAR`, `C-Code` · 📁 Directory-Based  
[📖 Documentation](./04-AUTOSAR/08-With-C-Code-Config/README.md) · [⬇️ Download .ehb](./04-AUTOSAR/08-With-C-Code-Config/Output/04-AUTOSAR/08-With-C-Code-Config.ehb)

**[Excerpt](./04-AUTOSAR/02-Excerpt/README.md)** · `Intermediate`  
Documents an excerpt or subset of a larger AUTOSAR Classic system.  
📦 Technologies: `AUTOSAR`, `ASCET` · 📁 Directory-Based  
[📖 Documentation](./04-AUTOSAR/02-Excerpt/README.md) · [⬇️ Download .ehb](./04-AUTOSAR/02-Excerpt/Output/04-AUTOSAR/02-Excerpt.ehb)

**[Excerpt-AR-Only](./04-AUTOSAR/03-Excerpt-AR-Only/README.md)** · `Intermediate`  
Documents only AUTOSAR architecture from ARXML files without implementation details.  
📦 Technologies: `AUTOSAR` · 📁 Directory-Based  
[📖 Documentation](./04-AUTOSAR/03-Excerpt-AR-Only/README.md) · [⬇️ Download .ehb](./04-AUTOSAR/03-Excerpt-AR-Only/Output/04-AUTOSAR/03-Excerpt-AR-Only.ehb)

**[FlexECU-Only](./04-AUTOSAR/04-FlexECU-Only/README.md)** · `Intermediate`  
Two-step workflow using -ar2ehbcbinput flag to document AUTOSAR architecture only.  
📦 Technologies: `AUTOSAR` · 📁 Directory-Based  
[📖 Documentation](./04-AUTOSAR/04-FlexECU-Only/README.md) · [⬇️ Download .ehb](./04-AUTOSAR/04-FlexECU-Only/Output/04-AUTOSAR/04-FlexECU-Only.ehb)

**[With-Simulink-FlexECU](./04-AUTOSAR/10-With-Simulink-FlexECU/README.md)** · `Intermediate`  
Generates container for AUTOSAR software component specified by a Simulink model.  
📦 Technologies: `AUTOSAR`, `Simulink` · 📁 Directory-Based  
[📖 Documentation](./04-AUTOSAR/10-With-Simulink-FlexECU/README.md) · [⬇️ Download .ehb](./04-AUTOSAR/10-With-Simulink-FlexECU/Output/04-AUTOSAR/10-With-Simulink-FlexECU.ehb)

**[RTA-RTE-Only](./04-AUTOSAR/05-RTA-RTE-Only/README.md)** · `Intermediate`  
Two-step workflow to document AUTOSAR architecture from RTA-RTE case study.  
📦 Technologies: `AUTOSAR` · 📁 Directory-Based  
[📖 Documentation](./04-AUTOSAR/05-RTA-RTE-Only/README.md) · [⬇️ Download .ehb](./04-AUTOSAR/05-RTA-RTE-Only/Output/04-AUTOSAR/05-RTA-RTE-Only.ehb)

**[Signal-Mapping](./04-AUTOSAR/06-Signal-Mapping/README.md)** · `Advanced`  
Establishes and visualizes connections between components from different domains using component mapping.  
📦 Technologies: `AUTOSAR` · 📁 Directory-Based  
[📖 Documentation](./04-AUTOSAR/06-Signal-Mapping/README.md) · [⬇️ Download .ehb](./04-AUTOSAR/06-Signal-Mapping/Output/04-AUTOSAR/06-Signal-Mapping.ehb)

</details>

---

### 📝 Documentation & Customization

<details>
<summary><strong>AsciiDoc, Localization & Table of Contents (3 demos)</strong></summary>

**[Basic](./05-AsciiDoc/01-Basic/README.md)** · `Beginner`  
Showcases generating an EHANDBOOK container from textual content written in AsciiDoc format.  
📦 Technologies: `AsciiDoc` · 📁 Directory-Based  
[📖 Documentation](./05-AsciiDoc/01-Basic/README.md) · [⬇️ Download .ehb](./05-AsciiDoc/01-Basic/Output/05-AsciiDoc/01-Basic.ehb)

**[Language-Support](./07-Advanced-Features/05-Language-Support/README.md)** · `Intermediate`  
Illustrates support for multiple languages in the output.  
📦 Technologies: `Customization`, `Localization` · 📁 Directory-Based  
[📖 Documentation](./07-Advanced-Features/05-Language-Support/README.md) · [⬇️ Download .ehb](./07-Advanced-Features/05-Language-Support/Output/07-Advanced-Features/05-Language-Support.ehb)

**[Custom-Table-of-Contents](./07-Advanced-Features/01-Custom-Table-of-Contents/README.md)** · `Intermediate`  
Shows how to create custom table of contents structures.  
📦 Technologies: `Customization` · 📁 Directory-Based  
[📖 Documentation](./07-Advanced-Features/01-Custom-Table-of-Contents/README.md) · [⬇️ Download .ehb](./07-Advanced-Features/01-Custom-Table-of-Contents/Output/07-Advanced-Features/01-Custom-Table-of-Contents.ehb)

**[Nested-ToC](./07-Advanced-Features/06-Nested-ToC/README.md)** · `Intermediate`  
Creates deeply nested, hierarchical Tables of Contents using a tocs.yaml file.  
📦 Technologies: `Customization` · 📁 Directory-Based  
[📖 Documentation](./07-Advanced-Features/06-Nested-ToC/README.md) · [⬇️ Download .ehb](./07-Advanced-Features/06-Nested-ToC/Output/07-Advanced-Features/06-Nested-ToC.ehb)

</details>

---

### 🔐 Security & Features

<details>
<summary><strong>Container Encryption (2 demos)</strong></summary>

**[Encryption-Simple](./07-Advanced-Features/04-Encryption-Simple/README.md)** · `Beginner`  
This demo shows how to generate and encrypt an EHANDBOOK container using a plaintext password supplied directly in the build script with the `-epwd` flag.  
📦 Technologies: `Encryption` · 📁 Directory-Based  
[📖 Documentation](./07-Advanced-Features/04-Encryption-Simple/README.md)

**[Encryption-Full](./07-Advanced-Features/03-Encryption-Full/README.md)** · `Intermediate`  
This demo shows how to generate and encrypt an EHANDBOOK container by reading the password from a text file using the `-epwdf` flag, a more secure approach for production builds.  
📦 Technologies: `Encryption` · 📁 Directory-Based  
[📖 Documentation](./07-Advanced-Features/03-Encryption-Full/README.md)

</details>

---

### 📋 ASAM-Based Demos

<details>
<summary><strong>ASAM-Based Workflows (3 demos)</strong></summary>

**[With-ASCET](./09-ASAM-Based/03-AUTOSAR-With-ASCET/README.md)** · `Advanced`  
ASAM-based build for AUTOSAR Classic architecture with ASCET models for Software Components.  
📦 Technologies: `ASAM`, `AUTOSAR`, `ASCET` · 📋 ASAM-Based  
[📖 Documentation](./09-ASAM-Based/03-AUTOSAR-With-ASCET/README.md) · [⬇️ Download .ehb](./09-ASAM-Based/03-AUTOSAR-With-ASCET/Output/09-ASAM-Based/03-AUTOSAR-With-ASCET.ehb)

**[With-Simulink](./09-ASAM-Based/04-AUTOSAR-With-Simulink/README.md)** · `Advanced`  
ASAM-based build for AUTOSAR Classic architecture with Simulink models for Software Components.  
📦 Technologies: `ASAM`, `AUTOSAR`, `Simulink` · 📋 ASAM-Based  
[📖 Documentation](./09-ASAM-Based/04-AUTOSAR-With-Simulink/README.md) · [⬇️ Download .ehb](./09-ASAM-Based/04-AUTOSAR-With-Simulink/Output/09-ASAM-Based/04-AUTOSAR-With-Simulink.ehb)

**[With-PDF-FlexECU](./09-ASAM-Based/02-ASCET-With-PDF-FlexECU/README.md)** · `Advanced`  
Generates an EHANDBOOK Container and PDF for a complex multi-component project with both ASCET and Simulink models.  
📦 Technologies: `ASAM`, `ASCET`, `Simulink`, `PDF` · 📋 ASAM-Based  
[📖 Documentation](./09-ASAM-Based/02-ASCET-With-PDF-FlexECU/README.md) · [⬇️ Download .ehb](./09-ASAM-Based/02-ASCET-With-PDF-FlexECU/Output/09-ASAM-Based/02-ASCET-With-PDF-FlexECU.ehb)

</details>

---

### 🔧 Add-On Tools

<details>
<summary><strong>Toolbox Integrations (2 demos)</strong></summary>

**[ASCET-Toolbox](./08-Toolbox-AddOns/01-ASCET-Toolbox/README.md)** · `Intermediate`  
Documents the EHANDBOOK Container-Build Add-On for ASCET Toolbox.
📦 Technologies: `ASCET` · 🔧 Add-On  
[📖 Documentation](./08-Toolbox-AddOns/01-ASCET-Toolbox/README.md)

**[Simulink-Toolbox](./08-Toolbox-AddOns/02-Simulink-Toolbox/README.md)** · `Intermediate`  
Demonstrates the EHANDBOOK Container-Build Add-On for Simulink Toolbox, showing how to generate documentation directly from Simulink models via the integrated toolbox.  
📦 Technologies: `Simulink` · 🔧 Add-On  
[📖 Documentation](./08-Toolbox-AddOns/02-Simulink-Toolbox/README.md)

</details>

## AI-generated code notice

Use of generative AI in this repository:

The repository partially contains AI-generated code by using GitHub Copilot Business.

This notice needs to remain attached to any reproduction of this repository.
