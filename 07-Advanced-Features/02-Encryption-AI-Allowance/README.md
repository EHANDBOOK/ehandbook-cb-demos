# Demo: Encrypted Container - AI Allowance

**Objective:** This demo shows how to enable AI usage for an existing encrypted EHANDBOOK container by repackaging it with the `-allowai` parameter.

The demo uses an existing encrypted `.ehbcrypt` container as input. The input container is copied to the output location and repackaged with AI usage enabled.

---

## ✨ Features Showcased

- **Encrypted container repackage** using an existing `.ehbcrypt` container
- **AI usage enablement** using the `-allowai` parameter
- **Password-protected container** using `-epwd`
- **Preservation of the original input container**
- **Optional container name** using `-n`
- **Automatic `_Ai_Allowed` suffix** when generating the repackaged container name

---

## 🛠️ How to Run

1. **Prerequisites:**
   - Ensure you have run the `set_tool_paths.bat` script in the repository root.
   - A command prompt or terminal (Windows)
   - An existing encrypted `.ehbcrypt` container

2. **Build:**
   - Open a command prompt.
   - Navigate to this directory: `07-Advanced-Features/02-Encryption-AI-Allowance`
   - Execute the `build.bat` script.

3. **Result:**
   - A new AI-enabled encrypted .ehbcrypt container is generated in the Output/ folder. The original input container remains unchanged.
   - The container is protected with the password `DemoPassword123`.

4. **Password Requirement**
   - When repackaging an existing encrypted .ehbcrypt container with -allowai, the password provided with -epwd or -epwdf must be the same password used to encrypt the input container.
   - The password is required to access and repackage the input encrypted container. A different password cannot be used for the repackaging operation.
   - **NOTE**: The password used in this demo is DemoPassword123.

5. **Container Name**
   - The -n parameter is optional when repackaging an existing encrypted container.
   - If -n is provided, the specified name is used as the base name and \_Ai_Allowed is added to it.
   - If -n is not provided, the output name is derived from the input container name.

6. ** Password Options**
   - The -allowai parameter can be used with both supported password input formats when repackaging an encrypted container: **-epwd** and **-epwdf**

---

## 🔬 Explore the Output

- After a successful build, navigate to the `Output/` folder.
- Locate the generated .ehbcrypt container.
- Open the generated container using EHANDBOOK-NAVIGATOR.
- Enter the password of the original encrypted container when prompted.
- Verify that AI usage is enabled for the repackaged container.
- Compare the generated container with the original input container. The original encrypted container in the Input/ folder is not modified.

---

## ⚙️ Under the Hood

### Directory Structure

- `Input/`: Contains the existing encrypted .ehbcrypt container used for repackaging.
- `Output/`: Destination for the newly generated AI-enabled encrypted container.
- `build.bat`: Batch script that invokes `eHandbookCB.exe` with encryption parameters and AI allowance parameters.

### Configuration Deep Dive

**Key Flags Used:**

| Flag                                | Purpose                                         |
| ----------------------------------- | ----------------------------------------------- |
| `-i ".\Input\<container>.ehbcrypt"` | Existing encrypted container used as input      |
| `-o ".\Output"`                     | Output directory for the repackaged container   |
| `-n <name>`                         | Optional base name for the repackaged container |
| `-epwd "DemoPassword123"`           | Password of the input encrypted container       |
| `-allowai`                          | Enables AI usage for the encrypted container    |

**Why `-epwd`?**

The `-epwd` parameter is used to provide the password of the existing encrypted input container.

When repackaging an encrypted `.ehbcrypt` container with `-allowai`, the provided password must match the password originally used to encrypt the input container.

**Security Note:** For production or sensitive documentation, consider using `-epwdf` (password from file) instead, as it keeps passwords out of build scripts.

---

## See Also

- **03-Encryption-Full** — Use `-epwdf` to store passwords in a file (more secure).
- **04-Encryption-Simple** — Generate a new encrypted EHANDBOOK container using the standard Container Build flow.
- **CLAUDE.md** — Repository documentation and eHandbookCB.exe flag reference.
- **EHANDBOOK docs:** https://docs.etas.com/ehandbook/ehandbook/ehb-cb/container-build.html

---
