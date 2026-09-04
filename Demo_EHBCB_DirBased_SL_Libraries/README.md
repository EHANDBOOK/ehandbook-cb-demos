# Demo: Directory-based EHB-CB with Simulink Libraries and View Configuration

**Objective:** This demo illustrates how to process Simulink models that use external libraries and how to apply a view configuration to protect intellectual property by hiding the contents of referenced library blocks.

---

## ✨ Features Showcased

- Directory-based build for a Simulink project.
- **Simulink Library Support:** Processing of external Simulink libraries (`.slx` files) using the `-simlib` option.
- **Know-How Protection:** Applying a Simulink view configuration to hide the implementation details of library blocks, preventing users from looking inside them.

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
- Explore the model for the "Function". You will see that the blocks from the external library are correctly linked.
- Try to look inside the library blocks (e.g., by double-clicking). You will find that their content is hidden, as specified by the view configuration.

---

## ⚙️ Under the Hood

This demo highlights two important features for managing complex Simulink projects: handling external libraries and protecting intellectual property.

### Directory Structure

- **`Input/`**: Contains the main Simulink model for the function.
- **`simlib/`**: This folder contains the external Simulink libraries that the main model depends on. The build process is configured to include this path.
- **`configuration/`**: Holds the configuration files for the build.
- `SimulinkViewConfig.json`: This file defines the view configuration. It specifies that the contents of linked blocks should be hidden, effectively protecting the know-how contained within the libraries.
- **`build.bat`**: The script that runs the container build, referencing the library path and view configuration.

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

- `-i ".\Input"`: Specifies the input directory containing all source artifacts.
- `-o ".\Output"`: Specifies the output directory for the generated EHANDBOOK container.
- `-n "Demo_EHBCB_DirBased_SL_Libraries"`: Sets the name of the output file.
- `-simlib ".\simlib,%MATLAB_PATH%\toolbox\simulink"`: Specifies paths to Simulink library files.
- `-simulinkview ".\configuration\SimulinkViewConfig.json"`: Applies view configuration for know-how protection.
- `-viewtype "GlobalView"`: Selects the specific view type to apply.
- `-gensvg`: Automatically generates SVG screenshots from the interactive models.


---

### Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### **Internal Container Build Workflow (Admin / Collaborator)**

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [EHANDBOOK Container Request](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_SL_Libraries/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_SL_Libraries/config.txt`

**Expected output:** The build generates an EHANDBOOK Container (.ehb) and a PDF when -pdf is specified in config.txt.

---

#### **Public Container Build Request (Anyone)**

The container generation is initiated by creating a GitHub Issue using the **EHANDBOOK Container Request** issue form.

Direct request link: [EHANDBOOK Container Request](https://github.com/EHANDBOOK/ehandbook-cb-demos/issues/new?template=ehb-container-request.yml)

> The issue form must be available from the repository's default branch and stored under `.github/ISSUE_TEMPLATE/`.

##### How to request a container

1. Open the **EHANDBOOK Container Request** issue form using the direct link above.
2. Enter the required **Demo folder**.
3. Optionally enter the **Configuration file**.
4. Confirm that the demo folder is a valid EHANDBOOK demo.
5. Click **Submit new issue**.

##### Example values

1. `Demo folder`:  
   `Demo_EHBCB_DirBased_SL_Libraries/Input`

2. `Configuration file`:  
   `Demo_EHBCB_DirBased_SL_Libraries/config.txt`

The **storage type** and **repository URL** are managed by the workflow and are not entered by the requester.

Internally, the trusted workflow uses:

- `storage_type`: `GIT`
- `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`

**Expected output:** The build generates an EHANDBOOK Container (.ehb) and a PDF when -pdf is specified in config.txt.

---

### Configuration file

**`config.txt`**: This file contains the argument key-value pairs used during the Container-Build process. These arguments are consumed by the EHB-CB Cloud Service container-generation workflow to configure and control the build.

By default, the -i, -o, -n, and -gensvg arguments are provided by the EHB-CB Cloud API. Therefore, they do not need to be specified in config.txt unless explicitly required.

For arguments that contain file or directory paths:

- Relative paths are resolved relative to the location of the config.txt file.
- Absolute paths are resolved relative to the repository root, similar to how the input path is resolved.

#### Demo Configuration File

The `config.txt` file includes the following build arguments for CB SaaS eHandbook container generation.

```text
-simlib "%MATLAB_PATH%\toolbox\simulink"
-simulinkview ".\configuration\SimulinkViewConfig.json"
-viewtype "GlobalView"
```
