# Demo: Including PDF Content via SVG Conversion

**Objective:** This demo illustrates a workflow for embedding content from an external PDF document into an EHANDBOOK container by converting the PDF pages into SVG images.

---

## ✨ Features Showcased

* A method to import legacy or external documentation from PDF files.
* Pre-processing of a PDF into individual SVG files using an external tool (example script provided).
* Inclusion of the generated SVG images into the EHANDBOOK documentation using standard AsciiDoc `image::` macros.
* Directory-based build to assemble the final container.

---

## 🛠️ How to Run

This demo involves a manual pre-processing step to simulate the conversion of a PDF to SVGs.

1. **Prerequisites:**
    * EHANDBOOK Container-Build.
    * **Inkscape** (or another PDF-to-SVG converter). The `makeSVG.bat` script assumes Inkscape is installed in its default location (`C:\Program Files\Inkscape\bin\inkscape`). If you have it elsewhere, you will need to edit the script.
    * A sample PDF file. The `makeSVG.bat` script assumes there is a `sampledata.pdf` in the `Demo_PDF` directory. (Note: This file is not included in the repository and you must provide your own).

2. **Pre-Processing (Convert PDF to SVG):**
    * Place your sample PDF file in this directory and name it `sampledata.pdf`.
    * Open a command prompt and run the `makeSVG.bat` script.
    * This will create a series of SVG files (`sampledata1.svg`, `sampledata2.svg`, etc.) in the current directory.
    * **Manually move these generated `.svg` files into the `Input\Function_A\` directory.**

3. **Build EHANDBOOK:**
    * Once the SVG files are in place, execute the `build.bat` script.
    * This will run the EHANDBOOK Container-Build process.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder.
* Open the generated `Demo_EHBCB_DirBased_PDF.ehb` file.
* Navigate to the documentation for "Function_A".
* You will see the content from your original PDF rendered as a series of images within the handbook, demonstrating the successful import.

---

## ⚙️ Under the Hood

This demo showcases a powerful workaround for including content from formats not natively supported by EHANDBOOK Container-Build.

### The Workflow

1. **`makeSVG.bat`**: This script provides an example of how to automate the conversion of a PDF to SVG files. It calls the Inkscape command-line tool for each page of the PDF.

    ```batch
    for /L %%n in (1,1,11) do "C:\Program Files\Inkscape\bin\inkscape" --pdf-page=%%n ...\sampledata.pdf -o ...\sampledata%%n.svg
    ```

2. **`Input/Function_A/`**: This directory is the destination for the pre-processed SVG files.
3. **`Input/Function_A/Fmc.adoc`**: This AsciiDoc file is where the magic happens. It uses the standard `image::` macro to embed each SVG file in the desired order, effectively reconstructing the PDF content within the EHANDBOOK documentation.

    ```asciidoc
    == PDF Documentation

    Further information from PDF source:

    === Page 1

    image::sampledata1.svg[Page 1]

    === Page 2

    image::sampledata2.svg[Page 2]
    ```

4. **`build.bat`**: This is a standard build script that processes the `Input` directory. Because the `.adoc` file uses standard image linking, no special parameters are needed for the EHB-CB call itself.

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_PDF" ^
-nomatlab ^
-gensvg
```
