# Demo: Directory-based EHB-CB with AUTOSAR Architecture Only

**Objective:** This demo illustrates how to use the directory-based EHANDBOOK Container-Build to create a handbook that documents *only* the AUTOSAR Classic architecture from `.arxml` files, without including any implementation details from models or code.

---

## ✨ Features Showcased

- **Directory-based Build** for an AUTOSAR project.
- **Architecture-Only Documentation:** Demonstrates the generation of a handbook containing only the information derived from AUTOSAR (`.arxml`) files, such as software components, ports, interfaces, and compositions.
- **No Implementation:** The input directory for this demo intentionally contains no implementation artifacts like ASCET models (`.axl`) or C-Code (`.c`).

---

## 🛠️ How to Run

1. **Prerequisites:**
    - EHANDBOOK Container-Build with a suitable license for the AUTOSAR converter.
    - Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    - Open a command prompt or terminal.
    - Navigate to this directory.
    - Execute the `build.bat` script.

---

## 🔬 Explore the Output

- After the build completes, a `Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only.ehb` file will be created in this directory.
- Open the EHANDBOOK file. You will find a handbook that shows the software components and their connections as defined in the `.arxml` files.
- Notice that there are no detailed function diagrams or block diagrams, as no implementation was provided. This type of handbook is useful for high-level architecture reviews.

---

## ⚙️ Under the Hood

This demo highlights the ability of EHB-CB to create useful documentation even from incomplete project data, focusing purely on the specified architecture.

### Directory & File Structure

- **`Input/`**: This is the main input directory.
  - **`.arxml` files:** Contains the AUTOSAR architecture files (`Compositions.arxml`, `Interfaces.arxml`, etc.).
  - **Component Folders (e.g., `CPT_Tqs/`):** Contains a folder for a software component, but note that this folder *only* contains a documentation file (`Documentation.adoc`) and **no ASCET model or C-Code**.

### Build Script: `build.bat`

The build script is a standard directory-based build command.

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i "Input" ^
-o "." ^
-n "Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only" ^
-nomatlab
```

- `-i "Input"`: EHB-CB scans this directory. It finds the `.arxml` files and understands the AUTOSAR architecture.
- Because it does not find any corresponding implementation files (like `.axl` or `.c`) for the software components described in the `.arxml` files, it proceeds to create a handbook that documents only the architecture level. This is a powerful feature for generating architecture-focused views of a system without needing the complete, detailed implementation.

---
###  Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### Details and direct link

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [Container-Build-Cloud-Service-demo.yml](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_AUTOSAR_Excerpt_AR_Only/Input`
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

