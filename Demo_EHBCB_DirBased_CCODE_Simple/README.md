# Demo: Directory-based EHB-CB for Simple C-Code Functions

**Objective:** This demo illustrates how to use the directory-based EHANDBOOK Container-Build to generate a container from two simple ECU functions implemented in C-Code.

---

## ✨ Features Showcased

- Directory-based input structure for a project with multiple C-Code functions.
- Processing of two separate C-Code functions (`Function1` and `Function2`) in a single build.
- Use of AsciiDoc (`.adoc`) files for textual documentation for each function.
- Use of Excel files (`.xlsx`) for interface specification.
- Inclusion of a shared C-Code library (`CCodeLib`).

---

## 🛠️ How to Run

1. **Prerequisites:**
    - EHANDBOOK Container-Build with a suitable license for the C-Code converter.
    - Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    - Open a command prompt or terminal.
    - Navigate to this directory.
    - Execute the `build.bat` script.

---

## 🔬 Explore the Output

- After the build completes, navigate to the `Output/` folder.
- Open the generated EHANDBOOK file to see the two C-Code functions integrated into one container.

---

## ⚙️ Under the Hood

This demo provides a basic example of how to structure a directory-based build for a project with multiple C-Code components.

### Directory Structure

- **`Input/`**: Contains the source artifacts for each function, organized into subdirectories.
- **`Function1/`**: Contains the artifacts for the first function, including its C-Code (`test.c`), documentation (`function1.adoc`), and interface definition (`if.xlsx`).
- **`Function2/`**: Contains the artifacts for the second function, including its C-Code (`Func2.c`), documentation (`function2.adoc`), and interface definition (`if.xlsx`).
- **`CCodeConfig/`**: This folder can hold a `CCodeConfig.json` file to provide specific configuration parameters for the C-Code converter.
- **`CCodeLib/`**: This folder contains a shared library (`mul_div.c`) that provides common functions (`mul`, `div`) used by the other C-Code modules.
- **`Output/`**: This is the destination folder where the generated EHANDBOOK will be saved.
- **`build.bat`**: This script runs the EHANDBOOK Container-Build process.

### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_CCODE_Simple" ^
-ccodemeta ".\\CCodeConfig\\CCodeFunctionConfig.xml" ^
-gensvg
```

---

### Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### **Internal Container Build Workflow (Admin / Collaborator)**

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [EHANDBOOK Container Request](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_CCODE_Simple/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_CCODE_Simple/config.txt`

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
   `Demo_EHBCB_DirBased_CCODE_Simple/Input`

2. `Configuration file`:  
   `Demo_EHBCB_DirBased_CCODE_Simple/config.txt`

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
-ccodemeta ".\CCodeConfig\CCodeFunctionConfig.xml"
```

