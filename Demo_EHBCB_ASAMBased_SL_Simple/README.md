# Demo: ASAM-based EHB-CB for a single Simulink-based ECU function

**Objective:** This demo illustrates how to generate an EHANDBOOK Container using ASAM-based input formats (CCX, FSX, MDX) for a single ECU function that is specified by a Simulink model.

---

## ✨ Features Showcased

* ASAM-based input data structure (CCX, MDX, FSX)
* Referencing and processing of Simulink model in .mdl file (can also be .slx)
* Referencing and processing of images included in document text in .eps and .svg format

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with suitable licenses for ASAM-based input formats and Simulink model converter
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder.
* Open the generated EHANDBOOK file names `Demo_EHBCB_ASAMBased_SL_Simple.ehb`

---

## ⚙️ Under the Hood

[This is the core learning section. Explain *how* the demo works by breaking down its components. Be specific and use code snippets.]

### Directory Structure

* **`Input/`**: This directory contains all the source artifacts for the build.
  * **`asamCC.ccx`**:  The ASAM‑CC XML “container catalog” file. It defines the project’s table of contents and function components, and links them to their FSX/MDX files and model artifacts so EHANDBOOK Container‑Build can assemble the container.
  * **`Iac_mdl/`**: This folder contains the Simulink model and its specific documentation assets.
    * `Iac.mdl`: The Simulink model file.
    * `_doc/`: A directory intended for documentation assets related to the model.
    * `_pic/`: A directory for picture or image files that can be referenced in the documentation.
* **`Output/`**: This is the destination folder where the generated EHANDBOOK will be saved after the build process.
* **`build.bat`**: This script runs the EHANDBOOK Container-Build process. It's powerful because it requires no separate configuration file; the build is entirely controlled by the file types and the directory structure found in the `Input` folder.

### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input\\asamCC.ccx" ^
-o ".\\Output" ^
-n "Demo_EHBCB_ASAMBased_SL_Simple" ^
-nomatlab ^
-gensvg
```
