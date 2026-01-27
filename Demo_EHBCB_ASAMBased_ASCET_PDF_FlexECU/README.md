# Demo: ASAM-based EHB-CB for a multi-component ASCET & Simulink project with PDF output

**Objective:** This demo illustrates how to generate an EHANDBOOK Container and a corresponding PDF document for a complex ECU project. The project is based on ASAM standard input formats (CCX, FSX, MDX) and includes multiple function components specified in both ASCET and Simulink.

---

## ✨ Features Showcased

* ASAM-based input data structure for a large, multi-component project
* Processing of both ASCET and Simulink models within a single build
* Generation of a PDF document from the container content
* Application of custom styling to the PDF output

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with suitable licenses for ASAM-based input formats, ASCET and Simulink model converters, and PDF generator.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder (it will be created if it doesn't exist).
* You will find the generated EHANDBOOK container (`.ehb` file) and a `document.pdf` file.

---

## ⚙️ Under the Hood

This demo showcases a more complex build scenario compared to a single-function model.

### Directory Structure

* **`Input/`**: This directory contains all the source artifacts for the build, structured by component.
  * **`asamCC_ASCET.ccx`**: The main ASAM-CC XML “container catalog” file. It defines the project’s structure, lists all function components, and links to their respective models and documentation, enabling EHANDBOOK Container-Build to assemble the complete container.
  * **Component Folders (`Afr/`, `Fmc/`, `Iac/`, etc.)**: Each folder represents a different function component and contains its specific artifacts, such as ASCET or Simulink models and related documentation files. This modular structure is typical for large-scale ECU projects.
* **`styling/`**: This directory contains configuration files that define the visual style and layout of the generated PDF document, allowing for customization of fonts, colors, and branding.
* **`Output/`**: This is the destination folder where the generated EHANDBOOK container and PDF document will be saved.
* **`build.bat`**: This script executes the EHANDBOOK Container-Build process. The build is driven by the content and structure of the `Input/` directory and the main `.ccx` file, demonstrating a configuration-by-convention approach.

### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input\\asamCC_ASCET.ccx" ^
-o ".\\Output" ^
-n "Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU" ^
-gensvg ^
-nomatlab ^
-styling ".\\styling"
```
