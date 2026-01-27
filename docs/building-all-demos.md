# Building All Demos

This document explains how to build all EHANDBOOK Container-Build demo projects automatically using the provided scripts.

## Prerequisites

Before running any build script, ensure that:

1. The `EHB_CB_PATH` environment variable is set to point to your EHANDBOOK Container-Build installation
2. All required dependencies (MATLAB, AUTOSAR tools, etc.) are properly configured

### Setting Environment Variables

**For PowerShell:**

```powershell
.\set_tool_paths.ps1
```

**For Command Prompt:**

```batch
set_tool_paths.bat
```

**Note:** The PowerShell build script will automatically load `set_tool_paths.ps1` if the environment variables are not set and the file exists.

## Scripts

### build_all_demos.bat (Windows Batch)

A simple batch script that builds all demos sequentially.

**Usage:**

```batch
build_all_demos.bat
```

**Features:**

- Builds all demos with `build.bat` files
- Creates a timestamped log file
- Shows summary of successful, failed, and skipped builds
- Returns error code if any builds fail

### build_all_demos.ps1 (PowerShell)

An advanced PowerShell script with more options and better error handling.

**Basic Usage:**

```powershell
.\build_all_demos.ps1
```

**Advanced Options:**

```powershell
# Build demos in parallel (faster)
.\build_all_demos.ps1 -Parallel

# Build only AUTOSAR-related demos
.\build_all_demos.ps1 -Filter "*AUTOSAR*"

# Continue building even if some demos fail
.\build_all_demos.ps1 -ContinueOnError

# Combine options
.\build_all_demos.ps1 -Parallel -Filter "*DirBased*" -ContinueOnError
```

**Parameters:**

- `-Parallel`: Build demos in parallel for faster execution (uses 4 threads)
- `-Filter`: Pattern to filter which demos to build (default: `"Demo_*"`)
- `-ContinueOnError`: Continue building remaining demos even if some fail

**Features:**

- Sequential or parallel execution
- Filter demos by name pattern
- Colored console output
- Detailed logging with timestamps
- Duration tracking
- Better error handling

## Output

Both scripts create a timestamped log file in the format:

```plain
build_all_demos_YYYYMMDD_HHMMSS.log
```

The log contains:

- Build status for each demo
- Error messages for failed builds
- Summary with counts and timing

## Tips

- Use the PowerShell script for better control and faster execution with `-Parallel`
- Use the batch script for simple, sequential builds on systems without PowerShell
- Always check the log file if any demos fail to identify the issue
- Run `set_tool_paths` before executing the build scripts for the first time
