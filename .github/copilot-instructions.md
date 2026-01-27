# GitHub Copilot Instructions for EHANDBOOK Container-Build Demos

This file provides guidance to GitHub Copilot agents working on this repository.

## Repository Overview

This is the **EHANDBOOK Container-Build Demos** repository, containing 30+ demos showcasing the capabilities of EHANDBOOK Container-Build (EHB-CB), a tool for automatically generating technical documentation in EHANDBOOK format from various source formats.

**Key Technologies:**
- Simulink models
- C-Code
- AUTOSAR specifications
- ASCET models
- AsciiDoc documentation
- MATLAB scripting

**Repository Structure:**
- `Demo_EHBCB_*` folders: Individual demos
- `.github/`: GitHub-specific files (this file, contribution guidelines)
- `docs/`: Developer documentation
- Root-level scripts: Build all demos at once (`build_all_demos.bat`, `build_all_demos.ps1`)

## When Helping Users

### Understanding a Specific Demo

1. Always check the demo's **README.md** file first – it contains comprehensive documentation.
2. Look at the **Input/** folder structure to understand the source files.
3. Review the **build.bat** script to see how the demo is built.
4. Refer to the [EHANDBOOK Container-Build documentation](https://docs.etas.com/ehandbook/ehandbook/container_build.html) for technical details.

### Adding or Modifying Demos

1. Follow the [naming conventions](CONTRIBUTING.md#demo-naming-conventions) strictly.
2. Use the [demo template](../docs/demo-template.md) for new README.md files.
3. Ensure all demos include:
   - README.md with clear explanations
   - Input/ folder with source files and configurations
   - build.bat script
   - Output/ folder with pre-built .ehb file (after running build)
4. Update the demo table in the main [README.md](../README.md) when adding new demos.

### Building and Testing

- Users run individual demo builds with: `cd Demo_Name && build.bat`
- To build all demos: `build_all_demos.bat` or `.\build_all_demos.ps1`
- Prerequisites must be set up first via: `set_tool_paths.bat` (Windows) or `set_tool_paths.ps1` (PowerShell)

### Documentation Standards

- Keep READMEs clear and beginner-friendly
- Use the template structure: Objective → Features → How to Run → Explore Output → Under the Hood
- Include code snippets and configuration examples
- Explain both "what" and "why"

## Key Files and Their Purposes

| File/Folder | Purpose |
|-------------|---------|
| `.github/CONTRIBUTING.md` | Contribution guidelines for adding/modifying demos |
| `.github/copilot-instructions.md` | This file – guidance for Copilot agents |
| `docs/demo-template.md` | Template for creating new demo README files |
| `docs/building-all-demos.md` | Documentation about batch building all demos |
| `set_tool_paths.bat` | Script to set required environment variables |
| `build_all_demos.bat` / `build_all_demos.ps1` | Scripts to build all demos at once |
| `README.md` | Main repository documentation (public-facing) |

## Important Notes

1. **Environment Setup**: Users must run `set_tool_paths.bat` before building any demo.
2. **Output Files**: Pre-built .ehb containers are committed to the repo so users can explore without building.
3. **Large Files**: Avoid extremely large models or datasets in demos.
4. **Naming**: All demo folders must start with `Demo_` and follow the established naming conventions.
5. **Cross-references**: When referring to demos in documentation, use links to their README.md files.

## Common Tasks

### Task: Help user understand a demo
→ Start with the demo's README.md, then examine Input/ structure and build.bat

### Task: Help user create a new demo
→ Reference CONTRIBUTING.md, use the demo-template.md, follow naming conventions

### Task: Help user fix a failing build
→ Check environment variables (set_tool_paths.bat), review build.bat script, consult demo README

### Task: Help user explore generated output
→ Recommend using EHANDBOOK-NAVIGATOR to open the .ehb file from Output/ folder

## Useful Links

- **EHANDBOOK Product**: http://ehandbook.etas.com
- **EHB-CB Documentation**: https://docs.etas.com/ehandbook/ehandbook/container_build.html
- **EHANDBOOK-NAVIGATOR**: For viewing generated .ehb containers
- **License Evaluation**: https://license.etas.com

---

**Last Updated:** January 2026
