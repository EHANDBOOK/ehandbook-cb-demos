# Demo: Directory-based EHB-CB with MATLAB Script for Input Generation

**Objective:** This demo illustrates how a MATLAB m-script can be used to automatically generate the necessary input files (textual documentation and interface specifications) for the EHANDBOOK Container-Build from a set of Simulink models (`.slx`) only.

---

## ✨ Features Showcased

- Using a MATLAB script to automate the preparation of EHB-CB input data.
- Extraction of model information to generate:
  - Textual documentation in AsciiDoc (`.adoc`) format.
  - Interface specifications (signals, calibrations) in Excel (`.xlsx`) format.
- A clear two-step workflow: 1) Pre-process models with a script, 2) Build the container.

---

## 🛠️ How to Run

This demo involves a pre-processing step before the final build.

1. **Prerequisites:**
    - EHANDBOOK Container-Build with a suitable license.
    - MATLAB with Simulink.
    - Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Generate Input Files:**
    - Open MATLAB.
    - Run the `Create_FunctionDocumentation_and_InterfaceSpec_from_Simulink.m` script.
    - When prompted, select the `InputBeforeScript` folder as the search path.
    - The script will process the `.slx` files in that folder and generate the corresponding `.adoc` and `.xlsx` files into the `InputAfterScript` folder.

3. **Build the Container:**
    - Open a command prompt or terminal.
    - Navigate to this directory.
    - Execute the `build.bat` script, which uses the newly generated files in `InputAfterScript` to build the container.

---

## 🔬 Explore the Output

- After the build completes, navigate to the `Output/` folder.
- Open the generated EHANDBOOK file. You will see a container built from the documentation and interfaces that were automatically extracted from the Simulink models.

---

## ⚙️ Under the Hood

This demo showcases a powerful automation workflow. Instead of manually creating documentation and interface files, a MATLAB script does the heavy lifting.

### Directory Structure

- **`InputBeforeScript/`**: Contains the original source Simulink models (`.slx`). This is the starting point.
- **`Create_FunctionDocumentation_and_InterfaceSpec_from_Simulink.m`**: The MATLAB script that reads the models from `InputBeforeScript/`.
- **`InputAfterScript/`**: The destination for the script's output and the source for the EHB-CB build. The script populates this folder with the original models plus the generated `.adoc` and `.xlsx` files.
- **`build.bat`**: The script that runs the EHANDBOOK Container-Build, using `InputAfterScript/` as its input directory.
- **`Output/`**: The destination folder for the final EHANDBOOK container.

### The MATLAB Script

The `Create_FunctionDocumentation_and_InterfaceSpec_from_Simulink.m` script performs the following key actions:

1. **Finds Models:** It recursively searches a selected directory for Simulink models (`.slx` or `.mdl`).
2. **Extracts Interface Data:** It inspects each model to find signals, parameters, and local variables.
3. **Generates Excel Files:** It writes the extracted interface data into a structured `.xlsx` file, formatted with the specific columns required by EHANDBOOK Container-Build.
4. **Generates Documentation:** It creates a basic `.adoc` file for each model, providing a template for further documentation and including placeholders for EHANDBOOK-specific commands like `ehbfunctionoverview`.

### Build Script: `build.bat`

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\InputAfterScript" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_Mscript" ^
-gensvg ^
-nomatlab 
```
---
###  Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### Details and direct link

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [Container-Build-Cloud-Service-demo.yml](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_SL_Mscript/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `../config.txt`

**Expected output:** The build generates an EHANDBOOK Container file and - where configured - a corresponding PDF document.

---

- **`config.txt`**: This contains the arguments used during the Container-Build process. These arguments are utilized by the EHB-CB Cloud Service container generation workflow to configure the build. By default, the -i, -o, -n and -gensvg arguments are provided by the EHB-CB Cloud API call, so they do not need to be specified in the config.txt file unless explicitly required.

### Configuration File: `config.txt`

The `config.txt` file includes the following build arguments for CB SaaS eHandbook container generation.

```text
-nomatlab
```
