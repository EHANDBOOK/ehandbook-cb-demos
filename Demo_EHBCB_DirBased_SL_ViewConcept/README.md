# Demo: Directory-based EHB-CB with Simulink View Concept

**Objective:** This demo illustrates how to use the Simulink View Concept to generate different EHANDBOOK variants from a single Simulink model. This is a powerful feature for know-how protection, allowing you to hide the internal implementation of specific blocks when sharing the handbook with external partners.

---

## ✨ Features Showcased

* Directory-based input structure.
* **Simulink View Concept** to create different representations of a model.
* Use of the `-viewtype` command-line argument to select a specific view.
* Generation of two EHANDBOOK containers from the same source:
  * An "External" view with hidden/protected content.
  * A "Default" view showing the full implementation.

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license for the Simulink converter.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script. The script will run the build process twice to generate both handbook variants.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder. You will find two EHANDBOOK files:
    1. `Demo_EHBCB_DirBased_SL_ViewConcept_External.ehb`
    2. `Demo_EHBCB_DirBased_SL_ViewConcept_Internal.ehb`

* Open both files and compare them.
* In `Demo_EHBCB_DirBased_SL_ViewConcept_External.ehb`, navigate to the function diagram. You will see that the "Controller" block is shown as an empty black box, hiding its internal logic.
* In `Demo_EHBCB_DirBased_SL_ViewConcept_Internal.ehb`, the same "Controller" block will show its complete internal implementation.

---

## ⚙️ Under the Hood

This demo highlights how a single command-line argument can fundamentally change the content of the generated EHANDBOOK based on predefined view configurations.

### Directory Structure

* **`Input/`**:
  * `SLviewDemo.slx`: The source Simulink model containing the full implementation.
  * `Interface.xlsx`: Excel file defining the function's interface.
  * `SLviewDemo.adoc`: AsciiDoc file for textual documentation.
  * **`SLviewDemo_VCFDB/`**: This directory acts as the "View Configuration Database". It contains several XML files that define the different views (e.g., which blocks to show, hide, or treat as black boxes).

### Build Script: `build.bat`

The `build.bat` script executes the container build twice with different parameters to create the two variants:

**1. External View Build:**

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_ViewConcept_External" ^
-viewtype "EXTERNAL" ^
-gensvg 
```

* The key parameter here is `-viewtype "EXTERNAL"`. This tells EHB-CB to apply the view named "EXTERNAL" as defined in the configuration files found in the `SLviewDemo_VCFDB/` directory. This results in a handbook suitable for external parties where intellectual property is protected.

**2. Internal View Build:**

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_ViewConcept_Internal" ^
-viewtype "INTERNAL" ^
-gensvg 
```

* This second run uses `-viewtype "INTERNAL"`. EHB-CB generates a view that shows the complete, detailed implementation of the model, suitable for internal developers and documentation.
