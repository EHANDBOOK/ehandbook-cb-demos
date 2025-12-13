# Demo: Directory-based EHB-CB with Multi-Language Support

**Objective:** This demo illustrates how to create an EHANDBOOK container with content in multiple languages, including English, Japanese, Korean, and Chinese. It specifically showcases how to configure the build to correctly render non-Latin fonts in generated PDF documents.

---

## ✨ Features Showcased

* Directory-based input structure with content in multiple languages.
* Use of AsciiDoc (`.adoc`) for documentation in English, Japanese, Korean, and Chinese.
* Custom styling to support Asian language fonts in PDF output.
* Configuration of PDF fonts via an XSL stylesheet (`PdfCustomization.xsl`).

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license and PDF generator.
    * **Fonts:** Ensure you have fonts installed on your Windows system that support Japanese, Korean, and Chinese. Examples include "Yu Gothic Light" for Japanese, "Malgun Gothic" for Korean, and "Microsoft YaHei" for Chinese.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder.
* Open the generated EHANDBOOK file (`.ehb`). The content for all languages should render correctly in the EHANDBOOK-NAVIGATOR.
* Open the generated PDF document. The Japanese, Korean, and Chinese text should also be rendered correctly, thanks to the font configuration.

---

## ⚙️ Under the Hood

This demo highlights the necessary configuration for supporting Asian languages in generated PDF documents, which requires special font handling.

### Directory Structure

* **`Input/`**: Contains the source documentation, organized by language.
  * **`English/`**, **`Japanese/`**, **`Korean/`**, **`Chinese/`**: Each folder contains an `.adoc` file with content in the respective language.
* **`styling/`**: Contains the styling configuration for the container and PDF output.
  * **`PdfCustomization.xsl`**: The key file for this demo. This XSL stylesheet is used to define which fonts the PDF generator should use for different text elements (titles, paragraphs, etc.).
* **`build.bat`**: The script that runs the EHANDBOOK Container-Build process.

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


### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_Language_Support" ^
-styling ".\styling" ^
-pdf
```

* `-i ".\Input"`: Specifies the input directory containing all source artifacts.
* `-o ".\Output"`: Specifies the output directory for the generated EHANDBOOK container.
* `-n "Demo_EHBCB_DirBased_Language_Support"`: Sets the name of the output file.
* `-styling ".\styling"`: Applies custom styling from the specified directory.
* `-pdf`: Generates a PDF document from the container content.