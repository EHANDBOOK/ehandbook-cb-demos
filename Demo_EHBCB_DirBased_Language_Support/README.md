# Demo: Directory-based EHB-CB with Multi-Language Support

**Objective:** This demo illustrates how to create an EHANDBOOK container with content in multiple languages, including English, Japanese, Korean, and Chinese. It specifically showcases how to configure the build to correctly render non-Latin fonts in generated PDF documents.

---

## ✨ Features Showcased

- Directory-based input structure with content in multiple languages.
- Use of AsciiDoc (`.adoc`) for documentation in English, Japanese, Korean, and Chinese.
- Custom styling to support Asian language fonts in PDF output.
- Configuration of PDF fonts via an XSL stylesheet (`PdfCustomization.xsl`).

---

## 🛠️ How to Run

1. **Prerequisites:**
    - EHANDBOOK Container-Build with a suitable license and PDF generator.
    - **Fonts:** Ensure you have fonts installed on your Windows system that support Japanese, Korean, and Chinese. Examples include "Yu Gothic Light" for Japanese, "Malgun Gothic" for Korean, and "Microsoft YaHei" for Chinese.
    - Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    - Open a command prompt or terminal.
    - Navigate to this directory.
    - Execute the `build.bat` script.

---

## 🔬 Explore the Output

- After the build completes, navigate to the `Output/` folder.
- Open the generated EHANDBOOK file (`.ehb`). The content for all languages should render correctly in the EHANDBOOK-NAVIGATOR.
- Open the generated PDF document. The Japanese, Korean, and Chinese text should also be rendered correctly, thanks to the font configuration.

---

## ⚙️ Under the Hood

This demo highlights the necessary configuration for supporting Asian languages in generated PDF documents, which requires special font handling.

### Directory Structure

- **`Input/`**: Contains the source documentation, organized by language.
  - **`English/`**, **`Japanese/`**, **`Korean/`**, **`Chinese/`**: Each folder contains an `.adoc` file with content in the respective language.
- **`styling/`**: Contains the styling configuration for the container and PDF output.
  - **`PdfCustomization.xsl`**: The key file for this demo. This XSL stylesheet is used to define which fonts the PDF generator should use for different text elements (titles, paragraphs, etc.).
- **`build.bat`**: The script that runs the EHANDBOOK Container-Build process.

### Supporting Asian Languages in PDF Documents

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_Language_Support" ^
-styling ".\\styling" ^
-pdf
```

While EHANDBOOK-NAVIGATOR typically renders Asian languages correctly out of the box, generating a PDF with these characters requires explicit font configuration.

1. **Font Installation:** The fonts you want to use must be installed on the Windows system where the PDF is being generated. You can check available fonts in `Settings > Personalization > Fonts`.

2. **Font Configuration:** The `styling/PdfCustomization.xsl` file tells the PDF generator which fonts to embed. To support a specific language, you must specify a suitable font in the `font-family` attribute for the relevant text elements.

    For example, to use the "Yu Gothic Light" font for Japanese chapter titles, the configuration would look like this:

    ```xml
    <!-- Chapter title -->
    <xsl:attribute-set name="topic.title">
      <xsl:attribute name="color">#000000</xsl:attribute>
      <xsl:attribute name="font-size">1.77em</xsl:attribute>
      <xsl:attribute name="font-family">Yu Gothic Light, sans-serif</xsl:attribute>
    </xsl:attribute-set>
    ```

By setting the appropriate `font-family` for each language, you ensure that the generated PDF can correctly display all characters.

For more details, see the [official documentation](https://docs.etas.com/ehandbook/ehandbook/how-to-guides/how-to-support-asian-languages-in-ehb-generated-pdf-documents.html).


---

### Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### **Internal Container Build Workflow (Admin / Collaborator)**

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [EHANDBOOK Container Request](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_Language_Support/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_Language_Support/config.txt`

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
   `Demo_EHBCB_DirBased_Language_Support/Input`

2. `Configuration file`:  
   `Demo_EHBCB_DirBased_Language_Support/config.txt`

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
-styling ".\styling"
-pdf
```

