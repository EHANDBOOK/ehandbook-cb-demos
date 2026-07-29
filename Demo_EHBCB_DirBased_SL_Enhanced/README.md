# Demo: Directory-based EHB-CB with Enhanced Simulink Features

**Objective:** This demo illustrates various advanced concepts and command-line options that can be used to fine-tune the processing and presentation of Simulink models in an EHANDBOOK container.

---

## ✨ Features Showcased

- **Custom Table Configuration:** Using a JSON file to define custom tables for system constants, parameters, and variables.
- **Simulink View Concept:** Applying know-how protection by selectively hiding or showing details of a Simulink model.
- **Simulink Library Support:** Processing additional Simulink libraries (`.slx` files) that are part of the project.
- **No-MATLAB Connection:** Generating the container without requiring a MATLAB installation, which significantly speeds up the build process. While this speeds up the build process, the generated interactive models and SVG images have less details (e.g., no mask images).
- **SVG Generation:** Automatically generating SVG image screenshots from the interactive model.
- **Commented Element Rendering Support:** Rendering commented Simulink and Stateflow blocks, states, transitions, signal lines, and labels in gray-out mode with support for both explicit (`comment.xplicit`) and implicit (`comment.implicit`) comment annotations.

---

## 🛠️ How to Run

1. **Prerequisites:**
    - EHANDBOOK Container-Build with a suitable license for the Simulink converter.
    - Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    - Open a command prompt or terminal.
    - Navigate to this directory.
    - Execute the `build.bat` script.

---

## 🔬 Explore the Output

- After the build completes, navigate to the `Output/` folder.
- Open the generated EHANDBOOK file.
- Observe the following:
  - The "Model Parameters & Variables" chapter contains custom-structured tables.
  - The model view may hide certain details (like the contents of subsystems) as defined by the view concept.
  - The model will have correctly resolved links to the blocks from the `simlib` library.
  - Commented Simulink and Stateflow elements are rendered in gray-out mode with faded labels, transitions, signal lines, and OR-state rendering behavior.

---

## ⚙️ Under the Hood

This demo highlights several powerful command-line arguments and configuration files used in the `build.bat` script to control the Simulink conversion process.

### Directory and File Structure

- **`Input/`**: Contains the primary Simulink model to be processed.
- **`simlib/`**: A folder containing an additional Simulink library (`.slx` file) that the main model depends on.
- **`TableConfiguration.json`**: A configuration file that defines the structure, columns, and filters for creating custom tables of model parameters and variables.
- **`SimulinkGlobalView.json`**: A configuration file for the Simulink View Concept, specifying which parts of the model to hide or show.
- **`build.bat`**: The build script that orchestrates the process, using several key command-line arguments.

### Key Build Options

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_SL_Enhanced" ^
-gensvg ^
-nomatlab ^
-tableconfig "TableConfiguration.json" ^
-viewtype "AllView" ^
-simulinkview "SimulinkGlobalView.json" ^
-simlib ".\\simlib,%MATLAB_PATH%\\toolbox\\simulink"
```

- `-tableconfig "TableConfiguration.json"`: This option points to the JSON file that configures customized tables for model data, allowing for more organized and readable presentation of parameters and variables.
- `-viewtype "AllView"`: This option activates the Simulink View Concept. It can be used with a configuration file (like `SimulinkGlobalView.json`) to apply know-how protection by hiding the implementation details of certain blocks. For more information, see the [Simulink View Concept documentation](https://docs.etas.com/ehandbook/ehandbook/how-to-guides/simulink-view-concept.html).
- `-simlib`: This option tells the builder to process additional Simulink libraries. The path to the library is often configured in the main EHB-CB configuration. For more details, see the [Simulink Library Support documentation](https://docs.etas.com/ehandbook/ehandbook/how-to-guides/EHANDBOOK_Container-Build_User_Guide_Advanced_Features.html#simulink-library-support).
- `-nomatlab`: This option instructs the builder to use its internal Simulink model reader instead of launching a full MATLAB session. This results in a much faster container generation time, but may not support all advanced or custom blocksets.
- `-gensvg`: This option automatically generates high-quality SVG screenshots of the model hierarchies, which can be used in the documentation.

---
###  Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### Details and direct link

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [Container-Build-Cloud-Service-demo.yml](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_SL_Enhanced/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_SL_Enhanced/config.txt`

**Expected output:** The build generates an EHANDBOOK Container file and - where configured - a corresponding PDF document.

---

- **`config.txt`**: This contains the arguments used during the Container-Build process. These arguments are utilized by the EHB-CB Cloud Service container generation workflow to configure the build. By default, the -i, -o, -n and -gensvg arguments are provided by the EHB-CB Cloud API call, so they do not need to be specified in the config.txt file unless explicitly required.

### Configuration File: `config.txt`

The `config.txt` file includes the following build arguments for CB SaaS eHandbook container generation.

```text
-nomatlab
-tableconfig "TableConfiguration.json"
-viewtype "AllView"
-simulinkview "SimulinkGlobalView.json"
-simlib ".\simlib,%MATLAB_PATH%\toolbox\simulink"
```
