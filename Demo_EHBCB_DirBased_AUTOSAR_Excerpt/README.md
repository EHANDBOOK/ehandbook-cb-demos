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
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, a `Demo_EHBCB_DirBased_AUTOSAR_Excerpt.ehb` file will be created in the `Output` directory.
* Open the EHANDBOOK file. You will find a handbook that contains *only* the software components that were included in the `Input` folder, rather than the full FlexECU system.

---

## ⚙️ Under the Hood

This demo highlights the flexibility of the directory-based build. By simply controlling which files are present in the input directory, you can control the scope of the generated documentation.

### Directory & File Structure

* **`Input/`**: This is the main input directory. It is a slimmed-down version of a full project directory.
  * **`.arxml` files:** Contains the necessary AUTOSAR architecture files (`Compositions.arxml`, `Interfaces.arxml`, etc.).
  * **Component Folders (e.g., `CPT_Afr/`, `CPT_Tqs/`):** Contains a *subset* of the component folders from the full FlexECU demo. Each folder includes the ASCET model (`.axl`) that implements the SWC's logic.
* **`configuration/`**: Contains various JSON files for customizing the output.
* **`styling/`**: Provides custom branding and styling.

### Build Script: `build.bat`

The build script is a standard directory-based build command. The key is that the input directory it points to only contains a subset of the project files.

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_Excerpt" ^
-simlib "FlexECU_Simulink_Library" ^
-nomatlab ^
-gensvg ^
-styling ".\\styling" ^
-rootlevel ".\\configuration\\rootlevel.json" ^
-labelamendment ".\\configuration\\labelamendment.json"
```

* `-i "Input"`: EHB-CB scans this directory and builds a handbook based *only* on the artifacts it finds within. If a component's folder or its description in an `.arxml` file is missing, it is simply excluded from the final output. This provides an easy way to generate focused documentation for specific parts of a large system.
