# Demo: Directory-based EHB-CB with MATLAB Script for DocBlock Extraction

**Objective:** This demo extends the concept of script-based input generation by showing how a MATLAB m-script can extract textual documentation directly from Simulink DocBlocks and convert it into AsciiDoc format for the EHANDBOOK Container-Build.

---

## ✨ Features Showcased

* An advanced MATLAB script to automate the preparation of EHB-CB input data.
* Extraction of textual documentation from Simulink **DocBlocks**.
* Conversion of DocBlock content into structured AsciiDoc (`.adoc`) files.
* Generation of interface specifications (signals, calibrations) in Excel (`.xlsx`) format.

---

## 🛠️ How to Run

This demo involves a pre-processing step before the final build.

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license.
    * MATLAB with Simulink.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Generate Input Files:**
    * Open MATLAB.
    * Run the `Create_FunctionDocumentation_and_InterfaceSpec_from_Simulink_withDocBlocks.m` script.
    * When prompted, select the `InputBeforeScript` folder as the search path.
    * The script will process the `.slx` files, extract content from their DocBlocks, and generate the corresponding `.adoc` and `.xlsx` files into the `InputAfterScript` folder.

3. **Build the Container:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script, which uses the newly generated files in `InputAfterScript` to build the container.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder.
* Open the generated EHANDBOOK file. You will see a container where the textual documentation has been automatically populated from the content of the DocBlocks within the original Simulink models.

---

## ⚙️ Under the Hood

This demo enhances the automation workflow shown in the previous `m-script` example. By reading from DocBlocks, it allows developers to keep their documentation directly within the Simulink model, creating a "single source of truth."

### Directory Structure

* **`InputBeforeScript/`**: Contains the original source Simulink models (`.slx`), which include DocBlocks with textual content.
* **`Create_FunctionDocumentation_and_InterfaceSpec_from_Simulink_withDocBlocks.m`**: The MATLAB script that reads the models and their DocBlocks.
* **`InputAfterScript/`**: The destination for the script's output. The script populates this folder with the original models plus the generated `.adoc` (from DocBlocks) and `.xlsx` files.
* **`build.bat`**: The script that runs the EHANDBOOK Container-Build, using `InputAfterScript/` as its input.
* **`Output/`**: The destination folder for the final EHANDBOOK container.

### The MATLAB Script

The `Create_FunctionDocumentation_and_InterfaceSpec_from_Simulink_withDocBlocks.m` script extends the functionality of the previous version with a key addition:

1. **Finds Models:** It recursively searches a selected directory for Simulink models.
2. **Finds DocBlocks:** For each model, it specifically searches for DocBlocks.
3. **Extracts DocBlock Content:** It reads the textual content from within each DocBlock.
4. **Generates AsciiDoc:** It creates an `.adoc` file and populates it with the content extracted from the DocBlocks, preserving the documentation written in the model.
5. **Generates Excel Files:** It also extracts interface data (signals, parameters) and writes it to a structured `.xlsx` file.

### Build Script: `build.bat`

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\InputAfterScript" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_MScript_DocBlocks_To_AsciiDoc" ^
-gensvg ^
-nomatlab
```
