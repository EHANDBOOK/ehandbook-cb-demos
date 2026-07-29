# Demo: Directory-based EHB-CB with ASCET, Simulink, and C-Code

**Objective:** This demo illustrates how to use the directory-based EHANDBOOK Container-Build to generate a single container from function specifications of different sources: an ASCET model, a Simulink model, and plain C-Code.

---

## ✨ Features Showcased

- Directory-based input structure for a mixed-source project.
- Processing of three different function types in a single build:
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
- Open the generated EHANDBOOK file to see the three different functions integrated into one container.

---

## ⚙️ Under the Hood

This demo showcases the power of the directory-based build to automatically detect and integrate different types of source artifacts without needing a complex configuration file.

### Directory Structure

- **`Input/`**: This directory contains all the source artifacts, organized into subdirectories for each function.
  - **`ASCET/`**: Contains the artifacts for the ASCET-based function.
    - `Fmc.axl`: The ASCET model file.
    - `Fmc_InOut.xlsx`: An Excel file defining the function's interface (signals, parameters).
    - `Fmc_text.adoc`: An AsciiDoc file for textual documentation.
  - **`Simulink/`**: Contains the artifacts for the Simulink-based function.
    - `Lcc.slx`: The Simulink model file.
    - `Lcc_InOut.xlsx`: An Excel file for the function's interface.
    - `Lcc_text.adoc`: An AsciiDoc file for documentation.
  - **`CCode/`**: Contains the artifacts for the C-Code-based function.
    - `ccode_Itc_InjectionTime.c`: The C source file.
    - `ccode_Itc_InjectionTime.h`: The C header file.
    - `Itc_InOut.xlsx`: Excel file for the interface.
    - `Itc_text.adoc`: AsciiDoc file for documentation.
- **`Output/`**: This is the destination folder where the generated EHANDBOOK will be saved.
- **`-nomatlab`**: Instructs the builder to use its internal Simulink reader rather than launching MATLAB, speeding up the build.
- **`-simlib "%MATLAB_PATH%\toolbox\simulink\blocks\library"`**: Specifies the path to Simulink library blocks.
- **`-gensvg`**: Automatically generates SVG screenshots from the interactive models
- **`build.bat`**: This script runs the EHANDBOOK Container-Build process. It relies on the directory structure and file types in the `Input` folder to correctly build the container.

### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_ASCET_SL_CCODE" ^
-nomatlab ^
-simlib "%MATLAB_PATH%\toolbox\simulink\blocks\library" ^
-gensvg
```

---

### Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### Details and direct link

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [Container-Build-Cloud-Service-demo.yml](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_ASCET_SL_CCODE/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_ASCET_SL_CCODE/config.txt`

**Expected output:** The build generates an EHANDBOOK Container file and - where configured - a corresponding PDF document.

---

- **`config.txt`**: This contains the arguments used during the Container-Build process. These arguments are utilized by the EHB-CB Cloud Service container generation workflow to configure the build. By default, the -i, -o, -n and -gensvg arguments are provided by the EHB-CB Cloud API call, so they do not need to be specified in the config.txt file unless explicitly required.

### Configuration File: `config.txt`

The `config.txt` file includes the following build arguments for CB SaaS eHandbook container generation.

```text
-nomatlab
-simlib "%MATLAB_PATH%\toolbox\simulink\blocks\library"
```
