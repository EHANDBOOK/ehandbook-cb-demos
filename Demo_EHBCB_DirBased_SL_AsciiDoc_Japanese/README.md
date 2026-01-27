# Demo: Directory-based EHB-CB with Japanese AsciiDoc for a Simulink Model

**Objective:** This demo illustrates how to provide Japanese documentation for a Simulink model using AsciiDoc and ensure it is rendered correctly in both the EHANDBOOK-NAVIGATOR and the generated PDF output.

---

## ✨ Features Showcased

* Directory-based build for a Simulink project (`.slx`).
* Use of an AsciiDoc file (`.adoc`) with **Japanese content** for textual documentation.
* Custom styling to support Japanese fonts in the PDF output.
* Configuration of PDF fonts via an XSL stylesheet (`PdfCustomization.xsl`).

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with suitable licenses for the Simulink converter and PDF generator.
    * **Font:** Ensure you have a Japanese font installed on your Windows system (e.g., "Yu Gothic", "Meiryo", "MS Mincho").
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder (it will be created if it doesn't exist).
* Open the generated EHANDBOOK file (`.ehb`). The Japanese content from `Lcc.adoc` will be displayed alongside the interactive Simulink model.
* Open the generated PDF document. The Japanese text should be rendered correctly, thanks to the font configuration.

---

## ⚙️ Under the Hood

This demo focuses on combining a standard Simulink model with non-English documentation, highlighting the necessary configuration for correct PDF generation.

### Directory Structure

* **`Lcc/`**: The main input folder for the "Lcc" function.
  * `Lcc.slx`: The Simulink model file.
  * `Lcc.adoc`: The AsciiDoc file containing the textual documentation in Japanese.
  * `Lcc.xlsx`: An Excel file defining the function's interface.
* **`styling/`**: Contains styling information, including the crucial XSL stylesheet for PDF font settings.
  * `PdfCustomization.xsl`: This file is configured to tell the PDF generator to use a Japanese-capable font.
* **`build.bat`**: The script that runs the EHANDBOOK Container-Build process.

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
