# Demo: Directory-based EHB-CB with Mixed Model Sources

**Objective:** This demo illustrates how to use the directory-based EHANDBOOK Container-Build to generate a single container from a project that combines function specifications from multiple different sources: an ASCET model, a Simulink model, and plain C-Code.

---

## ✨ Features Showcased

- Directory-based input structure for a mixed-source project.
- Processing of different function types in a single build, including:
  - An ASCET model (`.axl`)
  - A Simulink model (`.slx`)
  - A C-Code implementation
- Use of AsciiDoc (`.adoc`) files for textual documentation for each component.
- Use of Excel files (`.xlsx`) to define measurement signals and calibrations.

---

## 🛠️ How to Run

1. **Prerequisites:**
    - EHANDBOOK Container-Build with suitable licenses for ASCET, Simulink, and C-Code converters.
    - Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    - Open a command prompt or terminal.
    - Navigate to this directory.
    - Execute the `build.bat` script.

---

## 🔬 Explore the Output

- After the build completes, navigate to the `Output/` folder.
- Open the generated EHANDBOOK file to see the different functions, each from a different source, integrated seamlessly into one container.

---

## ⚙️ Under the Hood

This demo showcases the power and flexibility of the directory-based build to automatically detect and integrate different types of source artifacts without needing a complex configuration file.

### Directory Structure

- **`Input/`**: This directory contains all the source artifacts, organized into subdirectories for each function. The build tool automatically identifies the type of each function based on the files it finds.
  - **`Function1/`**: Contains the artifacts for an ASCET-based function.
  - **`Function2/`**: Contains the artifacts for a Simulink-based function.
  - *(Note: A C-Code function would be structured similarly in its own folder)*
- **`Output/`**: This is the destination folder where the generated EHANDBOOK will be saved.

- **`build.bat`**: This script runs the EHANDBOOK Container-Build process. It relies on the directory structure and the types of files within the `Input` folder to correctly identify and process each component.


### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed" ^
-nomatlab ^
-simlib "%MATLAB_PATH%\toolbox\simulink\blocks\library" ^
-gensvg
```

 - `-i ".\Input"`: Specifies the input directory containing all source artifacts.
- `-o ".\Output"`: Specifies the output directory for the generated EHANDBOOK container.
- `-n "Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed"`: Sets the name of the output file.
- `-nomatlab`: Instructs the builder to use its internal Simulink reader rather than launching MATLAB, speeding up the build.
- `-simlib "%MATLAB_PATH%\toolbox\simulink\blocks\library"`: Specifies the path to Simulink library blocks.
- `-gensvg`: Automatically generates SVG screenshots from the interactive models.

---
###  Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### Details and direct link

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [Container-Build-Cloud-Service-demo.yml](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed/Input`
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
-simlib "%MATLAB_PATH%\toolbox\simulink\blocks\library"
```
