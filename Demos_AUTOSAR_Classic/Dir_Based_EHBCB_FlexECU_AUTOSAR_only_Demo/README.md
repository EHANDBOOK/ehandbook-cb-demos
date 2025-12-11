# Demo: AUTOSAR Architecture-Only Build using `-ar2ehbcbinput`

**Objective:** This demo illustrates a two-step workflow for creating an EHANDBOOK container that documents *only* the AUTOSAR Classic architecture from a set of `.arxml` files, without any implementation models or code.

---

## ✨ Features Showcased

* **Two-Step Build Process:** A dedicated workflow for processing `.arxml` files.
* **`-ar2ehbcbinput` flag:** Use of a special flag to convert a folder of `.arxml` files into a valid EHB-CB input structure.
* **Architecture-Only Documentation:** The final handbook contains only the information derived from the AUTOSAR files (components, ports, interfaces, compositions), which is ideal for high-level architecture reviews.
* **No Implementation:** The source directory contains only `.arxml` files, with no corresponding ASCET or Simulink model files (`.axl` or `.slx`) or C-Code implementation files (`.c`).

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license for the AUTOSAR converter.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder.
* Open the generated `FlexECU_AUTOSAR_files.ehb` file.
* You will find a handbook that shows the full software architecture of the FlexECU demo, including all components and their connections, as defined in the `.arxml` files.
* Note that there are no detailed function diagrams, as no implementation was provided.

---

## ⚙️ Under the Hood

This demo showcases a specific, powerful workflow for generating architecture-level documentation directly from AUTOSAR files.

### The Two-Step Workflow in `build.bat`

The `build.bat` script orchestrates a two-step process:

#### Step 1: Convert ARXML to EHB-CB Input

```batch
md FlexECU_AUTOSAR_files_ehb_cb_input

%EHB_CB_PATH%\eHandbookCB.exe ^
-i "FlexECU_AUTOSAR_files" ^
-o "FlexECU_AUTOSAR_files_ehb_cb_input" ^
-ar2ehbcbinput
```

* First, a new directory (`FlexECU_AUTOSAR_files_ehb_cb_input`) is created to serve as a temporary input folder for the next step.
* `eHandbookCB.exe` is called with the `-ar2ehbcbinput` flag. This tells the tool: "Do not build a container. Instead, read all the `.arxml` files in the input directory (`-i`), and generate a valid EHANDBOOK Container-Build directory structure in the output directory (`-o`)."
* This generated structure will contain folders for each software component, with documentation files that EHB-CB can understand.

#### Step 2: Build the EHANDBOOK Container

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i "FlexECU_AUTOSAR_files_ehb_cb_input" ^
-n "FlexECU_AUTOSAR_files" ^
-o "./Output"
```

* The second call to `eHandbookCB.exe` is a standard directory-based build.
* Crucially, the input (`-i`) is now the temporary directory that was created and populated in Step 1.
* EHB-CB processes this generated structure to build the final, architecture-only EHANDBOOK container.

This two-step process is the recommended workflow for generating a handbook purely from `.arxml` files.
