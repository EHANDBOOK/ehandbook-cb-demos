# Demo: ASAM-based EHB-CB for a single Simulink-based ECU function

**Objective:** This demo illustrates how to generate an EHANDBOOK Container using ASAM-based input formats (CCX, FSX, MDX) for a single ECU function that is specified by a Simulink model.

---

## ✨ Features Showcased

- ASAM-based input data structure (CCX, MDX, FSX)
- Referencing and processing of Simulink model in .mdl file (can also be .slx)
- Referencing and processing of images included in document text in .eps and .svg format

---

## 🛠️ How to Run

1. **Prerequisites:**
   - EHANDBOOK Container-Build with suitable licenses for ASAM-based input formats and Simulink model converter
   - Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
   - Open a command prompt or terminal.
   - Navigate to this directory
   - Execute the `build.bat` script.

---

## 🔬 Explore the Output

- After the build completes, navigate to the `Output/` folder.
- Open the generated EHANDBOOK file names `Demo_EHBCB_ASAMBased_SL_Simple.ehb`

---

## ⚙️ Under the Hood

[This is the core learning section. Explain *how* the demo works by breaking down its components. Be specific and use code snippets.]

### Directory Structure

- **`Input/`**: This directory contains all the source artifacts for the build.
  - **`asamCC.ccx`**: The ASAM‑CC XML “container catalog” file. It defines the project’s table of contents and function components, and links them to their FSX/MDX files and model artifacts so EHANDBOOK Container‑Build can assemble the container.
  - **`Iac_mdl/`**: This folder contains the Simulink model and its specific documentation assets.
    - `Iac.mdl`: The Simulink model file.
    - `_doc/`: A directory intended for documentation assets related to the model.
    - `_pic/`: A directory for picture or image files that can be referenced in the documentation.
- **`Output/`**: This is the destination folder where the generated EHANDBOOK will be saved after the build process.
- **`build.bat`**: This script runs the EHANDBOOK Container-Build process. It's powerful because it requires no separate configuration file; the build is entirely controlled by the file types and the directory structure found in the `Input` folder.

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

### Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### **Internal Container Build Workflow (Admin / Collaborator)**

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [EHANDBOOK Container Request](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_ASAMBased_SL_Simple/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_ASAMBased_SL_Simple/config.txt`

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
   `Demo_EHBCB_ASAMBased_SL_Simple/Input`

2. `Configuration file`:  
   `Demo_EHBCB_ASAMBased_SL_Simple/config.txt`

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
-nomatlab
```
