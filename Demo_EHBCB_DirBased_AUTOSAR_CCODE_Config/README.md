# Demo: C-Code Configuration for AUTOSAR RTE Visualization

**Objective:** This demo provides a detailed example of how to configure the EHANDBOOK Container-Build C-Code converter to visually enhance the documentation of an AUTOSAR system by decorating Runtime Environment (RTE) API calls with specific icons.

---

## ✨ Features Showcased

* **Directory-based Build** for a C-Code project.
* **Advanced C-Code Metadata Configuration (`-ccodemeta`):** A deep dive into using an XML configuration file to improve the readability of C-Code diagrams.
* **AUTOSAR RTE Visualization:** Demonstrates how to map AUTOSAR RTE function calls (e.g., `Rte_IWrite`, `Rte_Call`, `Rte_Pim`) to custom icons, making the diagrams easier to understand.
* **Generic Function Decoration:** Shows that this technique is not limited to AUTOSAR and can be used to decorate any C function (like `LED_ON`/`LED_OFF`) with an icon.

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with a suitable license for the C-Code converter.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder and open the `Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config.ehb` file.
* Navigate to the function diagrams for the "Sender" or "Receiver" components.
* Observe how the standard C-Code function calls that interact with the AUTOSAR RTE are no longer generic blocks. Instead, they are represented by meaningful icons (e.g., port icons for read/write, a gear icon for a server call), as defined in the configuration.

---

## ⚙️ Under the Hood

The core of this demo is the C-Code metadata file, which acts as a "style guide" for the C-Code converter.

### Directory & File Structure

* **`Input/`**: Contains the source C-Code and AUTOSAR `.arxml` files, organized into subdirectories.
* **`CCodeConfig/`**: This is the most important directory in this demo.
  * **`ccode_config.xml`**: This file contains the mapping rules. It tells EHB-CB how to visualize specific C functions.
  * **`images/`**: This subdirectory holds all the `.png` icon files that are referenced in the `ccode_config.xml`.

### C-Code Metadata Configuration: `ccode_config.xml`

This file allows you to define visual properties for functions matched by name (including wildcards). Let's look at an example from the file:

```xml
<!--START : AUTOSAR RTE API -->
<function name="Rte_IWrite(.*)" imageURI="images/AR_PPort.png" comment="Perform an implicit write...">
    <argument name="Rte_instance" portLocation="BOTTOM" isInstance="false" isReference="true"/>
    <argument name="input" portLocation="LEFT" isInstance="false" isReference="true"/>
</function>
```

* **`<function name="Rte_IWrite(.*)">`**: This rule applies to any function whose name starts with `Rte_IWrite`.
* **`imageURI="images/AR_PPort.png"`**: This specifies that the function call should be rendered using the `AR_PPort.png` icon from the `images` directory.
* **`comment="..."`**: This provides a tooltip for the block in the final EHANDBOOK.
* **`<argument ...>`**: These tags define how the function's arguments are treated and where their data-flow lines should connect to the block (e.g., `LEFT`, `BOTTOM`, or `INVISIBLE`).

### Build Script: `build.bat`

The build script ties everything together by passing the metadata file to the container build executable.

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\\Input" ^
-o ".\\Output" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_CCODE_Config" ^
-gensvg ^
-ccodemeta ".\\CCodeConfig\\ccode_config.xml"
```

* `-ccodemeta ".\\CCodeConfig\\ccode_config.xml"`: This crucial argument tells EHB-CB to apply the visualization rules from our XML file during the C-Code conversion process. This is what transforms a generic C-Code diagram into a clear, AUTOSAR-aware representation.
