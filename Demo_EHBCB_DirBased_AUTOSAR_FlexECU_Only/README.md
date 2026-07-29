# Demo: AUTOSAR Architecture-Only Build using `-ar2ehbcbinput`

**Objective:** This demo illustrates a two-step workflow for creating an EHANDBOOK container that documents *only* the AUTOSAR Classic architecture from a set of `.arxml` files, without any implementation models or code.

---

## ✨ Features Showcased

- **Two-Step Build Process:** A dedicated workflow for processing `.arxml` files.
- **`-ar2ehbcbinput` flag:** Use of a special flag to convert a folder of `.arxml` files into a valid EHB-CB input structure.
- **Architecture-Only Documentation:** The final handbook contains only the information derived from the AUTOSAR files (components, ports, interfaces, compositions), which is ideal for high-level architecture reviews.
- **No Implementation:** The source directory contains only `.arxml` files, with no corresponding ASCET or Simulink model files (`.axl` or `.slx`) or C-Code implementation files (`.c`).

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

- After the build completes, navigate to the `Output/` folder.
- Open the generated `FlexECU_AUTOSAR_files.ehb` file.
- You will find a handbook that shows the full software architecture of the FlexECU demo, including all components and their connections, as defined in the `.arxml` files.
- Note that there are no detailed function diagrams, as no implementation was provided.

---

## ⚙️ Under the Hood

This demo showcases a specific, powerful workflow for generating architecture-level documentation directly from AUTOSAR files.

### The Two-Step Workflow in `build.bat`

The `build.bat` script orchestrates a two-step process:

#### Step 1: Convert ARXML to EHB-CB Input

```batch
md FlexECU_AUTOSAR_files_ehb_cb_input

%EHB_CB_PATH%\eHandbookCB.exe ^
-i "FlexECU_AUTOSAR_files" ^
-o "FlexECU_AUTOSAR_files_ehb_cb_input" ^
-ar2ehbcbinput
```

- First, a new directory (`FlexECU_AUTOSAR_files_ehb_cb_input`) is created to serve as a temporary input folder for the next step.
- `eHandbookCB.exe` is called with the `-ar2ehbcbinput` flag. This tells the tool: "Do not build a container. Instead, read all the `.arxml` files in the input directory (`-i`), and generate a valid EHANDBOOK Container-Build directory structure in the output directory (`-o`)."
- This generated structure will contain folders for each software component, with documentation files that EHB-CB can understand.

#### Step 2: Build the EHANDBOOK Container

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i "FlexECU_AUTOSAR_files_ehb_cb_input" ^
-n "FlexECU_AUTOSAR_files" ^
-o "./Output"
```

- The second call to `eHandbookCB.exe` is a standard directory-based build.
- Crucially, the input (`-i`) is now the temporary directory that was created and populated in Step 1.
- EHB-CB processes this generated structure to build the final, architecture-only EHANDBOOK container.

This two-step process is the recommended workflow for generating a handbook purely from `.arxml` files.


### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
# First, convert AUTOSAR ARXML files to EHB-CB input format
%EHB_CB_PATH%\eHandbookCB.exe ^
-i FlexECU_AUTOSAR_files ^
-o "FlexECU_AUTOSAR_files_ehb_cb_input" ^
-ar2ehbcbinput

# Then, build the EHANDBOOK container from the converted input
%EHB_CB_PATH%\eHandbookCB.exe ^
-i "FlexECU_AUTOSAR_files_ehb_cb_input" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only" ^
-o "./Output"
```

This demo uses a two-step build process:

1. **Convert AUTOSAR ARXML to EHB-CB Input Format:**
   - `-i FlexECU_AUTOSAR_files`: Specifies the directory containing AUTOSAR ARXML files.
   - `-o "FlexECU_AUTOSAR_files_ehb_cb_input"`: Specifies the output directory for the converted files.
   - `-ar2ehbcbinput`: Triggers the conversion from AUTOSAR format to EHB-CB input format.

2. **Build the EHANDBOOK Container:**
   - `-i "FlexECU_AUTOSAR_files_ehb_cb_input"`: Uses the converted files as input.
   - `-n "Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only"`: Sets the name of the output file.
   - `-o "./Output"`: Specifies the output directory for the generated EHANDBOOK container.

---
###  Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### Details and direct link

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [Container-Build-Cloud-Service-demo.yml](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only/config.txt`

**Expected output:** The build generates an EHANDBOOK Container file and - where configured - a corresponding PDF document.

---

- **`config.txt`**: This contains the arguments used during the Container-Build process. These arguments are utilized by the EHB-CB Cloud Service container generation workflow to configure the build. By default, the -i, -o, -n and -gensvg arguments are provided by the EHB-CB Cloud API call, so they do not need to be specified in the config.txt file unless explicitly required.

### Configuration File: `config.txt` (This is for demo build process "Convert AUTOSAR ARXML to EHB-CB Input Format")

The `config.txt` file includes the following build arguments for CB SaaS eHandbook container generation.

```text
-ar2ehbcbinput
```


