# Demo: ASCET Features Showcase

**Objective:** This demo illustrates how to use the directory-based EHANDBOOK Container-Build to generate a container from an ASCET model, showcasing specific ASCET language features.

---

## ✨ Features Showcased

* Directory-based input structure for ASCET models.
* Processing of ASCET model files (`.axl`).
* Use of Excel files (`.xlsx`) to define function interfaces (signals, parameters).
* ASCET-specific features:
  * Array handling and manipulation
  * Virtual connectors for component communication
* Automatic generation of technical documentation from ASCET specifications.

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license for the ASCET converter.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder.
* Open the generated EHANDBOOK file `Demo_EHBCB_ASCET_Features.ehb` to explore the ASCET specifications and their technical documentation.

---

## ⚙️ Under the Hood

This demo showcases how EHANDBOOK Container-Build automatically processes ASCET models and generates comprehensive technical documentation from them.

### Directory Structure

* **`Input/`**: This directory contains all the source artifacts.
  * **`ArrayVirtualCon/`**: A folder containing ASCET model artifacts demonstrating array and virtual connector features.
    * `Module2.axl`: The ASCET model file containing the function specifications.
    * `Func_InOut.xlsx`: An Excel file defining the function's interface (input/output signals and parameters).
* **`Output/`**: This is the destination folder where the generated EHANDBOOK will be saved.
* **`build.bat`**: This script runs the EHANDBOOK Container-Build process, automatically detecting and processing the ASCET model and its associated files.

### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_ASCET_Features"
```

* `-i ".\Input"`: Specifies the input directory containing the ASCET model artifacts.
* `-o ".\Output"`: Specifies the output directory for the generated EHANDBOOK container.
* `-n "Demo_EHBCB_ASCET_Features"`: Sets the name of the output file.

The directory-based approach allows EHANDBOOK Container-Build to automatically detect the ASCET model file and its supporting artifacts and generate documentation.
