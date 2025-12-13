# Demo: Directory-based EHB-CB with dSPACE TargetLink Models

**Objective:** This demo illustrates how EHANDBOOK Container-Build supports Simulink models that contain blocks from the dSPACE TargetLink library.

---

## ✨ Features Showcased

* Directory-based input structure.
* Integration of a Simulink model (`.slx`) that uses the **dSPACE TargetLink blockset**.
* Use of the `-simlib` command-line argument to provide the path to the TargetLink library (`tllib.slx`).
* Requirement of a live MATLAB connection to correctly render the graphics for TargetLink blocks.
* Application of a view configuration (`-simulinkview`) to hide the internal details of library blocks, which is a recommended practice for know-how protection.

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license for the Simulink converter.
    * A licensed installation of MATLAB.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Configuration:**
    * Before running, open the `build.bat` script in a text editor.
    * Verify that the `MATLAB_PATH` variable points to your correct MATLAB installation directory (e.g., `C:\Program Files\MATLAB\R2021a`).

3. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder.
* Open the generated `EHB_Demo_DirBased_TargetLink_Library.ehb` file.
* In the function diagram, you will see the model rendered with the specific look and feel of TargetLink blocks, demonstrating that EHB-CB can correctly process and display them.

---

## ⚙️ Under the Hood

This demo's configuration is key to enabling TargetLink support. EHB-CB leverages its generic Simulink library support to handle the custom TargetLink blockset.

### Directory Structure

* **`Input/TargetLink/`**: Contains the primary model (`tllib.slx`) that is built from TargetLink blocks, along with its AsciiDoc documentation (`TargetLink.adoc`).
* **`simlib/`**: This crucial directory contains the TargetLink library file (`tllib.slx`). The EHB-CB build process uses this library to understand how to render the custom blocks used in the main model.
* **`configuration/`**: Contains `SimulinkViewConfig.json`, which is used to hide the underlying implementation of the TargetLink library blocks, presenting them as clean, atomic blocks in the final handbook.
* **`Output/`**: The destination for the generated EHANDBOOK container.

### Build Script: `build.bat`

The build script highlights the essential arguments for TargetLink support:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_TargetLink_Library" ^
-simlib ".\simlib,%MATLAB_PATH%\toolbox\simulink" ^
-simulinkview ".\configuration\SimulinkViewConfig.json" ^
-viewtype "GlobalView" ^
-gensvg
```

* `-simlib ".\\simlib,..."`: This argument tells EHB-CB where to find the necessary Simulink libraries. By pointing it to the `simlib` folder, we enable it to find `tllib.slx` and correctly render the TargetLink blocks.
* **MATLAB Connection**: The script sets a `MATLAB_PATH` and uses it in the build. A connection to MATLAB is **required** for generating the graphics of the TargetLink blocks.
* `-simulinkview` and `-viewtype`: These arguments apply a predefined view that prevents the build process from showing the detailed subsystems inside the TargetLink library blocks, which is a recommended best practice.
