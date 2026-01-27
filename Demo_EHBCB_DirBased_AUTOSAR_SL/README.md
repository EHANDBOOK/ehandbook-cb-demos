# Demo: Directory-based EHB-CB with AUTOSAR and a Simulink Implementation

**Objective:** This demo illustrates how to use the directory-based EHANDBOOK Container-Build to document an AUTOSAR Classic Software Component (SWC) whose behavior is implemented in a Simulink model.

---

## ✨ Features Showcased

* **Directory-based Build** for an AUTOSAR project.
* **Simulink Implementation of an SWC:** The demo uses a Simulink model (`.slx`) to define the logic of the `ThrottlePositionController` SWC.
* **AUTOSAR Architecture from ARXML:** The AUTOSAR composition and component descriptions are provided by `.arxml` files.
* **`-autosarcomposition` flag:** Use of a specific flag to tell EHB-CB which composition to use as the entry point for the documentation.

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

* After the build completes, a `Demo_EHBCB_DirBased_AUTOSAR_SL.ehb` file will be created in the `Output` directory.
* Open the EHANDBOOK file. You will see the `ThrottlePositionController` software component documented.
* Navigate to the function diagram. You will see the detailed implementation of the controller, which has been generated directly from the provided Simulink model.

---

## ⚙️ Under the Hood

This demo shows how EHB-CB automatically links an AUTOSAR architecture described in `.arxml` with an implementation provided by a Simulink model.

### Directory & File Structure

* **`ControllerExample/`**: This is the main input directory for the build.
  * **`Controller/`**: This subdirectory contains the implementation.
    * `Controller.slx`: The Simulink model that implements the throttle controller logic.
    * `ThrottlePositionControlComposition_updated.arxml`: An updated `.arxml` file that may contain additional details.
* **`ThrottlePositionControlComposition.arxml`**: Located at the root of the demo, this file likely contains the main AUTOSAR composition definition.

### Build Script: `build.bat`

The build script uses a standard directory-based command, but with a key flag for AUTOSAR projects.

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_SL" ^
-gensvg ^
-nomatlab ^
-autosarcomposition "ThrottlePositionControlComposition"
```

* `-i "ControllerExample"`: Specifies the input directory. EHB-CB scans this folder and finds both the `.slx` and `.arxml` files.
* `-autosarcomposition "ThrottlePositionControlComposition"`: This important flag tells EHB-CB which AUTOSAR composition to use as the top-level entry point for the documentation. EHB-CB then finds the SWCs within that composition (in this case, the `ThrottlePositionController`) and looks for corresponding implementation models (like `Controller.slx`) to generate the detailed diagrams.
