# Demo: Encrypted Container - Simple (Password in Script)

**Objective:** This demo shows how to generate and encrypt an EHANDBOOK container using a plaintext password supplied directly in the build script with the `-epwd` flag.

---

## ✨ Features Showcased

* **Container encryption** with password-based protection
* **Command-line password** specification using `-epwd`
* **SVG graphic generation** for enhanced documentation
* **Quick-start approach** for learning encryption basics

---

## 🛠️ How to Run

1. **Prerequisites:**
   * Ensure you have run the `set_tool_paths.bat` script in the repository root.
   * A command prompt or terminal (Windows)

2. **Build:**
   * Open a command prompt.
   * Navigate to this directory (`Demo_EHBCB_DirBased_Encrypted_Container_Simple`).
   * Execute the `build.bat` script.

3. **Result:**
   * An encrypted `.ehb` file is generated in the `Output/` folder.
   * The container is protected with the password `DemoPassword123`.

---

## 🔬 Explore the Output

* After a successful build, navigate to the `Output/` folder.
* Locate the generated `.ehb` file.
* The container is now encrypted and will require a password to open or explore in EHANDBOOK-NAVIGATOR.
* Attempt to open it with EHANDBOOK-NAVIGATOR and note the password prompt.

---

## ⚙️ Under the Hood

### Directory Structure

* `Input/`: Contains mixed source files from ASCET, Simulink, and C-Code.
  * `ASCET/` — ASCET model and documentation
  * `Simulink/` — Simulink model files
  * `CCode/` — C-Code source files
* `Output/`: Destination for the generated encrypted EHANDBOOK container.
* `build.bat`: Batch script that invokes `eHandbookCB.exe` with encryption parameters.

### Configuration Deep Dive

**Key Flags Used:**

| Flag | Purpose |
|------|---------|
| `-i ".\Input"` | Input directory containing source documentation files |
| `-o ".\Output"` | Output directory for the encrypted `.ehb` file |
| `-n <name>` | Container name (appears in EHANDBOOK-NAVIGATOR) |
| `-epwd "DemoPassword123"` | **Encryption:** Password supplied directly in the script |
| `-gensvg` | Generate SVG graphics for models and diagrams |

**Why `-epwd`?**

The `-epwd` flag is the simplest way to encrypt a container. The password is passed directly as a command-line argument. This is useful for:
* **Learning:** Quick way to understand encryption
* **Automation:** Scripting builds with embedded passwords
* **Development:** Testing encryption without managing separate password files

**Security Note:** For production or sensitive documentation, consider using `-epwdf` (password from file) instead, as it keeps passwords out of build scripts.

---

## Next Steps

1. Add source files to the `Input/` folder (e.g., `.c` files, `.adoc` documents, `.slx` models).
2. Modify `build.bat` if you want to change the password or add additional flags (e.g., `-ccodemeta`).
3. Rebuild and verify the encrypted `.ehb` output.
4. Test opening the encrypted container in EHANDBOOK-NAVIGATOR to confirm password protection is working.

---

## See Also

* **Demo_EHBCB_DirBased_Encrypted_Container_File** — Use `-epwdf` to store passwords in a file (more secure).
* **CLAUDE.md** — Repository documentation and eHandbookCB.exe flag reference.
* **EHANDBOOK docs:** https://docs.etas.com/ehandbook/ehandbook/container_build.html

---
###  Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### Details and direct link

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [Container-Build-Cloud-Service-demo.yml](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_Encrypted_Container_Simple/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_Encrypted_Container_Simple/config.txt`

**Expected output:** The build generates an EHANDBOOK Container file and - where configured - a corresponding PDF document.

---

* **`config.txt`**: This contains the arguments used during the Container-Build process. These arguments are utilized by the EHB-CB Cloud Service container generation workflow to configure the build. By default, the -i, -o, and -n arguments are provided by the EHB-CB Cloud API call, so they do not need to be specified in the config.txt file unless explicitly required.

### Configuration File: `config.txt`

The `config.txt` file includes the following build arguments for CB SaaS eHandbook container generation.

```text
-epwd "DemoPassword123"
-gensvg
-nomatlab
```
