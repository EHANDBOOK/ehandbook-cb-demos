# Demo: Directory-based EHB-CB with AUTOSAR C-Code from RTA-CAR

**Objective:** This demo illustrates how to use the directory-based EHANDBOOK Container-Build to document an AUTOSAR Classic system from the ETAS RTA-CAR Starter Kit, where the Software Components (SWCs) are implemented in C-Code.

---

## ✨ Features Showcased

* **Directory-based Build** for an AUTOSAR C-Code project.
* **AUTOSAR Classic Integration:** The build automatically discovers and processes `.arxml` files to understand the system architecture.
* **C-Code Implementation of SWCs:** The logic for the AUTOSAR SWCs is provided by `.c` and `.h` files.
* **C-Code Metadata Configuration (`-ccodemeta`):** Use of a special XML configuration (`ccode_config.xml`) to help EHB-CB understand and visualize the AUTOSAR Runtime Environment (RTE) calls within the C-Code.

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license for the C-Code and AUTOSAR converters.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, a `Demo_EHBCB_DirBased_AUTOSAR_CCODE.ehb` file will be created in the `Output` directory.
* Open the EHANDBOOK file. You will see the AUTOSAR software components from the RTA-CAR Starter Kit.
* Navigate into a function diagram. You will see that the C-Code has been visualized as a block diagram, and the AUTOSAR RTE calls (like `Rte_IWriteRef`) are represented by special icons, making the AUTOSAR-specific interactions clear.

---

## ⚙️ Under the Hood

This demo highlights how to configure the C-Code converter to properly document an AUTOSAR system based on hand-written or generated C-Code.

### Directory & File Structure

* **`Input/`**: This is the main input directory for the build, containing the artifacts from the RTA-CAR Starter Kit.
  * **`.arxml` files:** The `System.arxml` and `Interfaces.arxml` files at the root of this directory describe the overall AUTOSAR architecture.
  * **Component Folders (e.g., `CPT_MasterSWC/`):** Each `CPT_` folder represents a software component and contains:
    * The component-specific `.arxml` file (e.g., `MasterSWC.arxml`).
    * The C-Code implementation (`.c`) and header (`.h`) files.
    * AsciiDoc documentation (`.adoc`).
* **`CCodeConfig/`**: This directory contains the crucial configuration for the C-Code converter.
  * `ccode_config.xml`: This XML file maps specific C function calls to graphical representations. It tells EHB-CB that a function like `Rte_IWriteRef(...)` is an AUTOSAR RTE call and should be displayed with a specific icon, rather than being treated as a generic function call.

### Build Script: `build.bat`

The build script is simple, but the `-ccodemeta` argument is the key to enabling the AUTOSAR-specific visualization.

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_CCODE" ^
-gensvg ^
-ccodemeta ".\\CCodeConfig\\ccode_config.xml"
```

* `-i ".\\RTA_SK"`: Specifies the input directory for the directory-based build.
* `-ccodemeta ".\\CCodeConfig\\ccode_config.xml"`: This argument provides the C-Code converter with the metadata file. EHB-CB uses this file to correctly interpret and visualize the AUTOSAR RTE function calls found in the source code, leading to a much richer and more understandable documentation of the system's behavior.

---
###  Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### Details and direct link

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [Container-Build-Cloud-Service-demo.yml](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_AUTOSAR_CCODE/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_AUTOSAR_CCODE/config.txt`

**Expected output:** The build generates an EHANDBOOK Container file and - where configured - a corresponding PDF document.

---

* **`config.txt`**: This contains the arguments used during the Container-Build process. These arguments are utilized by the EHB-CB Cloud Service container generation workflow to configure the build. By default, the -i, -o, and -n arguments are provided by the EHB-CB Cloud API call, so they do not need to be specified in the config.txt file unless explicitly required.

### Configuration File: `config.txt`

The `config.txt` file includes the following build arguments for CB SaaS eHandbook container generation.

```text
-simlib "FlexECU_Simulink_Library"
-nomatlab
-gensvg
-styling ".\styling"
-rootlevel ".\configuration\rootlevel.json"
-labelamendment ".\configuration\labelamendment.json"
```

