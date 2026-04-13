# Demo: EHB-CB Toolbox for Simulink

**Objective:** This demo shows how to use the EHANDBOOK Container-Build (EHB-CB) Simulink toolbox add-on to generate an EHANDBOOK container from a Simulink project.

---

## ✨ Features Showcased

* Simulink toolbox integration (Generate Documentation via Apps or Tools menu)
* Generation of EHANDBOOK Container (.ehb) directly from Simulink models
* Automatic processing of referenced models and function blocks
* Interactive documentation generation from block diagrams

---

## 🛠️ Prerequisites

* MATLAB/Simulink (R2021a or later recommended)
* The EHANDBOOK Container-Build Simulink toolbox add-on (installed in MATLAB)
* The demo includes example Simulink model files:
  * `Afr.slx` – Example model 1
  * `Fmc.slx` – Example model 2
  * `Tqs.slx` – Example model 3

---

## 🛠️ How to Run (Quick Steps)

1. Open MATLAB and load the Simulink model (e.g., `Afr.slx`, `Fmc.slx`, or `Tqs.slx`).
2. From the MATLAB menu, select **Apps** and find **ETAS EHANDBOOK Container-Build** or look in **Tools → ETAS EHANDBOOK → Generate Documentation**.
3. In the dialog, configure the EHANDBOOK Container details (title, version, output folder, etc.).
4. Press **Generate** to start the build process.
5. Wait for generation to complete. A progress indicator will show the status.
6. Once finished, the generated `.ehb` file will be placed in the specified output folder.
7. Open the `.ehb` file in EHANDBOOK-NAVIGATOR to explore the generated documentation.

---

## 🔬 Explore the Output

* After a successful run, the generated EHANDBOOK Container file will be placed in the `Output` folder of this demo.
* Open the `.ehb` file with EHANDBOOK-NAVIGATOR to browse the generated documentation.
* Verify that expected models, subsystems, and function blocks are correctly documented.
* Explore how block parameters, signal connections, and hierarchical structure are represented in the documentation.

---

## ⚙️ Under the Hood

### Directory Structure

* `Afr.slx` — Example Simulink model file 1
* `Fmc.slx` — Example Simulink model file 2
* `Tqs.slx` — Example Simulink model file 3
* `Output/` — Generated EHB-CB outputs, including `.ehb` container file

This demo is executed from within MATLAB/Simulink via the installed toolbox add-on and therefore does not include an automated `build.bat` script.

### Behavior Notes

* Only blocks and subsystems directly present in the selected Simulink model are processed and documented.
* Referenced models are included if they are properly referenced within the parent model.
* Library blocks are documented according to their implementation in the selected scope.
* Block masks, Simulink functions, and function blocks are automatically analyzed and documented.

### Generated Documentation Includes

* **Block Diagrams** – Visual representations of the model hierarchy
* **Function Specifications** – Input/output specifications for subsystems and function blocks
* **Block Properties** – Parameters, data types, and signal information
* **Cross-References** – Links between referenced models and blocks

---

## ❗ Troubleshooting

* **EHANDBOOK menu not visible:** Verify the Simulink toolbox add-on is properly installed. Check MATLAB Add-Ons or the Apps gallery.
* **Generation fails:** Ensure all referenced models are in the MATLAB search path. Check the error log for specific issues.
* **Missing blocks in output:** Verify that blocks are not masked as "not shown in documentation" properties. Check model hierarchy settings.
* **Output folder issue:** Confirm the output folder path is valid and you have write permissions.

---

## Important

Only models and blocks directly referenced in the selected Simulink project are processed. Unreferenced models or subsystems will not appear in the generated EHANDBOOK container.

To document additional models or variations, run the generation process separately for each root model or project.

---

For more information about the EHANDBOOK Container-Build Simulink integration, refer to the [official documentation](https://docs.etas.com/ehandbook/ehandbook/container_build.html).
