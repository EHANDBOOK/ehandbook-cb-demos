# AI Agent Instructions for EHANDBOOK Container-Build Demos

This file provides guidance for AI agents working with the **EHANDBOOK Container-Build Demos** repository. Whether you're helping users understand existing demos, create new ones, or troubleshoot builds, this guide will help you work effectively with this codebase.

## 🎯 Repository Purpose

This repository contains **30+ demonstration projects** showcasing the capabilities of **EHANDBOOK Container-Build (EHB-CB)**, a powerful tool that automatically generates technical documentation in EHANDBOOK format from various source formats including:

- **ASCET models** (.esdl, .axl files)
- **Simulink models** (.slx files)
- **C-Code** (.c, .h files)
- **AUTOSAR Software Component Template files** (.arxml files)
- **AsciiDoc documentation** (.adoc files)
- **MATLAB scripts** (.m files)

Each demo is a self-contained example with input files, configuration, build scripts, and pre-built output containers (.ehb files).

## 🏗️ Repository Structure

```plain
ehandbook-cb-demos/
├── Demo_EHBCB_*/              # 30+ individual demo folders
│   ├── README.md               # Demo documentation (always read this first!)
│   ├── Input/                  # Source files and configurations
│   ├── Output/                 # Pre-built .ehb containers
│   ├── build.bat               # Windows build script
│   ├── configuration/          # (Optional) Build configurations
│   └── styling/                # (Optional) Custom styling files
├── .github/
│   ├── copilot-instructions.md # Copilot-specific guidance
│   └── CONTRIBUTING.md         # Contribution guidelines
├── docs/
│   ├── demo-template.md        # Template for new demo READMEs
│   └── building-all-demos.md   # Batch build documentation
├── set_tool_paths.bat          # Environment setup script
├── set_tool_paths.ps1          # PowerShell environment setup
├── build_all_demos.bat         # Build all demos (Windows)
├── build_all_demos.ps1         # Build all demos (PowerShell)
└── README.md                   # Main repository documentation
```

## 🔧 Prerequisites & Tool Setup

### Required Tools

Before running any builds or validating outputs, ensure these tools are properly installed:

1. **EHANDBOOK Container-Build (eHandbookCB.exe)**
   - Core tool for generating EHANDBOOK containers
   - Check installation: Run `eHandbookCB.exe -help`
   - Verify license availability before building

2. **Unified Graphics Generator (graphicGen.exe)**
   - Used for generating interactive models and SVG graphics from ASCET and Simulink models or C-Code.
     Used for incremental build approach with pre-generated artefacts.
   - Check installation: Run `graphicGen.exe -help`
   - Verify license availability before building

### Getting CLI Options

To discover available command-line options for the tools:

```batch
# For EHANDBOOK Container-Build
eHandbookCB.exe -help

# For Unified Graphics Generator
graphicGen.exe -help
```

### Environment Setup

**CRITICAL:** Before building any demo, users must set up their environment:

```batch
# Windows Command Prompt
set_tool_paths.bat

# PowerShell
.\set_tool_paths.ps1
```

This script sets the required environment variables pointing to the tool installations. **Builds will fail without proper environment setup.**

## 📋 Your Responsibilities as an AI Agent

You are empowered to:

✅ **Modify demo files** to fix issues or improve examples
✅ **Create new demos** following repository conventions
✅ **Run build scripts** to validate changes
✅ **Validate outputs** to ensure demos work correctly
✅ **Update documentation** to keep it accurate and helpful
✅ **Suggest improvements** to the repository structure or processes

## 🎓 Understanding Demos

### Step-by-Step Approach

When a user asks about a specific demo:

1. **Always read the demo's README.md first** – it contains:
   - Objective (what the demo shows)
   - Features demonstrated
   - How to run the demo
   - What to explore in the output
   - Technical details ("Under the Hood")

2. **Examine the Input/ folder structure** to see:
   - Source files (models, code, specifications)
   - Configuration files (.xml, .json)
   - Referenced libraries or dependencies

3. **Review the build.bat script** to understand:
   - Command-line arguments used
   - Build order and dependencies
   - Output file locations

4. **Check for additional resources**:
   - `configuration/` folder for build configs
   - `styling/` folder for custom styling
   - `Output/` folder for expected results

### Demo Naming Conventions

All demo folders follow this pattern:

```plain
Demo_EHBCB_<BuildType>_<SourceType>[_<Variant>]
```

Examples:

- `Demo_EHBCB_DirBased_SL_Simple` – Directory-based build with simple Simulink model
- `Demo_EHBCB_ASAMBased_AUTOSAR_SL` – ASAM-based build with AUTOSAR and Simulink
- `Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed` – Mixed source types

**BuildTypes:**

- `DirBased` – Files organized by directory structure
- `ASAMBased` – Uses ASAM-based configuration approach

**SourceTypes:**

- `SL` – Simulink models
- `CCODE` – C/C++ source code
- `AUTOSAR` – AUTOSAR XML specifications
- `ASCET` – ASCET models
- `AsciiDoc` – AsciiDoc documentation
- `Mscript` – MATLAB scripts

## 🏃 Running Builds

### Single Demo Build

```batch
# Navigate to demo folder
cd Demo_EHBCB_DirBased_SL_Simple

# Run the build
build.bat
```

### Building All Demos

```batch
# Windows Command Prompt
build_all_demos.bat

# PowerShell
.\build_all_demos.ps1
```

### Verifying Build Success

After a build completes:

1. **Check for the .ehb file** in the `Output/` folder
2. **Look for error messages** in the console output
3. **Verify file size** – .ehb files should not be empty
4. **Check timestamps** – ensure files were just created

### Common Build Issues

| Issue | Likely Cause | Solution |
|-------|-------------|----------|
| `'eHandbookCB.exe' is not recognized` | Environment not set up | Run `set_tool_paths.bat` |
| License errors | No valid license | Check license with `-help` option |
| Missing input files | Path issues | Verify paths in build.bat |
| Build hangs | Large models, resource limits | Check system resources, wait longer |

## ✨ Creating New Demos

### Step 1: Plan the Demo

Decide:

- What capability will this demo showcase?
- What source formats will it use?
- What build type (DirBased or ASAMBased)?

### Step 2: Create Demo Structure

```batch
# Create demo folder with proper naming
mkdir Demo_EHBCB_<BuildType>_<SourceType>[_<Variant>]

# Create standard subdirectories
mkdir Demo_EHBCB_YourDemo\Input
mkdir Demo_EHBCB_YourDemo\Output
```

### Step 3: Add Required Files

1. **Input files** – Place source files in `Input/` folder
2. **build.bat** – Create build script (see existing demos as reference)
3. **README.md** – Use the template in `docs/demo-template.md`

### Step 4: Build and Validate

```batch
# Build the demo
cd Demo_EHBCB_YourDemo
build.bat

# Verify the output
dir Output\*.ehb
```

### Step 5: Update Repository Documentation

Add your demo to the table in the main `README.md` file.

## 📝 Documentation Standards

When creating or updating documentation:

### README.md Structure

Follow this template structure (see `docs/demo-template.md`):

1. **Objective** – What does this demo show?
2. **Features** – Key capabilities demonstrated
3. **How to Run** – Step-by-step build instructions
4. **Explore the Output** – What to look for in the .ehb file
5. **Under the Hood** – Technical details and configuration

### Writing Style Guidelines

- **Be beginner-friendly** – Assume users are new to EHANDBOOK
- **Explain "what" and "why"** – Not just "how"
- **Use clear headings** – Make it easy to scan
- **Include code snippets** – Show exact commands
- **Link to related resources** – Reference other demos when relevant

### Markdown Formatting

```markdown
# Use H1 for the demo title
## Use H2 for major sections
### Use H3 for subsections

**Bold** for emphasis
`code` for commands and filenames
[links](path) for cross-references
```

## 🔍 Troubleshooting Guide

### For Users Asking "How do I...?"

| Question | Answer |
|----------|--------|
| "How do I run a demo?" | Navigate to the demo folder and run `build.bat` |
| "How do I view the output?" | Use EHANDBOOK-NAVIGATOR to open the .ehb file |
| "How do I install the tools?" | Visit <https://license.etas.com> for evaluation licenses |
| "How do I create my own demo?" | Follow the steps in [CONTRIBUTING.md](.github/CONTRIBUTING.md) |

### For Build Failures

1. **Verify environment setup** – Run `set_tool_paths.bat` first
2. **Check tool installation** – Run `eHandbookCB.exe -help`
3. **Verify license** – Check license status
4. **Review build script** – Look for typos or incorrect paths
5. **Check console output** – Read error messages carefully
6. **Consult demo README** – Look for special requirements

### For Understanding Output

Recommend users:

1. Install **EHANDBOOK-NAVIGATOR** (viewer application)
2. Open the `.ehb` file from the `Output/` folder
3. Explore the generated documentation structure
4. Compare with the input files to see the transformation

## 🌐 Useful Resources

- **EHANDBOOK Product Website**: <http://ehandbook.etas.com>
- **Container-Build Documentation**: <https://docs.etas.com/ehandbook/ehandbook/container_build.html>
- **License Evaluation**: <https://license.etas.com>
- **Contribution Guidelines**: [.github/CONTRIBUTING.md](.github/CONTRIBUTING.md)
- **Demo Template**: [docs/demo-template.md](docs/demo-template.md)

## 💡 Best Practices for AI Agents

### 1. Always Start with Documentation

Read the README.md before making assumptions. The documentation usually has the answer.

### 2. Test Your Changes

If you modify a demo or create a new one, always build it to verify it works.

### 3. Maintain Consistency

Follow existing patterns in demo structure, naming, and documentation style.

### 4. Be Helpful and Patient

Users may be new to EHANDBOOK concepts. Explain things clearly and provide examples.

### 5. Suggest, Don't Assume

When unsure about user intent, ask clarifying questions before making changes.

### 6. Reference Examples

Point users to existing demos that demonstrate what they're trying to do.

### 7. Document Your Changes

If you modify demos, update the README.md to reflect the changes.

## ⚠️ Important Reminders

1. **Environment Setup is Mandatory** – Builds will fail without `set_tool_paths.bat`
2. **Pre-built Outputs Exist** – Users can explore demos without building
3. **Avoid Large Files** – Keep demo files reasonably sized for repository storage
4. **Naming Matters** – All demo folders must start with `Demo_EHBCB_`
5. **License Required** – All builds require valid EHANDBOOK licenses
6. **Cross-Reference Wisely** – Link to related demos in documentation

## 🤝 Working with Users

### Your Role

You're here to help users:

- **Understand** how EHANDBOOK Container-Build works
- **Explore** the capabilities through demos
- **Create** their own documentation projects
- **Troubleshoot** build and configuration issues

### Communication Tips

- Use friendly, encouraging language
- Break complex topics into simple steps
- Provide concrete examples from the demos
- Acknowledge when something is confusing
- Offer to clarify or show alternatives

### When to Escalate

If users need:

- **Commercial licenses** → Direct to <https://license.etas.com>
- **Advanced support** → Point to ETAS support channels
- **Custom development** → Suggest consulting ETAS professional services

---

**Welcome to the EHANDBOOK Container-Build Demos community! Let's help users create amazing documentation together.** 🚀

*Last Updated: February 2026*
