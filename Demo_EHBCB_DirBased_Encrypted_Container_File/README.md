# Demo: Encrypted Container - Password from File

**Objective:** This demo shows how to generate and encrypt an EHANDBOOK container by reading the password from a text file using the `-epwdf` flag, a more secure approach for production builds.

---

## ✨ Features Showcased

- **Container encryption** with file-based password management
- **Password file** approach using `-epwdf` for improved security
- **Separation of concerns** — passwords isolated from build scripts
- **SVG graphic generation** for enhanced documentation
- **Production-ready workflow** for automated and secure builds

---

## 🛠️ How to Run

1. **Prerequisites:**
   - Ensure you have run the `set_tool_paths.bat` script in the repository root.
   - A command prompt or terminal (Windows)

2. **Setup:**
   - Create a `password.txt` file in the demo root folder.
   - Add a single line containing your password (e.g., `SecurePassword123`).
   - Save and close the file.

3. **Build:**
   - Open a command prompt.
   - Navigate to this directory (`Demo_EHBCB_DirBased_Encrypted_Container_File`).
   - Execute the `build.bat` script.

4. **Result:**
   - An encrypted `.ehb` file is generated in the `Output/` folder.
   - The container is protected with the password from `password.txt`.

---

## 🔬 Explore the Output

- After a successful build, navigate to the `Output/` folder.
- Locate the generated `.ehb` file.
- The container is encrypted and will require the password to open in EHANDBOOK-NAVIGATOR.
- Attempt to open it with EHANDBOOK-NAVIGATOR and enter the password you specified in `password.txt`.

**Note:** You can change the password by editing `Input/password.txt` and rebuilding — no need to modify the build script.

---

## ⚙️ Under the Hood

### Directory Structure

- `password.txt`: Single-line text file containing the encryption password (in demo root).
- `Input/`: Contains mixed source files from ASCET, Simulink, and C-Code.
  - `ASCET/` — ASCET model and documentation
  - `Simulink/` — Simulink model files
  - `CCode/` — C-Code source files
- `Output/`: Destination for the generated encrypted EHANDBOOK container.
- `build.bat`: Batch script that invokes `eHandbookCB.exe` with password-file encryption.

### Configuration Deep Dive

**Key Flags Used:**

| Flag | Purpose |
|------|---------|
| `-i ".\Input"` | Input directory containing source documentation files and password file |
| `-o ".\Output"` | Output directory for the encrypted `.ehb` file |
| `-n <name>` | Container name (appears in EHANDBOOK-NAVIGATOR) |
| `-epwdf ".\password.txt"` | **Encryption:** Read password from specified text file |
| `-gensvg` | Generate SVG graphics for models and diagrams |

**Why `-epwdf`?**

The `-epwdf` flag reads encryption passwords from an external file. This approach offers several advantages:
- **Security:** Passwords are not embedded in build scripts or version control.
- **Flexibility:** Change passwords without modifying the build script.
- **Automation:** CI/CD pipelines can inject passwords at build time without exposing them in scripts.
- **Team Workflows:** Password files can be managed separately (e.g., in secure vaults, environment variables).

**Password File Format:**

The `password.txt` file should contain:
- A single line with the password (no extra spaces or line breaks).
- Example: `MySecurePassword123`

---

## Next Steps

1. Create or edit `password.txt` (in the demo root) with your chosen password.
2. Add source files to the `Input/` folder (C-Code, Simulink, AsciiDoc, etc.).
3. Modify `build.bat` if needed to add additional flags (e.g., `-ccodemeta`).
4. Rebuild and verify the encrypted `.ehb` output.
5. Test opening the container in EHANDBOOK-NAVIGATOR with the password from your file.

---

## Automation & CI/CD Integration

**Example: Injecting Password at Build Time**

In a CI/CD pipeline (Jenkins, GitHub Actions, Azure DevOps), you can generate the password file dynamically:

```bash
# Generate password.txt with a secret from your CI/CD system
echo $CONTAINER_PASSWORD > ./password.txt
./build.bat
```

This keeps passwords out of source control while maintaining full automation.

---

## See Also

- **Demo_EHBCB_DirBased_Encrypted_Container_Simple** — Use `-epwd` for inline passwords (simpler, less secure).
- **CLAUDE.md** — Repository documentation and eHandbookCB.exe flag reference.
- **EHANDBOOK docs:** https://docs.etas.com/ehandbook/ehandbook/container_build.html


---
###  Container-Build Cloud Service (SaaS)

Use this scenario to execute builds in a hosted environment without installing the CLI product locally.

#### Details and direct link

If you use the workflow definition you shared (`Create EHANDBOOK Demo Container`), you can trigger it as follows.

Direct workflow link: [Container-Build-Cloud-Service-demo.yml](https://github.com/EHANDBOOK/ehandbook-cb-demos/actions/workflows/Container-Build-Cloud-Service-demo.yml)

Use these values when filling the workflow inputs:

1. `demo_folder`: `Demo_EHBCB_DirBased_Encrypted_Container_File/Input`
2. `storage_type`: `GIT`
3. `storage_url`: `https://github.com/EHANDBOOK/ehandbook-cb-demos.git`
4. `config_File`: `Demo_EHBCB_DirBased_Encrypted_Container_File/config.txt`

**Expected output:** The build generates an EHANDBOOK Container file and - where configured - a corresponding PDF document.

---

- **`config.txt`**: This contains the arguments used during the Container-Build process. These arguments are utilized by the EHB-CB Cloud Service container generation workflow to configure the build. By default, the -i, -o, -n and -gensvg arguments are provided by the EHB-CB Cloud API call, so they do not need to be specified in the config.txt file unless explicitly required.

### Configuration File: `config.txt`

The `config.txt` file includes the following build arguments for CB SaaS eHandbook container generation.

```text
-epwdf ".\password.txt"
-nomatlab
```
