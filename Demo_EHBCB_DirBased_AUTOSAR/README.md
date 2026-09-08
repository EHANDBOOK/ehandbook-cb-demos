# Demo: Directory-based EHB-CB with AUTOSAR Classic and ASCET

**Objective:** This demo illustrates how to use the directory-based EHANDBOOK Container-Build to generate a container from an AUTOSAR Classic architecture where the Software Components (SWCs) are implemented as ASCET models.

---

## ✨ Features Showcased

- **Directory-based Build:** The build process is initiated by pointing to a main input folder, which contains all necessary artifacts.
- **AUTOSAR Classic Integration:** The input directory contains `.arxml` files that EHB-CB automatically discovers and processes to understand the AUTOSAR architecture.
- **ASCET Models for SWCs:** The logic for the AUTOSAR Software Components is provided by ASCET models (`.axl`) located in component-specific subdirectories.
- Advanced configuration options for styling, hierarchy, and labeling.

---

## 🛠️ How to Run

1. **Prerequisites:**
    - EHANDBOOK Container-Build with suitable licenses for the ASCET and AUTOSAR converters.
    - Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    - Open a command prompt or terminal.
    - Navigate to this directory.
    - Execute the `build.bat` script.

---

## 🔬 Explore the Output

- After the build completes, a `FlexECU_Dir_AUTOSAR.ehb` file will be created in this directory.
- Open the EHANDBOOK file to explore the documented AUTOSAR system. You will see the software components and their underlying ASCET model implementations integrated into a single, navigable handbook.

---

## ⚙️ Under the Hood

This demo shows how the directory-based build mode can be used for complex AUTOSAR projects, providing an alternative to the ASAM-based approach.

### Directory & File Structure

- **`FlexECU_Dir_AUTOSAR/`**: This is the main input directory for the build.
  - **`.arxml` files:** At the root of this directory are the AUTOSAR `.arxml` files describing the system's software architecture, compositions, components, and interfaces. EHB-CB automatically finds and parses these.
  - **Component Folders (e.g., `CPT_Fmc/`, `CPT_Tqs/`):** Each `CPT_` folder represents a software component. Inside, you will find the corresponding ASCET model (`.axl`) that implements the component's logic, along with any associated documentation (`.adoc`).
- **`configuration/`**: Contains various JSON files for customizing the output, such as `rootlevel.json` to control the hierarchy and `labelamendment.json` to modify labels.
- **`etas-styling/`**: Provides custom branding and styling for the generated EHANDBOOK container.
- **`FlexECU_Simulink_Library/`**: Contains Simulink library files, provided via the `-simlib` argument.

### Build Script: `build.bat`

The build script invokes EHB-CB in directory-based mode by pointing to the main input folder.

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i "FlexECU_Dir_AUTOSAR" ^
-o "." ^
-n "FlexECU_Dir_AUTOSAR" ^
-simlib "FlexECU_Simulink_Library" ^
-nomatlab ^
-gensvg ^
-styling ".\\etas-styling" ^
-rootlevel ".\\configuration\\rootlevel.json" ^
-labelamendment ".\\configuration\\labelamendment.json"
```

- `-i "FlexECU_Dir_AUTOSAR"`: This argument triggers the **directory-based build**. EHB-CB scans this entire directory.
- EHB-CB's auto-detection mechanism identifies the `.arxml` files for the AUTOSAR architecture and the `.axl` files within the subdirectories as the implementations, automatically linking them together to build the final container.

---

### Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### **Internal Container Build Workflow (Admin / Collaborator)**

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [EHANDBOOK Container Request](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_AUTOSAR/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_AUTOSAR/config.txt`

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
   `Demo_EHBCB_DirBased_AUTOSAR/Input`

2. `Configuration file`:  
   `Demo_EHBCB_DirBased_AUTOSAR/config.txt`

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
-simlib ".\FlexECU_Simulink_Library"
-nomatlab
-styling ".\styling"
-rootlevel ".\configuration\rootlevel.json"
-labelamendment ".\configuration\labelamendment.json"
```

