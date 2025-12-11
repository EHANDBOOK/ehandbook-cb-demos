# Demo: Directory-based EHB-CB with an AUTOSAR Excerpt

**Objective:** This demo illustrates how the directory-based EHANDBOOK Container-Build can be used to document an *excerpt* or subset of a larger AUTOSAR Classic system, using ASCET models for the Software Component (SWC) implementations.

---

## ✨ Features Showcased

* **Directory-based Build** for an AUTOSAR project.
* **Documentation of a System Subset:** Demonstrates that you do not need the complete set of system artifacts; EHB-CB can generate a valid handbook from only a selection of SWCs and their corresponding architecture descriptions.
* **AUTOSAR Classic Integration:** The build automatically discovers and processes the provided `.arxml` files.
* **ASCET Models for SWCs:** The logic for the included SWCs is provided by ASCET models (`.axl`).

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with suitable licenses for the ASCET and AUTOSAR converters.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build_excerpt.bat` script.

---

## 🔬 Explore the Output

* After the build completes, a `FlexECU_Dir_AUTOSAR_excerpt.ehb` file will be created in this directory.
* Open the EHANDBOOK file. You will find a handbook that contains *only* the software components that were included in the `FlexECU_Dir_AUTOSAR_excerpt` input folder, rather than the full FlexECU system.

---

## ⚙️ Under the Hood

This demo highlights the flexibility of the directory-based build. By simply controlling which files are present in the input directory, you can control the scope of the generated documentation.

### Directory & File Structure

* **`FlexECU_Dir_AUTOSAR_excerpt/`**: This is the main input directory. It is a slimmed-down version of a full project directory.
  * **`.arxml` files:** Contains the necessary AUTOSAR architecture files (`Compositions.arxml`, `Interfaces.arxml`, etc.).
  * **Component Folders (e.g., `CPT_Afr/`, `CPT_Tqs/`):** Contains a *subset* of the component folders from the full FlexECU demo. Each folder includes the ASCET model (`.axl`) that implements the SWC's logic.
* **`configuration/`**: Contains various JSON files for customizing the output.
* **`etas-styling/`**: Provides custom branding and styling.

### Build Script: `build_excerpt.bat`

The build script is a standard directory-based build command. The key is that the input directory it points to (`FlexECU_Dir_AUTOSAR_excerpt`) only contains a subset of the project files.

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i "FlexECU_Dir_AUTOSAR_excerpt" ^
-o "." ^
-n "FlexECU_Dir_AUTOSAR_excerpt" ^
...
```

* `-i "FlexECU_Dir_AUTOSAR_excerpt"`: EHB-CB scans this directory and builds a handbook based *only* on the artifacts it finds within. If a component's folder or its description in an `.arxml` file is missing, it is simply excluded from the final output. This provides an easy way to generate focused documentation for specific parts of a large system.
