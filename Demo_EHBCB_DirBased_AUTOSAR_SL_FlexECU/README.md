# Demo: Directory-based EHB-CB for an AUTOSAR Simulink Component

**Objective:** This demo illustrates how to use the directory-based EHANDBOOK Container-Build to generate a container for an AUTOSAR (Classic) software component specified by a Simulink model.

---

## ✨ Features Showcased

* Directory-based input structure for an AUTOSAR component.
* Processing of a Simulink model (`.slx`) that uses the AUTOSAR Blockset.
* Processing of AUTOSAR software components and compositions provided in `.arxml` files.

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license for the Simulink model converter.
    * MATLAB installation with the following apps:
        * AUTOSAR Blockset
        * Embedded Coder
        * Simulink Coder
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, an `Output/` folder will be created.
* Navigate into the `Output/` folder and open the generated EHANDBOOK file.

---

## ⚙️ Under the Hood

This demo shows how to build a container for an AUTOSAR software component (`Epm`) that is modeled in Simulink.

### Directory Structure

* **`Input/`**: This is the main input directory for the build.
  * **`CPT_Epm/`**: Contains the Simulink model (`.slx` file) for the `Epm` component.
  * **`*.arxml`**: A set of AUTOSAR XML files that describe the software components, compositions, data types, and interfaces. These are processed by the build to understand the AUTOSAR architecture.
  * **`Documentation.adoc`**: An AsciiDoc file for including additional documentation.
* **`build.bat`**: The script that runs the directory-based EHANDBOOK Container-Build process. The build is driven by the file types and directory structure found in the input folder.

### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU" ^
-gensvg
```

---

## ℹ️ Additional Information

For more details on working with AUTOSAR components in Simulink, refer to the official MathWorks documentation:

1. **Install MATLAB Apps:** Ensure you have the **AUTOSAR Blockset**, **Embedded Coder**, and **Simulink Coder** installed in your MATLAB environment.

2. **Model Import and Configuration:** The following links provide guidance on importing and configuring AUTOSAR models in Simulink:
    * [Create an AUTOSAR Software Component in Simulink](https://in.mathworks.com/help/autosar/ug/create-an-autosar-software-component-in-simulink.html#mw_1a65cc20-5f3b-469d-a7bc-55c987033eef)
    * [Configure AUTOSAR Ports Using Simulink Bus Ports](https://in.mathworks.com/help/autosar/ug/configure-autosar-ports-using-sl-bus-ports.html)
    * [Configure AUTOSAR Adaptive Elements and Properties](https://in.mathworks.com/help/autosar/ug/configure-autosar-adaptive-elements-and-properties.html)

3. **Example Model:** To explore a complete example of an AUTOSAR software component, run the following command in the MATLAB command window:

    ```matlab
    openExample('autosar_swc')
    ```
