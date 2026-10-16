# Demo: Directory-based EHB-CB with Simulink Entry/Exit Ports

**Objective:** This demo illustrates how EHANDBOOK Container-Build processes Simulink stateflow models that use **Entry** and **Exit** port blocks for signal routing across subsystem boundaries — all without requiring a MATLAB installation.

---

## ✨ Features Showcased

- **Entry/Exit Port Support:** The model uses `Inport` (Entry) and `Outport` (Exit) blocks to demonstrate signal routing across subsystem boundaries.
- **No-MATLAB Connection:** The container is generated using the internal Simulink model reader (`-nomatlab`), which significantly speeds up the build process.
- **Model-Only Input:** This demo uses only a Simulink model file (`.slx`) as input — no additional documentation files (`.adoc`) are included.

---

## 🛠️ How to Run

1. **Prerequisites:**
    - EHANDBOOK Container-Build with a suitable license for the Simulink converter.
    - Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    - Open a command prompt or terminal.
    - Navigate to this directory.
    - Execute the `build.bat` script.

---

## 🔬 Explore the Output

- After the build completes, navigate to the `Output/` folder.
- Open the generated EHANDBOOK file in EHANDBOOK Navigator.
- Observe how the `EntryExit_ports.slx` model uses Entry and Exit ports to route signals between subsystems without explicit wiring.

---

## ⚙️ Under the Hood

### Directory Structure

- **`Input/`**: Contains the Simulink model (`EntryExit_ports.slx`) to be processed.
- **`Output/`**: Destination for the generated EHANDBOOK container.
- **`build.bat`**: Build script that invokes `eHandbookCB.exe` with minimal options.

### Key Build Options

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_EntryExitPorts" ^
-nomatlab
```

- **`-nomatlab`**: Uses the internal Simulink model reader instead of launching MATLAB, resulting in a much faster build.
- No view configuration (`-simulinkview` or `-viewtype`) is used — all subsystem contents are visible by default.

---
###  Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### Details and direct link

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [Container-Build-Cloud-Service-demo.yml](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `02-Simulink/02-Entry-Exit-Ports/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `02-Simulink/02-Entry-Exit-Ports/config.txt`

**Expected output:** The build generates an EHANDBOOK Container file and - where configured - a corresponding PDF document.

---

### Configuration File: `config.txt`

The `config.txt` file includes the following build arguments for CB SaaS eHandbook container generation.

```text
-nomatlab
```
