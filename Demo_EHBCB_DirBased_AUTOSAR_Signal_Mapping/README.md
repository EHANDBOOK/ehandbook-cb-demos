# Demo: AUTOSAR Signal Mapping Across Domains

**Objective:** This demo illustrates how to establish and visualize connections between components from different domains (e.g., AUTOSAR and MSR) within an EHANDBOOK container. This is achieved by using a component mapping file to define the signal flows.

---

## ✨ Features Showcased

* Directory-based EHANDBOOK Container-Build.
* Signal mapping between components from different domains.
* Use of a JSON file (`ComponentMapping.json`) to define the connections.
* Passing the mapping file to the build process via the `-componentconnectormappingfile` command-line argument.

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, an `Output/` folder will be created.
* Open the generated EHANDBOOK file. In the function overview, you will see the connectors between the components as defined in the mapping file.

---

## ⚙️ Under the Hood

This demo highlights the component mapping feature, which allows you to explicitly define data connections between otherwise separate components.

### Directory Structure

* **`Input/`**: Contains the source artifacts for the different components of the build.
* **`ComponentMapping.json`**: The core of this demo. This file defines which output port of one component connects to an input port of another.
* **`build.bat`**: This script runs the EHANDBOOK Container-Build process. It is configured to pass the `ComponentMapping.json` file to the builder using a specific command-line argument.

### Component Connector Mapping

To visualize connectors between components from different domains, a mapping file is processed during container generation.

#### Build Command

The mapping file is passed to `eHandbookCB.exe` via the `-componentconnectormappingfile` command-line argument. The `build.bat` in this demo is an example of how this is done.

```bat
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping" ^
-gensvg ^
-nomatlab ^
-matlabpath "C:\\Program Files\\MATLAB\\R2019b\\bin" ^
-simlib "C:\\Program Files\\MATLAB\\R2019b\\toolbox\\simulink" ^
-componentconnectormappingfile ".\\ComponentMapping.json"
```

#### Mapping File Specification

The mapping file, which can be in `.json` or `.csv` format, contains the details of the connecting signals.

The `ComponentMapping.json` in this demo has the following structure:

```json
[
  {
    "exported": {
      "port": "result",
      "component": "Function 1"
    },
    "imported": {
      "port": "a",
      "component": "Function 2"
    }
  }
]
```

* **`exported`**: Defines the source of the signal.
  * `port`: The name of the output port.
  * `component`: The name of the component exporting the signal.
* **`imported`**: Defines the destination of the signal.
  * `port`: The name of the input port.
  * `component`: The name of the component importing the signal.

Using this specification, you can connect functions from different domains, and EHANDBOOK will visualize these connections. For more details, see the [official documentation](https://docs.etas.com/ehandbook/ehandbook/how-to-guides/EHANDBOOK_Container-Build_User_Guide_Advanced_Features.html#mapping_signals_across_domain).


### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping" ^
-gensvg ^
-nomatlab ^
-matlabpath "%MATLAB_PATH%\bin" ^
-simlib "%MATLAB_PATH%\toolbox\simulink" ^
-componentconnectormappingfile ".\ComponentMapping.json"
```

* `-i ".\Input"`: Specifies the input directory containing all source artifacts.
* `-o ".\Output"`: Specifies the output directory for the generated EHANDBOOK container.
* `-n "Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping"`: Sets the name of the output file.
* `-gensvg`: Automatically generates SVG screenshots from the interactive models.
* `-nomatlab`: Instructs the builder to use its internal Simulink reader rather than launching MATLAB.
* `-matlabpath "%MATLAB_PATH%\bin"`: Specifies the path to the MATLAB installation (used for certain operations even with `-nomatlab`).
* `-simlib "%MATLAB_PATH%\toolbox\simulink"`: Specifies the path to Simulink library blocks.
* `-componentconnectormappingfile ".\ComponentMapping.json"`: Specifies a JSON file that maps component connectors for signal mapping.