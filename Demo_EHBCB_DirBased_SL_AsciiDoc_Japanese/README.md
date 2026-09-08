# Demo: Directory-based EHB-CB with Japanese AsciiDoc for a Simulink Model

**Objective:** This demo illustrates how to provide Japanese documentation for a Simulink model using AsciiDoc and ensure it is rendered correctly in both the EHANDBOOK-NAVIGATOR and the generated PDF output.

---

## ✨ Features Showcased

- Directory-based build for a Simulink project (`.slx`).
- Use of an AsciiDoc file (`.adoc`) with **Japanese content** for textual documentation.
- Custom styling to support Japanese fonts in the PDF output.
- Configuration of PDF fonts via an XSL stylesheet (`PdfCustomization.xsl`).

---

## 🛠️ How to Run

1. **Prerequisites:**
    - EHANDBOOK Container-Build with suitable licenses for the Simulink converter and PDF generator.
    - **Font:** Ensure you have a Japanese font installed on your Windows system (e.g., "Yu Gothic", "Meiryo", "MS Mincho").
    - Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    - Open a command prompt or terminal.
    - Navigate to this directory.
    - Execute the `build.bat` script.

---

## 🔬 Explore the Output

- After the build completes, navigate to the `Output/` folder (it will be created if it doesn't exist).
- Open the generated EHANDBOOK file (`.ehb`). The Japanese content from `Lcc.adoc` will be displayed alongside the interactive Simulink model.
- Open the generated PDF document. The Japanese text should be rendered correctly, thanks to the font configuration.

---

## ⚙️ Under the Hood

This demo focuses on combining a standard Simulink model with non-English documentation, highlighting the necessary configuration for correct PDF generation.

### Directory Structure

- **`Lcc/`**: The main input folder for the "Lcc" function.
  - `Lcc.slx`: The Simulink model file.
  - `Lcc.adoc`: The AsciiDoc file containing the textual documentation in Japanese.
  - `Lcc.xlsx`: An Excel file defining the function's interface.
- **`styling/`**: Contains styling information, including the crucial XSL stylesheet for PDF font settings.
  - `PdfCustomization.xsl`: This file is configured to tell the PDF generator to use a Japanese-capable font.
- **`build.bat`**: The script that runs the EHANDBOOK Container-Build process.

### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese" ^
-gensvg ^
-styling ".\\styling" ^
-labelconfig ".\\configuration\\LabelConfig.json" ^
-labelamendment ".\\configuration\\LabelAmendment.json" ^
-rootlevel ".\\configuration\\RootLevel.json" ^
-tableconfig ".\\configuration\\TableConfiguration.json" ^
-simlib ".\\FlexECU_Simulink_Library" ^
-pdf
```

### Supporting Japanese Content in PDF Documents

While the EHANDBOOK-NAVIGATOR can typically render Japanese text without special setup, generating a PDF requires you to explicitly configure a font that supports Japanese characters.

1. **Font Installation:** A suitable Japanese font must be installed on the Windows system where the PDF is generated.

2. **Font Configuration:** The `configuration/PdfCustomization.xsl` file is used to instruct the PDF generator which font to use. To render Japanese, a font that supports it must be listed in the `font-family` attribute for the desired text elements.

    For example, to use the "Yu Gothic" font for chapter titles, the configuration would look like this:

    ```xml
    <!-- Chapter title -->
    <xsl:attribute-set name="topic.title">
      ...
      <xsl:attribute name="font-family">Yu Gothic, sans-serif</xsl:attribute>
    </xsl:attribute-set>
    ```

This ensures that the generated PDF correctly embeds and displays the Japanese characters from the AsciiDoc file. For more details, see the [official documentation](https://docs.etas.com/ehandbook/ehandbook/how-to-guides/how-to-support-asian-languages-in-ehb-generated-pdf-documents.html).


---

### Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### **Internal Container Build Workflow (Admin / Collaborator)**

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [EHANDBOOK Container Request](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese/config.txt`

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
   `Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese/Input`

2. `Configuration file`:  
   `Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese/config.txt`

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
-labelconfig ".\configuration\LabelConfig.json" ^
-labelamendment ".\configuration\LabelAmendment.json" ^
-rootlevel ".\configuration\RootLevel.json" ^
-tableconfig ".\configuration\TableConfiguration.json" ^
-simlib ".\FlexECU_Simulink_Library" ^
-pdf
```
