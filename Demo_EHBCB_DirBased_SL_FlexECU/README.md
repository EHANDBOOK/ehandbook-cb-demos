# Demo: Directory-based EHB-CB for a Complete FlexECU Project

**Objective:** This demo provides a comprehensive example of how to generate a complete ECU software documentation for a project with 15 functions, all based on Simulink models. It showcases a wide range of customization and configuration options.

---

## ✨ Features Showcased

* A complete, realistic ECU software documentation project.
* Directory-based build with 15 Simulink-based functions.
* **Custom Styling:** Application of a corporate look and feel using the `etas-styling` folder.
* **Custom Title Page:** Customization of the generated PDF's title page via `title_page.properties`.
* **Custom Table of Contents:** A `tocs.yaml` file to define a specific navigation structure.
* **Simulink Library Support:** Processing of an additional Simulink library from the `simlib` folder.
* **Root-Level Skipping:** Using a configuration file (`rootlevel.json`) to simplify the model hierarchy by skipping unnecessary top-level blocks.

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license for the Simulink converter and PDF generator.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder.
* Open the generated EHANDBOOK file (`.ehb`) and the accompanying PDF document.
* Notice the custom ETAS branding, the specific layout of the title page, and the navigation structure defined in the custom Table of Contents.
* When exploring the models, you will see that the top-level hierarchy block has been skipped, leading you directly to the core content.

---

## ⚙️ Under the Hood

This demo combines many of the advanced features of the EHANDBOOK Container-Build to create a polished, professional documentation container.

### Directory Structure

* **`Input/`**: Contains the source artifacts for all 15 functions, organized into subdirectories. It also includes the `tocs.yaml` for defining the TOC.
* **`simlib/`**: Contains a shared Simulink library that the function models depend on. The build process is configured to look in this folder via the `-simlib` argument.
* **`configuration/`**: Holds various JSON configuration files.
  * `rootlevel.json`: Specifies which root-level blocks in the Simulink models should be skipped to simplify the navigation hierarchy.
* **`styling/`**: A dedicated folder for branding and styling artifacts.
  * `branding.properties`, `commonltr.css`: Define the visual style (colors, fonts, logos) of the EHANDBOOK container.
  * `title_page.properties`, `title_page.svg`: Define the content and layout of the PDF title page.
* **`build.bat`**: The script that runs the build, referencing the various configuration and styling files.

### Build Script: `build.bat`

The build script highlights the essential arguments for this demo:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_SL_FlexECU" ^
-simlib ".\\simlib,%MATLAB_PATH%\\toolbox\\simulink" ^
-nomatlab ^
-gensvg ^
-styling ".\\styling" ^
-rootlevel ".\\configuration\\rootlevel.json"
```

* `-styling ".\\styling"`: This argument tells EHB-CB where to find the styling artifacts.
* `-rootlevel ".\\configuration\\rootlevel.json"`: This argument tells EHB-CB to skip the root level of the Simulink models.
* `-simlib ".\\simlib,..."`: This argument tells EHB-CB where to find the necessary Simulink libraries.
