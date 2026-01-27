# Demo: Directory-based EHB-CB with AsciiDoc

**Objective:** This demo illustrates how to use the directory-based EHANDBOOK Container-Build to generate an EHANDBOOK container from textual content written in AsciiDoc format. It showcases a variety of AsciiDoc features, including rich text formatting, image inclusion, and linking to interactive models.

---

## ✨ Features Showcased

* Directory-based input structure for a documentation-centric build.
* Processing of AsciiDoc (`.adoc`) files as the primary content source.
* A comprehensive example of AsciiDoc syntax for formatted text, lists, and tables.
* Embedding pre-existing images (e.g., `.svg`) into the documentation.
* Creating interactive links from images to model elements within the EHANDBOOK.
* Generating model overview images directly from AsciiDoc commands.
* Application of custom container styling.

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license for the AsciiDoc converter.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder.
* Open the generated EHANDBOOK file to see the rendered AsciiDoc content.

---

## ⚙️ Under the Hood

This demo highlights how to build an EHANDBOOK container primarily from AsciiDoc files, a powerful way to create rich, text-based documentation.

### Directory Structure

* **`Input/`**: Contains all the source artifacts for the build.
  * **`Documentation/`**: This folder holds the core content.
    * **`AsciiDocUserDocument.adoc`**: The main AsciiDoc file. It contains examples of text formatting, tables, lists, and special EHANDBOOK commands.
    * **`VectorImage.svg`**: An image file located alongside the `.adoc` file, ready to be embedded.
    * **`model_ICC.slx`**: A Simulink model that is referenced from the AsciiDoc file to create interactive links.
* **`styling/`**: Contains configuration files to apply a custom visual theme to the EHANDBOOK container.
* **`build.bat`**: The script that runs the directory-based EHANDBOOK Container-Build process. The build is controlled by the file types and directory structure, requiring no external configuration file.

### Model Referencing in AsciiDoc

A key feature shown in `AsciiDocUserDocument.adoc` is the ability to link documentation directly to model content. This is done with special syntax:

* **Link an existing image to a model:**
    This syntax embeds an image and makes it a clickable link to a model element in the EHANDBOOK.

    ```asciidoc
    image::VectorImage.svg[link=ehbmodelref:model_ICC]
    ```

* **Generate a model screenshot:**
    This command instructs EHANDBOOK Container-Build to generate a screenshot of a specific model hierarchy and embed it.

    ```asciidoc
    ehbmodelref::model_ICC/ICC_mdl[image_title]
    ```

* **Generate a function overview:**
    This command generates a block diagram showing the inputs and outputs of a function.

    ```asciidoc
    ehbfunctionoverview::Documentation[Title Name]
    ```


### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_AsciiDoc" ^
-gensvg ^
-nomatlab ^
-styling ".\styling" ^
-simlib "%MATLAB_PATH%\toolbox\simulink"
```

* `-i ".\Input"`: Specifies the input directory containing all source artifacts.
* `-o ".\Output"`: Specifies the output directory for the generated EHANDBOOK container.
* `-n "Demo_EHBCB_DirBased_AsciiDoc"`: Sets the name of the output file.
* `-gensvg`: Automatically generates SVG screenshots from the interactive models.
* `-nomatlab`: Instructs the builder to use its internal Simulink reader rather than launching MATLAB.
* `-styling ".\styling"`: Applies custom styling from the specified directory.
* `-simlib "%MATLAB_PATH%\toolbox\simulink"`: Specifies the path to Simulink library blocks.