# Demo: Directory-based EHB-CB for an AUTOSAR Simulink Component

**Objective:** This demo illustrates how to use the directory-based EHANDBOOK Container-Build to generate a container for an AUTOSAR (Classic) software component specified by a Simulink model.

---

## ✨ Features Showcased

- Directory-based input structure for an AUTOSAR component.
- Processing of a Simulink model (`.slx`) that uses the AUTOSAR Blockset.
- Processing of AUTOSAR software components and compositions provided in `.arxml` files.

---

## 🛠️ How to Run

1. **Prerequisites:**
    - EHANDBOOK Container-Build with a suitable license for the Simulink model converter.
    - MATLAB installation with the following apps:
        - AUTOSAR Blockset
        - Embedded Coder
        - Simulink Coder
    - Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    - Open a command prompt or terminal.
    - Navigate to this directory.
    - Execute the `build.bat` script.

---

## 🔬 Explore the Output

- After the build completes, an `Output/` folder will be created.
- Navigate into the `Output/` folder and open the generated EHANDBOOK file.

---

## ⚙️ Under the Hood

This demo shows how to build a container for an AUTOSAR software component (`Epm`) that is modeled in Simulink.

### Directory Structure

- **`Input/`**: This is the main input directory for the build.
  - **`CPT_Epm/`**: Contains the Simulink model (`.slx` file) for the `Epm` component.
  - **`*.arxml`**: A set of AUTOSAR XML files that describe the software components, compositions, data types, and interfaces. These are processed by the build to understand the AUTOSAR architecture.
  - **`Documentation.adoc`**: An AsciiDoc file for including additional documentation.
- **`build.bat`**: The script that runs the directory-based EHANDBOOK Container-Build process. The build is driven by the file types and directory structure found in the input folder.

### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU" ^
-gensvg
```

---

## ℹ️ Additional Information

For more details on working with AUTOSAR components in Simulink, refer to the official MathWorks documentation:

1. **Install MATLAB Apps:** Ensure you have the **AUTOSAR Blockset**, **Embedded Coder**, and **Simulink Coder** installed in your MATLAB environment.

2. **Model Import and Configuration:** The following links provide guidance on importing and configuring AUTOSAR models in Simulink:
    - [Create an AUTOSAR Software Component in Simulink](https://in.mathworks.com/help/autosar/ug/create-an-autosar-software-component-in-simulink.html#mw_1a65cc20-5f3b-469d-a7bc-55c987033eef)
    - [Configure AUTOSAR Ports Using Simulink Bus Ports](https://in.mathworks.com/help/autosar/ug/configure-autosar-ports-using-sl-bus-ports.html)
    - [Configure AUTOSAR Adaptive Elements and Properties](https://in.mathworks.com/help/autosar/ug/configure-autosar-adaptive-elements-and-properties.html)

3. **Example Model:** To explore a complete example of an AUTOSAR software component, run the following command in the MATLAB command window:

    ```matlab
    openExample('autosar_swc')
    ```

---

### Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### **Internal Container Build Workflow (Admin / Collaborator)**

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [EHANDBOOK Container Request](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU/config.txt`

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
   `Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU/Input`

2. `Configuration file`:  
   `Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU/config.txt`

The **storage type** and **repository URL** are managed by the workflow and are not entered by the requester.

Internally, the trusted workflow uses:

- `storage_type`: `GIT`
- `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`

**Expected output:** The build generates an EHANDBOOK Container (.ehb) and a PDF when -pdf is specified in config.txt.



