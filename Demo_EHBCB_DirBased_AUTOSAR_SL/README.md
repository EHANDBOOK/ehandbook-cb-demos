# Demo: Directory-based EHB-CB with AUTOSAR and a Simulink Implementation

**Objective:** This demo illustrates how to use the directory-based EHANDBOOK Container-Build to document an AUTOSAR Classic Software Component (SWC) whose behavior is implemented in a Simulink model.

---

## ✨ Features Showcased

- **Directory-based Build** for an AUTOSAR project.
- **Simulink Implementation of an SWC:** The demo uses a Simulink model (`.slx`) to define the logic of the `ThrottlePositionController` SWC.
- **AUTOSAR Architecture from ARXML:** The AUTOSAR composition and component descriptions are provided by `.arxml` files.
- **`-autosarcomposition` flag:** Use of a specific flag to tell EHB-CB which composition to use as the entry point for the documentation.

---

## 🛠️ How to Run

1. **Prerequisites:**
    - EHANDBOOK Container-Build with suitable licenses for the Simulink and AUTOSAR converters.
    - Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    - Open a command prompt or terminal.
    - Navigate to this directory.
    - Execute the `build.bat` script.

---

## 🔬 Explore the Output

- After the build completes, a `Demo_EHBCB_DirBased_AUTOSAR_SL.ehb` file will be created in the `Output` directory.
- Open the EHANDBOOK file. You will see the `ThrottlePositionController` software component documented.
- Navigate to the function diagram. You will see the detailed implementation of the controller, which has been generated directly from the provided Simulink model.

---

## ⚙️ Under the Hood

This demo shows how EHB-CB automatically links an AUTOSAR architecture described in `.arxml` with an implementation provided by a Simulink model.

### Directory & File Structure

- **`ControllerExample/`**: This is the main input directory for the build.
  - **`Controller/`**: This subdirectory contains the implementation.
    - `Controller.slx`: The Simulink model that implements the throttle controller logic.
    - `ThrottlePositionControlComposition_updated.arxml`: An updated `.arxml` file that may contain additional details.
- **`ThrottlePositionControlComposition.arxml`**: Located at the root of the demo, this file likely contains the main AUTOSAR composition definition.

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

- `-i "ControllerExample"`: Specifies the input directory. EHB-CB scans this folder and finds both the `.slx` and `.arxml` files.
- `-autosarcomposition "ThrottlePositionControlComposition"`: This important flag tells EHB-CB which AUTOSAR composition to use as the top-level entry point for the documentation. EHB-CB then finds the SWCs within that composition (in this case, the `ThrottlePositionController`) and looks for corresponding implementation models (like `Controller.slx`) to generate the detailed diagrams.

---

### Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### **Internal Container Build Workflow (Admin / Collaborator)**

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [EHANDBOOK Container Request](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_AUTOSAR_SL/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_AUTOSAR_SL/config.txt`

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
   `Demo_EHBCB_DirBased_AUTOSAR_SL/Input`

2. `Configuration file`:  
   `Demo_EHBCB_DirBased_AUTOSAR_SL/config.txt`

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
-autosarcomposition "ThrottlePositionControlComposition"
```

