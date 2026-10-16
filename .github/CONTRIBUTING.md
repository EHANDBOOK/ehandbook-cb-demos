# Contributing to EHANDBOOK Container-Build Demos

Thank you for your interest in contributing to this repository! This guide will help you understand how to add new demos or modify existing ones.

## Table of Contents

- [Demo Naming Conventions](#demo-naming-conventions)
- [Creating a New Demo](#creating-a-new-demo)
- [Demo Structure](#demo-structure)
- [Getting Help](#getting-help)

## Repository Structure

Demos are organized into technology categories under numbered top-level folders:

```plain
00-Quickstart/
01-C-Code/
  01-Directory-Based/
  02-ASAM-Based/        (if applicable)
02-Simulink/
  01-Directory-Based/
  02-ASAM-Based/
03-ASCET/
04-AUTOSAR/
05-AsciiDoc/
06-Mixed-Sources/
07-Advanced-Features/
08-Toolbox-AddOns/
```

Each leaf folder contains a self-contained demo with `Input/`, `Output/`, `build.bat`, and `README.md`.

### Naming Convention for Demo Leaf Folders

Leaf demo folders use kebab-case descriptive names, e.g.:

- `01-Basic` – the simplest entry point for a category
- `02-Custom-Block-Config` – a named feature variant
- `10-With-Simulink-FlexECU` – technology combination

## Creating a New Demo

### Step 1: Plan Your Demo

Before creating the directory, decide:

1. **Type**: Is this a Directory-Based or ASAM-Based demo?
2. **Technologies**: Which source formats does it use (Simulink, C-code, AUTOSAR, ASCET, etc.)?
3. **Feature Focus**: What specific feature(s) does it demonstrate?
4. **Audience Level**: Is it Beginner, Intermediate, or Advanced?

### Step 2: Create the Demo Directory

Create a new leaf folder inside the appropriate category and build-type subfolder.

Example (adding a new C-Code demo):

```bash
mkdir 01-C-Code\01-Directory-Based\04-My-New-Feature
```

### Step 3: Create the README.md

Use the [demo template](../docs/demo-template.md) as your guide. Copy it into your demo folder as `README.md` and fill in all sections. The README should explain:

- What the demo illustrates
- Key features showcased
- How to run the demo
- Directory and file structure
- Configuration deep dive

### Step 4: Add Input Files

Create an `Input/` folder containing all source files and configurations needed for the build.

### Step 5: Add the Build Script

Create a `build.bat` script (or `.ps1` for PowerShell) that invokes EHANDBOOK Container-Build on your input files.

### Step 6: Build and Verify

1. Run the `build.bat` script locally to ensure it works.
2. Verify the output is generated in the `Output/` folder.
3. Test the generated EHANDBOOK Container with EHANDBOOK-NAVIGATOR.

### Step 7: Commit and Push

Add your new demo to the repository:

```bash
git add 01-C-Code/01-Directory-Based/04-My-New-Feature/
git commit -m "Add C-Code My-New-Feature demo"
git push
```

Don't forget to update the main [README.md](../README.md) with your new demo in the demo table.

## Demo Structure

Each demo leaf folder should follow this structure:

```plain
<category>/<build-type>/<nn-feature-name>/
├── README.md                    # Demo documentation (use template)
├── build.bat                    # Windows batch build script
├── build.ps1                    # PowerShell build script (optional)
├── Input/                       # Source files and configurations
│   ├── [source files]
│   ├── config.json              # Main EHB-CB configuration
│   └── [other configs as needed]
├── Output/                      # Generated output (created after build)
│   └── [demo_name].ehb          # Pre-built EHANDBOOK Container
└── [optional: additional folders for styling, includes, etc.]
```

### Input Folder Guidelines

- Place all source files (C-code, Simulink models, ARXML, etc.) here.
- Include all configuration files (JSON, YAML, XML).
- Organize files logically to reflect the documentation structure.
- Keep file sizes reasonable; avoid extremely large models or datasets.

### Output Folder Guidelines

- Include a pre-built `.ehb` file so users can explore the demo without building.
- Optionally include a PDF if the demo demonstrates PDF generation.
- Create this folder by running the `build.bat` script.

### Exceptions: Add-On and Multi-Step Demos

Some demos deviate from the standard structure due to their nature:

#### Add-On Toolbox Demos
Add-on demos (e.g., `08-Toolbox-AddOns/01-ASCET-Toolbox`, `08-Toolbox-AddOns/02-Simulink-Toolbox`) are executed from within external tools (ASCET, Simulink) rather than via command-line scripts. These demos:

- **Do NOT include** `build.bat` or `build.ps1` scripts
- **Include** a comprehensive `README.md` with step-by-step instructions and screenshots showing how to use the toolbox
- **Include** example input files (e.g., `.axl`, `.slx`) but NOT an `Input/` folder structure
- **Include** an `Output/` folder with pre-built `.ehb` output for users to explore

**Example:** See `08-Toolbox-AddOns/01-ASCET-Toolbox/README.md` for the pattern.

#### Multi-Step Build Demos
Some demos use multi-step builds (e.g., `07-Advanced-Features/07-UGG-iCB` with `step1_` and `step2_` scripts) or variant builds (e.g., `01-C-Code/03-References` with `build_with_hierarchies.bat` and `build_without_hierarchies.bat`). These demos:

- **Include** multiple `build.bat` files (or `build_variant.bat` files) instead of a single script
- **Document** each build variant in the README, explaining the difference and when to use each
- **Include** an `Output/` folder with pre-built results for each variant

**Example:** See `01-C-Code/03-References/README.md` for the pattern.

## Getting Help

If you have questions:

1. Check the [EHANDBOOK Container-Build documentation](https://docs.etas.com/ehandbook/ehandbook/container_build.html).
2. Review similar existing demos for reference.
3. Consult the [main README](../README.md) for overview information.

Thank you for contributing!
