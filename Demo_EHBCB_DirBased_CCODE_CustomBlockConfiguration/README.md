# Demo: Directory-based EHB-CB for C-Code with Custom Block Configuration

**Objective:** This demo shows how to generate an EHANDBOOK from a directory-based C-Code project while customizing block visualization (icons, argument names, and port placement) using a dedicated C-Code metadata configuration.

---

## ✨ Features Showcased

* Directory-based EHANDBOOK Container-Build workflow for C-Code.
* Custom C-Code block rendering via `CCodeConfig/CCodeConfig.xml`.
* Function-specific metadata such as custom icon assignment (`imageURI`) and semantic labels (`comment`).
* Port and argument layout control (`argument`, `index`, `portLocation`, `isInstance`, `isReference`).
* Dedicated chapter for function argument configuration combinations (`Function Configuration Options`).
* Regex-based matching for function families (for example `DT1_.*_compute_V2`).
* Custom table of contents structure via `Input/tocs.yaml`.
* Branded output styling with the `-styling` option.

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license for C-Code conversion.
    * Ensure you have run `set_tool_paths.bat` in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute `build.bat`.

---

## 🔬 Explore the Output

* After the build completes, open the generated `.ehb` in the `Output/` folder with EHANDBOOK-NAVIGATOR.
* Navigate through topics like **Function Configuration Options**, **Maps and Curves**, **Transfer Functions**, **Logic and Timing**, and **Service Routines**.
* Inspect C-Code diagrams to see custom visual blocks (for example map/curve, edge detection, and limit functions) represented with configured icons and port layout.
* Compare how generic C functions appear versus functions explicitly configured in `CCodeConfig.xml`.

---

## ⚙️ Under the Hood

### Directory Structure

* **`Input/`**: Source C-Code and AsciiDoc content organized by domain/topic folders, plus the ToC definition (`tocs.yaml`).
* **`CCodeConfig/`**: C-Code metadata configuration (`CCodeConfig.xml`) and related icon assets (`images/`) used for block visualization.
* **`CCodeLib/`**: Shared C helper library (`lib.c`) used during analysis.
* **`styling/`**: Branding and print/PDF customization files used to style the generated container.
* **`build.bat`**: Build entry point for the demo.
* **`Output/`**: Destination folder for generated EHANDBOOK containers.

### Build Script

The build script runs EHANDBOOK Container-Build with C-Code metadata and styling:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_CCODE_ConfigExample" ^
-ccodemeta ".\CCodeConfig\CCodeConfig.xml" ^
-styling ".\styling" ^
-gensvg
```

### Configuration Focus: `CCodeConfig.xml`

The demo’s key differentiator is the function metadata file, which customizes how C functions are rendered as visual blocks:

* **Global behavior** (`globalConfiguration`):
  * `inlineFunctions="true"`
  * `simplifyDiagram="true"`
  * `generateHierarchies="false"`
  * `maxIterationForDataflowAnalysis="50000"`
* **Block identity & appearance**:
  * Assign custom icons with `imageURI`.
  * Add readable descriptions with `comment`.
  * Normalize variants with `unifiedName` where needed.
* **Port semantics**:
  * Control argument placement (`LEFT`, `TOP`, `BOTTOM`) and naming.
  * Mark instance/reference semantics for map/curve style blocks.
* **Extensibility hooks**:
  * Optional templates for operator mapping, ignorable macros, and explicitly included function classes are prepared in the file.

This setup is useful when you want generated graphics to mirror domain-specific block conventions used by your engineering teams.

---

## 📚 Additional Information

Additional information on configuration of C-Code visualization can be found in the EHANDBOOK Container-Build documentation:

<https://docs.etas.com/ehandbook/ehandbook/how-to-guides/EHANDBOOK_Container-Build_User_Guide_Advanced_Features.html#ccode-configuration>


---
###  Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### Details and direct link

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [Container-Build-Cloud-Service-demo.yml](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_CCODE_CustomBlockConfiguration/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_CCODE_CustomBlockConfiguration/config.txt`

**Expected output:** The build generates an EHANDBOOK Container file and - where configured - a corresponding PDF document.

---

* **`config.txt`**: This contains the arguments used during the Container-Build process. These arguments are utilized by the EHB-CB Cloud Service container generation workflow to configure the build. By default, the -i, -o, and -n arguments are provided by the EHB-CB Cloud API call, so they do not need to be specified in the config.txt file unless explicitly required.

### Configuration File: `config.txt`

The `config.txt` file includes the following build arguments for CB SaaS eHandbook container generation.

```text
-ccodemeta ".\CCodeConfig\CCodeConfig.xml"
-styling ".\styling"
-gensvg
```
