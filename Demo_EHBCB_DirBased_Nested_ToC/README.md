# Demo: Directory-based EHB-CB with Nested Tables of Contents

**Objective:** This demo illustrates how to create deeply nested, hierarchical Tables of Contents (TOCs) for an EHANDBOOK container using a `tocs.yaml` file.

---

## ✨ Features Showcased

* Directory-based input structure.
* Use of `tocs.yaml` to define custom, multi-level TOCs.
* Creation of a deeply nested "Software architecture" view.
* Demonstration of how to structure the `tocs.yaml` to create parent-child relationships between documentation units.

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build (version 10.2 or newer).
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder.
* Open the generated EHANDBOOK file.
* In the **Document Explorer**, select the "Software architecture" TOC. You will see a multi-level hierarchy, with "ECU" at the top level, followed by compositions, and then the individual software components.

---

## ⚙️ Under the Hood

This demo builds on the concept of custom TOCs by showing how to create more complex, nested structures. This is achieved by nesting `contents` sections within the `tocs.yaml` file.

### Directory Structure

* **`Input/`**: Contains the source artifacts and the TOC definition.
  * **`ecu/`, `compo1/`, `swc1/`, etc.**: Folders representing the different documentation units that will be organized in the TOC.
  * **`tocs.yaml`**: The configuration file that defines the nested TOC structure.
* **`styling/`**: Contains styling information for the container.  
* **`Output/`**: The destination folder for the generated EHANDBOOK container.
* **`build.bat`**: The script that runs the EHANDBOOK Container-Build process.

### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_Nested_ToC"
-styling ".\\styling"
```

### Nested TOC Specification

The key to creating a nested TOC is the recursive structure of the `contents` property in the `tocs.yaml` file. By placing a `contents` list under an `idRef` entry, you make that entry a parent node in the hierarchy.

```yaml
docuUnits:
  - id: swc1
    displayName: "Software Component 1"
  - id: compo1
    displayName: "Composition 1"
  - id: ecu
    displayName: "ECU"    
tocs:
  - displayName: "Software architecture"
    contents:
    - idRef: ecu           # Level 1
      contents:
      - idRef: compo1      # Level 2
        contents:
        - idRef: swc1      # Level 3
        - idRef: swc2      # Level 3
```

* **Level 1 (Root):** The top-level `contents` list defines the root entries of the TOC. In this demo, the root is "ECU".
* **Level 2 (Children):** By adding a `contents` list under `idRef: ecu`, we make "Composition 1" and "Composition 2" children of "ECU".
* **Level 3 (Grandchildren):** By adding another `contents` list under `idRef: compo1`, we make "Software Component 1" and "Software Component 2" children of "Composition 1".

This method allows you to create arbitrarily deep and complex navigation structures that accurately reflect your software's architecture or any other desired organization.
