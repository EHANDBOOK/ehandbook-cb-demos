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
