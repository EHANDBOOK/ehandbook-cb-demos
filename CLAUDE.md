# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Repository Overview

**EHANDBOOK Container-Build Demos** is a collection of 30+ self-contained demonstration projects showcasing the capabilities of the EHANDBOOK Container-Build (EHB-CB) tool. Each demo automatically generates technical documentation from source formats including Simulink models, C-Code, AUTOSAR specifications, ASCET models, AsciiDoc, and MATLAB scripts.

**Key Resources:**
- **AGENTS.md** – Comprehensive guide for AI agent workflows (read first for agent-specific context)
- **CONTRIBUTING.md** (.github/) – Contribution guidelines and demo creation standards
- **README.md** – Main repository documentation with full demo catalog

## Essential Commands

### Environment Setup (Required Before Any Build)
```batch
REM Windows Command Prompt
set_tool_paths.bat

REM PowerShell
.\set_tool_paths.ps1
```
Sets `EHB_CB_PATH`, `EHB_UGG_PATH`, and `MATLAB_PATH` environment variables. Builds will fail without this.

### Build a Single Demo
```batch
cd Demo_EHBCB_DirBased_CCODE_Simple
build.bat
```
Output appears in `./Output/` folder (typically a `.ehb` EHANDBOOK Container file).

### Build All Demos
```batch
build_all_demos.bat          REM Command Prompt
.\build_all_demos.ps1        REM PowerShell
```
Creates a timestamped log file and reports success/failure counts.

### Check Tool Availability
```batch
eHandbookCB.exe -help
graphicsGen.exe -help
```

## Architecture & Structure

### Directory Layout
```
ehandbook-cb-demos/
├── Demo_EHBCB_**/           # 30+ demo folders (self-contained)
│   ├── README.md            # Demo-specific documentation
│   ├── Input/               # Source files & configurations
│   ├── Output/              # Generated .ehb containers
│   ├── build.bat            # Runs eHandbookCB.exe
│   ├── configuration/       # (optional) Build configs
│   └── styling/             # (optional) Custom styling
├── set_tool_paths.bat/ps1   # Environment setup
├── build_all_demos.bat/ps1  # Batch build script
├── AGENTS.md                # AI agent guidance
└── CONTRIBUTING.md          # Contribution standards
```

### Demo Naming Convention
All demo folders follow this pattern:
```
Demo_EHBCB_<BuildType>_<SourceType>[_<Variant>]
```

**BuildTypes:** `DirBased` (directory-organized) | `ASAMBased` (ASAM configuration)

**SourceTypes:** `SL` (Simulink), `CCODE` (C-Code), `AUTOSAR`, `ASCET`, `AsciiDoc`, `Mscript`, or combinations like `ASCET_SL_CCODE`

**Examples:** `Demo_EHBCB_DirBased_SL_FlexECU`, `Demo_EHBCB_ASAMBased_AUTOSAR_SL`, `Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed`

### Typical Build Script Pattern
```batch
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_Name" ^
-ccodemeta ".\CCodeConfig\CCodeFunctionConfig.xml" ^
-gensvg ^
pause
```

Key flags:
- `-i` – Input directory
- `-o` – Output directory
- `-n` – Container name
- `-ccodemeta` – C-Code configuration (optional)
- `-gensvg` – Generate SVG graphics (optional)

## Working with Demos

### Understanding a Demo
1. **Read the demo's README.md** – Documents objective, features, how to run, what to explore
2. **Examine Input/ folder** – Source files, configurations, any model references
3. **Review build.bat** – Command-line arguments, build order, output location
4. **Check for additional resources** – Look for `configuration/`, `styling/`, or special requirements

### Modifying a Demo
- Edit source files in `Input/` folder
- Update `build.bat` if changing flags or structure
- Rebuild with `build.bat` to verify changes
- Update `README.md` to document changes
- Pre-built `.ehb` files in `Output/` can be regenerated after modifications

### Creating a New Demo
1. Plan: Decide BuildType, SourceTypes, and target audience (Beginner/Intermediate/Advanced)
2. Create folder: `Demo_EHBCB_<BuildType>_<SourceType>_<Feature>`
3. Create standard subdirectories: `Input/`, `Output/`
4. Add source files to `Input/`
5. Create `build.bat` (reference existing demos as templates)
6. Create `README.md` using the template in `docs/demo-template.md`
7. Build and validate: Run `build.bat` and verify `.ehb` output
8. Commit and update main `README.md` with demo entry

## Common Patterns & Gotchas

### Environment Variables
- These are set per session; not persistent across command prompt windows
- Must be set again if opening a new terminal
- Use system environment variables to make permanent (explained in `set_tool_paths.bat`)

### Build Failures
| Issue | Cause | Solution |
|-------|-------|----------|
| `'eHandbookCB.exe' not recognized` | Environment not set | Run `set_tool_paths.bat` |
| License errors | No valid license | Evaluate at https://license.etas.com |
| Missing input files | Path errors in build.bat | Verify paths relative to demo folder |
| Empty .ehb output | Build error not reported | Check console output for errors |

### Demo Organization
- All demos start with `Demo_EHBCB_` prefix (search/discovery)
- Each demo is self-contained (can be moved independently)
- Pre-built `.ehb` files let users explore without building
- Input files organized logically to reflect documentation structure

## File Standards

### README.md for Demos
Use the template at `docs/demo-template.md`. Include:
- **Objective** – What does this demo show?
- **Features** – Capabilities demonstrated
- **How to Run** – Step-by-step build instructions
- **Explore the Output** – What to look for in the .ehb file
- **Under the Hood** – Technical details and configuration

### Batch Script Standards
- Always include `pause` at the end (allows users to see output)
- Use line continuation with `^` for readability
- Include comment header explaining the script
- Reference environment variables set by `set_tool_paths.bat`

## Key Technologies & Tools

- **eHandbookCB.exe** – Core tool for generating EHANDBOOK containers
- **graphicsGen.exe** – Unified Graphics Generator for model graphics and SVG
- **MATLAB/Simulink** – Optional, for Simulink demos (R2021a or later recommended)
- **EHANDBOOK-NAVIGATOR** – Viewer for exploring `.ehb` container files (separate product)

## Useful References

- **EHANDBOOK docs:** https://docs.etas.com/ehandbook/ehandbook/container_build.html
- **Product overview:** http://ehandbook.etas.com
- **License evaluation:** https://license.etas.com
- **AGENTS.md** (this repo) – Comprehensive AI agent guidance
- **CONTRIBUTING.md** (this repo) – Contribution and naming conventions

## Important Notes for AI Agents

- **Demos are learning resources** – Before suggesting changes, understand the demo's teaching purpose
- **Test builds locally** – Always run `build.bat` after modifications to verify they work
- **Maintain consistency** – Follow existing naming conventions, structure, and documentation style
- **License awareness** – All builds require valid EHANDBOOK licenses; flag when users need evaluation licenses
- **Documentation-first approach** – The README files often contain answers; read them before assuming
- **Environment setup is mandatory** – Emphasize running `set_tool_paths.bat` to users; it's the #1 build failure cause
