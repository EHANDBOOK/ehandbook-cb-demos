# Demo: Directory-based EHB-CB with Simulink From/Goto Blocks

**Objective:** This demo illustrates how EHANDBOOK Container-Build processes Simulink models that use **From** and **Goto** blocks with different tag visibility scopes (**local**, **scoped**, and **global**), and how the generated EHANDBOOK Navigator lets you navigate between related From/Goto blocks — all without requiring a MATLAB installation.

---

## ✨ Features Showcased

- **From/Goto Block Support:** Three Simulink models demonstrate `From` and `Goto` blocks with different tag visibility scopes — **local**, **scoped**, and **global**.
- **Navigate to Related Blocks:** The generated EHANDBOOK containers support bidirectional navigation between From and Goto blocks via the context menu and toolbar dropdown.
- **Tag Visibility Scopes:** Each model showcases a different scope, affecting which related blocks appear in the Related Blocks list.
- **No-MATLAB Connection:** The containers are generated using the internal Simulink model reader (`-nomatlab`), which significantly speeds up the build process.
- **Model-Only Input:** This demo uses only Simulink model files (`.slx`) as input — no additional documentation files (`.adoc`) are included.

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
- Three models are included, each demonstrating a different tag visibility scope:

### Input Models

| Model | File | Tag Visibility | Description |
|---|---|---|---|
| **Local** | `Input/Local_In/Local_In.slx` | Local | Goto and From blocks within the same subsystem. Only related From blocks in the same subsystem are shown. |
| **Scoped** | `Input/Scoped_In/Scoped_In.slx` | Scoped | Goto block with a Goto Tag Visibility block defining the scope boundary. Related From blocks within the scope are shown, plus the Goto Tag Visibility block itself. |
| **Global** | `Input/Global_In/Global_In.slx` | Global | Goto block with global visibility. All related From blocks anywhere in the model are shown. |

### Navigating Between Related From/Goto Blocks

EHANDBOOK Navigator provides a **Navigate to Related Blocks** feature that lets you jump directly between connected From and Goto blocks — even when they are scattered across different subsystems. No additional configuration is required; the feature is available by default for all Simulink models processed by EHB-CB.

**From a Goto block:** The Related Blocks list shows all From blocks that receive the signal. For scoped visibility, the Goto Tag Visibility block that defines the scope boundary is also included.

**From a From block:** The Related Blocks list shows the source Goto block that provides the signal.

You can access the Related Blocks list in two ways:

1. **Context Menu:** Right-click a From or Goto block and look for the *Related Blocks* section in the context menu.
2. **Toolbar Dropdown:** Select a From or Goto block, then use the *Navigate to Related Blocks* dropdown in the diagram editor toolbar.

When you click an entry, the Navigator automatically expands the necessary subsystems, centers the view on the target block, and highlights it with a green rectangle.

> **Note:** Navigation works in both directions. A From block always has exactly one related Goto block, but a Goto block can have multiple related From blocks.

### Tag Visibility Scopes

The Navigate to Related Blocks feature respects the tag visibility setting configured on the Goto block in Simulink:

| Tag Visibility | Navigation Behavior |
|---|---|
| **Local** | Only related From blocks within the same subsystem are shown. |
| **Scoped** | Only related From blocks within the scope defined by the Goto Tag Visibility block are shown. The Goto Tag Visibility block itself also appears in the Related Blocks list. |
| **Global** | All related From blocks in the model are shown. |

#### Local Example

In the `Local_In.slx` model, the Goto block uses **local** tag visibility. When you select the `Goto` block, the Related Blocks list shows only the `From` block(s) within the same subsystem — no blocks from other subsystems appear.

#### Scoped Example

In the `Scoped_In.slx` model, the Goto block uses **scoped** tag visibility with a `Goto Tag Visibility` block defining the scope boundary. When you select the `Goto` block, the Related Blocks list shows:
- The `From` block(s) within the scoped boundary (e.g., inside child subsystems)
- The `Goto Tag Visibility` block that defines the scope boundary

#### Global Example

In the `Global_In.slx` model, the Goto block uses **global** tag visibility. When you select the `Goto` block, the Related Blocks list shows **all** `From` blocks sharing the same tag anywhere in the model, regardless of subsystem hierarchy.

> **Note:** ClickPic navigation is currently not supported for From and Goto blocks. Selecting these blocks through ClickPic will not navigate to their related blocks.

---

## ⚙️ Under the Hood

### Directory Structure

- **`Input/Local_In/`**: Contains the Simulink model (`Local_In.slx`) demonstrating **local** tag visibility.
- **`Input/Scoped_In/`**: Contains the Simulink model (`Scoped_In.slx`) demonstrating **scoped** tag visibility with a Goto Tag Visibility block.
- **`Input/Global_In/`**: Contains the Simulink model (`Global_In.slx`) demonstrating **global** tag visibility.
- **`Output/`**: Destination for the generated EHANDBOOK container.
- **`build.bat`**: Build script that invokes `eHandbookCB.exe` with minimal options.

### Key Build Options

The `build.bat` script uses the following command:

```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_FromGoto" ^
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

1. `demo_folder`: `02-Simulink/04-From-Goto/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `02-Simulink/04-From-Goto/config.txt`

**Expected output:** The build generates an EHANDBOOK Container file and - where configured - a corresponding PDF document.

---

### Configuration File: `config.txt`

The `config.txt` file includes the following build arguments for CB SaaS eHandbook container generation.

```text
-nomatlab
```
