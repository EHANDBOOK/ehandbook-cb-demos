# Quickstart

Welcome to the EHANDBOOK Container-Build Demos repository! This is your starting point.

## Before You Begin

Run the environment setup script once per terminal session:

```batch
REM Windows Command Prompt
set_tool_paths.bat

REM PowerShell
.\set_tool_paths.ps1
```

## Recommended First Demos

### No MATLAB Required

Start here if you do not have MATLAB/Simulink installed:

- [C-Code Basic Demo](../01-C-Code/01-Basic/README.md)  
  A simple C-code project — the fastest way to see EHANDBOOK Container-Build in action.

### Requires MATLAB/Simulink

If you have MATLAB/Simulink (R2021a or later) available:

- [Simulink Basic Demo](../02-Simulink/01-Basic/README.md)  
  Demonstrates advanced Simulink processing features with custom table configurations and library support.

## Repository Structure

The demos are organized into technology categories:

| Folder | Contents |
|--------|----------|
| `01-C-Code/` | C-Code documentation demos |
| `02-Simulink/` | Simulink model demos |
| `03-ASCET/` | ASCET model demos |
| `04-AUTOSAR/` | AUTOSAR architecture demos |
| `05-AsciiDoc/` | AsciiDoc documentation demos |
| `06-Mixed-Sources/` | Demos combining multiple source types |
| `07-Advanced-Features/` | Encryption, custom ToC, language support, etc. |
| `08-Toolbox-AddOns/` | ASCET and Simulink toolbox add-on demos |

## How to Run a Demo

1. Open a command prompt or PowerShell terminal.
2. Run `set_tool_paths.bat` (or `.\set_tool_paths.ps1`) from the repository root.
3. Navigate to the demo folder.
4. Execute `build.bat`.
5. Find the generated `.ehb` file in the `Output/` subfolder.

Open the `.ehb` file with **EHANDBOOK-NAVIGATOR** to explore the generated documentation.

## More Information

- See the [root README](../README.md) for the full demo catalog.
- See [CONTRIBUTING.md](../.github/CONTRIBUTING.md) for how to add your own demos.
- Visit <https://docs.etas.com/ehandbook/ehandbook/container_build.html> for full product documentation.
