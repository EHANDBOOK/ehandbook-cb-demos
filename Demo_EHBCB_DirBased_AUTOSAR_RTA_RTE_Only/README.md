# Demo: AUTOSAR Architecture-Only Build from RTA-RTE Case Study

**Objective:** This demo illustrates the two-step workflow for creating an EHANDBOOK container that documents *only* the AUTOSAR Classic architecture from the `.arxml` files of the RTA-RTE (Real-Time Application - Runtime Environment) case study.

---

## ✨ Features Showcased

* **Two-Step Build Process:** A dedicated workflow for processing `.arxml` files using the `-ar2ehbcbinput` flag.
* **`-ar2ehbcbinput` flag:** Converts a folder of `.arxml` files into a valid EHANDBOOK Container-Build input structure.
* **Architecture-Only Documentation:** The final handbook contains only the information derived from the AUTOSAR files (components, ports, interfaces), which is ideal for high-level architecture reviews.
* **No Implementation:** The source directory contains only `.arxml` files, with no corresponding implementation models or code.

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
* Open the generated `RTA_RTE_Case_Study_AUTOSAR_files.ehb` file.
* You will find a handbook that shows the software architecture from the RTA-RTE case study, as defined in the `.arxml` files.
* Note that there are no detailed function diagrams, as no implementation was provided.

---

## ⚙️ Under the Hood

This demo showcases the recommended workflow for generating architecture-level documentation directly from a collection of AUTOSAR `.arxml` files.

### The Two-Step Workflow in `build.bat`

The `build.bat` script orchestrates a two-step process:

#### Step 1: Convert ARXML to EHB-CB Input

```batch
md RTA_RTE_Case_Study_AUTOSAR_files_ehb_cb_input

%EHB_CB_PATH%\eHandbookCB.exe ^
-i "RTA_RTE_Case_Study_AUTOSAR_files" ^
-o "RTA_RTE_Case_Study_AUTOSAR_files_ehb_cb_input" ^
-ar2ehbcbinput
```

* First, a new directory (`..._ehb_cb_input`) is created to serve as a temporary input folder for the next step.
* `eHandbookCB.exe` is called with the `-ar2ehbcbinput` flag. This tells the tool to read all the `.arxml` files in the input directory (`-i`) and generate a valid EHANDBOOK Container-Build directory structure in the output directory (`-o`).
* This generated structure will contain folders for each software component, with documentation files that EHB-CB can understand.

#### Step 2: Build the EHANDBOOK Container

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i "RTA_RTE_Case_Study_AUTOSAR_files_ehb_cb_input" ^
-n "RTA_RTE_Case_Study_AUTOSAR_files" ^
-o "./Output"
```

* The second call to `eHandbookCB.exe` is a standard directory-based build.
* The input (`-i`) is the temporary directory that was created and populated in Step 1.
* EHB-CB processes this generated structure to build the final, architecture-only EHANDBOOK container.


### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
# First, convert AUTOSAR ARXML files to EHB-CB input format
%EHB_CB_PATH%\eHandbookCB.exe ^
-i RTA_RTE_Case_Study_AUTOSAR_files ^
-o "RTA_RTE_Case_Study_AUTOSAR_files_ehb_cb_input" ^
-ar2ehbcbinput

# Then, build the EHANDBOOK container from the converted input
%EHB_CB_PATH%\eHandbookCB.exe ^
-i "RTA_RTE_Case_Study_AUTOSAR_files_ehb_cb_input" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only" ^
-o "./Output"
```

This demo uses a two-step build process:

1. **Convert AUTOSAR ARXML to EHB-CB Input Format:**
   * `-i RTA_RTE_Case_Study_AUTOSAR_files`: Specifies the directory containing AUTOSAR ARXML files.
   * `-o "RTA_RTE_Case_Study_AUTOSAR_files_ehb_cb_input"`: Specifies the output directory for the converted files.
   * `-ar2ehbcbinput`: Triggers the conversion from AUTOSAR format to EHB-CB input format.

2. **Build the EHANDBOOK Container:**
   * `-i "RTA_RTE_Case_Study_AUTOSAR_files_ehb_cb_input"`: Uses the converted files as input.
   * `-n "Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only"`: Sets the name of the output file.
   * `-o "./Output"`: Specifies the output directory for the generated EHANDBOOK container.