# Demo: ASAM-based EHB-CB with AUTOSAR Classic and Simulink

**Objective:** This demo illustrates how to use the ASAM-based EHANDBOOK Container-Build to generate a container from an AUTOSAR Classic architecture, where the Software Components (SWCs) are implemented as Simulink models.

---

## ✨ Features Showcased

* **ASAM-based Build:** The build process is initiated using a `.ccx` file, which defines the project structure and components.
* **AUTOSAR Classic Integration:** The demo processes `.arxml` files to understand the AUTOSAR architecture, including compositions, components, and interfaces.
* **Simulink Models for SWCs:** The actual logic for the AUTOSAR Software Components is provided by Simulink models (`.mdl`).
* Advanced configuration options, including:
  * Custom styling (`-styling`).
  * Skipping root-level blocks to remove unnecessary model hierarchies and ease navigation (`-rootlevel`).
  * Amending names of model elements to match A2L label names (`-labelamendment`).

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with suitable licenses for the Simulink and AUTOSAR converters.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, a `Demo_EHBCB_ASAMBased_AUTOSAR_SL.ehb` file will be created in the `Output` directory.
* Open the EHANDBOOK file to explore the documented AUTOSAR system. You will see the software components and their underlying Simulink model implementations integrated into a single, navigable handbook.

---

## ⚙️ Under the Hood

This demo showcases a powerful integration of AUTOSAR and Simulink using the ASAM-based build mode of EHB-CB.

### Directory & File Structure

* **`Input/`**: This is the main input directory, structured according to ASAM standards.
  * `asamCC.ccx`: The central ASAM Container-Build configuration file. This file is the main input to the `eHandbookCB.exe` call and references all other necessary files.
  * **`_global_arxml/`**: This directory contains the AUTOSAR `.arxml` files that describe the system's software architecture, compositions, components, and interfaces.
  * **Component Folders (e.g., `Fmc/`, `Tqs/`):** Each folder represents a function or component and contains the corresponding Simulink model (`.mdl`) that implements the logic for an AUTOSAR SWC.
* **`configuration/`**: Contains various JSON files for customizing the output, such as `rootlevel.json` to control the hierarchy and `labelamendment.json` to modify labels.
* **`styling/`**: Provides custom branding and styling for the generated EHANDBOOK container.
* **`FlexECU_Simulink_Library/`**: Contains Simulink library files, provided via the `-simlib` argument.

### Build Script: `build.bat`

The build script invokes EHB-CB in ASAM mode by pointing directly to the `.ccx` file.

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input\\asamCC.ccx" ^
-o ".\\Output" ^
-n "Demo_EHBCB_ASAMBased_AUTOSAR_SL" ^
-simlib "FlexECU_Simulink_Library" ^
-nomatlab ^
-gensvg ^
-styling ".\\styling" ^
-rootlevel ".\\configuration\\rootlevel.json" ^
-labelamendment ".\\configuration\\labelamendment.json"
```

* `-i ".\\Input\\asamCC.ccx"`: This is the key argument that triggers the **ASAM-based build**. Instead of a directory, the input is a single configuration file.
* EHB-CB parses the `.ccx` file, which in turn points to the `.arxml` files and the Simulink models, allowing it to build a complete picture of the AUTOSAR system and its implementation.
