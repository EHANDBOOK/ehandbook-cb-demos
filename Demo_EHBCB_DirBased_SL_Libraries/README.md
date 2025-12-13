# Demo: Directory-based EHB-CB with Simulink Libraries and View Configuration

**Objective:** This demo illustrates how to process Simulink models that use external libraries and how to apply a view configuration to protect intellectual property by hiding the contents of referenced library blocks.

---

## ✨ Features Showcased

* Directory-based build for a Simulink project.
* **Simulink Library Support:** Processing of external Simulink libraries (`.slx` files) using the `-simlib` option.
* **Know-How Protection:** Applying a Simulink view configuration to hide the implementation details of library blocks, preventing users from looking inside them.

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license for the Simulink converter.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder.
* Open the generated EHANDBOOK file.
* Explore the model for the "Function". You will see that the blocks from the external library are correctly linked.
* Try to look inside the library blocks (e.g., by double-clicking). You will find that their content is hidden, as specified by the view configuration.

---

## ⚙️ Under the Hood

This demo highlights two important features for managing complex Simulink projects: handling external libraries and protecting intellectual property.

### Directory Structure

* **`Input/`**: Contains the main Simulink model for the function.
* **`simlib/`**: This folder contains the external Simulink libraries that the main model depends on. The build process is configured to include this path.
* **`configuration/`**: Holds the configuration files for the build.
* `SimulinkViewConfig.json`: This file defines the view configuration. It specifies that the contents of linked blocks should be hidden, effectively protecting the know-how contained within the libraries.
* **`build.bat`**: The script that runs the container build, referencing the library path and view configuration.

### Key Concepts

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_SL_Libraries" ^
-simlib ".\\simlib,%MATLAB_PATH%\\toolbox\\simulink" ^
-simulinkview ".\\configuration\\SimulinkViewConfig.json" ^
-viewtype "GlobalView" ^
-gensvg
```

#### Simulink Library Support

When a Simulink model uses blocks from an external library, the EHANDBOOK Container-Build needs to know where to find that library to correctly resolve the links. This is typically done by passing the path to the library folder via the `-simlib` command-line argument in the `build.bat` file.

#### View Configuration for Know-How Protection

The Simulink View Concept allows you to control what a user sees inside a model. In this demo, the `configuration/SimulinkViewConfig.json` file is used to hide the contents of blocks that are library links. This is a powerful feature for protecting intellectual property, as it allows you to share a functional model without revealing the specific implementation details of your proprietary library blocks.

### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_Libraries" ^
-simlib ".\simlib,%MATLAB_PATH%\toolbox\simulink" ^
-simulinkview ".\configuration\SimulinkViewConfig.json" ^
-viewtype "GlobalView" ^
-gensvg
```

* `-i ".\Input"`: Specifies the input directory containing all source artifacts.
* `-o ".\Output"`: Specifies the output directory for the generated EHANDBOOK container.
* `-n "Demo_EHBCB_DirBased_SL_Libraries"`: Sets the name of the output file.
* `-simlib ".\simlib,%MATLAB_PATH%\toolbox\simulink"`: Specifies paths to Simulink library files.
* `-simulinkview ".\configuration\SimulinkViewConfig.json"`: Applies view configuration for know-how protection.
* `-viewtype "GlobalView"`: Selects the specific view type to apply.
* `-gensvg`: Automatically generates SVG screenshots from the interactive models.
