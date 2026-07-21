# Demo: ASAM-based EHB-CB for a single Simulink-based ECU function

**Objective:** This demo illustrates how to generate an EHANDBOOK Container using ASAM-based input formats (CCX, FSX, MDX) for a single ECU function that is specified by a Simulink model.

---

## ✨ Features Showcased

* ASAM-based input data structure (CCX, MDX, FSX)
* Referencing and processing of Simulink model in .mdl file (can also be .slx)
* Referencing and processing of images included in document text in .eps and .svg format

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with suitable licenses for ASAM-based input formats and Simulink model converter
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder.
* Open the generated EHANDBOOK file names `Demo_EHBCB_ASAMBased_SL_Simple.ehb`

---

## ⚙️ Under the Hood

[This is the core learning section. Explain *how* the demo works by breaking down its components. Be specific and use code snippets.]

### Directory Structure

* **`Input/`**: This directory contains all the source artifacts for the build.
  * **`asamCC.ccx`**:  The ASAM‑CC XML “container catalog” file. It defines the project’s table of contents and function components, and links them to their FSX/MDX files and model artifacts so EHANDBOOK Container‑Build can assemble the container.
  * **`Iac_mdl/`**: This folder contains the Simulink model and its specific documentation assets.
    * `Iac.mdl`: The Simulink model file.
    * `_doc/`: A directory intended for documentation assets related to the model.
    * `_pic/`: A directory for picture or image files that can be referenced in the documentation.
* **`Output/`**: This is the destination folder where the generated EHANDBOOK will be saved after the build process.
* **`build.bat`**: This script runs the EHANDBOOK Container-Build process. It's powerful because it requires no separate configuration file; the build is entirely controlled by the file types and the directory structure found in the `Input` folder.

### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input\\asamCC.ccx" ^
-o ".\\Output" ^
-n "Demo_EHBCB_ASAMBased_SL_Simple" ^
-nomatlab ^
-gensvg
```
---
###  Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### Details and direct link

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [Container-Build-Cloud-Service-demo.yml](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_ASAMBased_SL_Simple/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_ASAMBased_SL_Simple/config.txt`

**Expected output:** The build generates an EHANDBOOK Container file and - where configured - a corresponding PDF document.

---

* **`config.txt`**: This contains the arguments used during the Container-Build process. These arguments are utilized by the EHB-CB Cloud Service container generation workflow to configure the build. By default, the -i, -o, and -n arguments are provided by the EHB-CB Cloud API call, so they do not need to be specified in the config.txt file unless explicitly required.

### Configuration File: `config.txt`

The `config.txt` file includes the following build arguments for CB SaaS eHandbook container generation.

```text
-nomatlab
-gensvg
```
