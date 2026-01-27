# Demo: Directory-based EHB-CB with Custom Tables of Contents

**Objective:** This demo illustrates how to explicitly specify custom Tables of Contents (TOCs) for an EHANDBOOK container using a `tocs.yaml` file in a directory-based build.

---

## ✨ Features Showcased

* Directory-based input structure.
* Replacement of default TOCs with custom ones.
* Use of `tocs.yaml` to define multiple, custom-named TOCs.
* Creation of both flat and hierarchical navigation structures.
* Custom ordering and naming for all TOC entries.

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
* In the **Document Explorer**, you will see the custom TOCs defined in `tocs.yaml` instead of the default ones. You can switch between the "Alphabetic list of software components" and the hierarchical "Software architecture" views.

---

## ⚙️ Under the Hood

By default, the directory-based build automatically creates two TOCs: an alphabetical list of functions and a software architecture view based on the folder structure. This demo shows how to override that behavior with a `tocs.yaml` file to gain full control over the navigation.

### Directory Structure

* **`Input/`**: Contains the source artifacts and the TOC definition.
  * **`Composition_1/`, `Composition_2/`, `SWC_1/`, etc.**: These folders represent the different documentation units or software components.
  * **`tocs.yaml`**: The core of this demo. This file, placed in the root of the input directory, defines the structure and content of all tables of contents.
* **`styling/`**: Contains styling information for the container.
* **`build.bat`**: The script that runs the EHANDBOOK Container-Build process.

### Build Script: `build.bat`

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_Custom_Tocs" ^
-gensvg ^
-styling ".\\styling"
```

### Custom TOC Specification with `tocs.yaml`

The `tocs.yaml` file allows you to define one or more custom TOCs. The file has two main sections: `docuUnits` and `tocs`.

```yaml
docuUnits:  
  - id: SWC_1
    displayName: "Software Component 1"
  - id: SWC_2
    displayName: "Software Component 2"
  - id: SWC_n
    displayName: "Software Component n"
  - id: Composition_1
    displayName: "Composition 1"
  - id: Composition_2
    displayName: "Composition 2"
tocs:
  - displayName: Alphabetic list of software components
    contents:
    - idRef: SWC_1
    - idRef: SWC_2
    - idRef: SWC_n
  - displayName: Software architecture
    contents:
    - idRef: Composition_1  
      contents:
      - idRef: SWC_1
      - idRef: SWC_2
    - idRef: Composition_2
      contents:
      - idRef: SWC_n
```

* **`docuUnits`**: This section lists all the documentation chapters you want to reference in your TOCs.
  * `id`: The identifier for the documentation unit, which must match the name of the corresponding folder in the `Input/` directory.
  * `displayName`: The human-readable name that will be shown in the TOC.
* **`tocs`**: This section defines the actual TOCs. You can have one or more.
  * `displayName`: The name of the TOC as it will appear in the EHANDBOOK-NAVIGATOR's selection menu.
  * `contents`: A list of entries for that TOC.
  * `idRef`: A reference to one of the `docuUnits` defined above.
  * `contents` (nested): By nesting `contents` sections, you can create hierarchical TOCs, as shown in the "Software architecture" example.

For more details, see the [official documentation](https://docs.etas.com/ehandbook/ehandbook/how-to-guides/how-to-explicitly-specify-table-of-contents.html#_tocs_yaml_a_yaml_file_to_specify_table_of_contents).
