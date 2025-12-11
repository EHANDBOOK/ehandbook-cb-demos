# Demo: Directory-based EHB-CB with Mixed Model Sources

**Objective:** This demo illustrates how to use the directory-based EHANDBOOK Container-Build to generate a single container from a project that combines function specifications from multiple different sources: an ASCET model, a Simulink model, and plain C-Code.

---

## ✨ Features Showcased

* Directory-based input structure for a mixed-source project.
* Processing of different function types in a single build, including:
  * An ASCET model (`.axl`)
  * A Simulink model (`.slx`)
  * A C-Code implementation
* Use of AsciiDoc (`.adoc`) files for textual documentation for each component.
* Use of Excel files (`.xlsx`) to define measurement signals and calibrations.

---

## 🛠️ How to Run

1. **Prerequisites:**
    * EHANDBOOK Container-Build with suitable licenses for ASCET, Simulink, and C-Code converters.
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory.
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

* After the build completes, navigate to the `Output/` folder.
* Open the generated EHANDBOOK file to see the different functions, each from a different source, integrated seamlessly into one container.

---

## ⚙️ Under the Hood

This demo showcases the power and flexibility of the directory-based build to automatically detect and integrate different types of source artifacts without needing a complex configuration file.

### Directory Structure

* **`Input/`**: This directory contains all the source artifacts, organized into subdirectories for each function. The build tool automatically identifies the type of each function based on the files it finds.
  * **`Function1/`**: Contains the artifacts for an ASCET-based function.
  * **`Function2/`**: Contains the artifacts for a Simulink-based function.
  * *(Note: A C-Code function would be structured similarly in its own folder)*
* **`Output/`**: This is the destination folder where the generated EHANDBOOK will be saved.
* **`build.bat`**: This script runs the EHANDBOOK Container-Build process. It relies on the directory structure and the types of files within the `Input` folder to correctly identify and process each component.
