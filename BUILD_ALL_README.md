# Build All Demos

This directory contains scripts to build all EHANDBOOK Container-Build demo projects automatically.

## Prerequisites

Before running any build script, ensure that:

1. The `EHB_CB_PATH` environment variable is set to point to your eHandbookCB installation
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

## Example Output

```plain
============================================================================
Building eHandbook-CB Demos
============================================================================

Using eHandbookCB from: C:\Tools\eHandbookCB

Found 33 demo(s) to build

------------------------------------------------------------------------
Processing: Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU
------------------------------------------------------------------------
[SUCCESS] Demo_EHBCB_ASAMBased_ASCET_PDF_FlexECU built successfully

------------------------------------------------------------------------
Processing: Demo_EHBCB_DirBased_SL_Enhanced
------------------------------------------------------------------------
[SUCCESS] Demo_EHBCB_DirBased_SL_Enhanced built successfully

...

============================================================================
Build Summary
============================================================================
Successful builds:       31
Failed builds:           0
Skipped (no build.bat):  2
Total duration:          00:15:42

Log file: build_all_demos_20251213_143022.log
============================================================================

All demos built successfully!
```

## Troubleshooting

### EHB_CB_PATH not set

If you see an error about `EHB_CB_PATH` not being set:

1. **PowerShell**: Run `.\set_tool_paths.ps1` (the build script will auto-load this if it exists)
2. **Batch**: Run `set_tool_paths.bat` then run the batch build script
3. Or manually set the environment variable to your eHandbookCB installation path:

   ```powershell
   $env:EHB_CB_PATH = "C:\Path\To\eHandbookCB"
   ```

### PowerShell execution policy

If you can't run the PowerShell script due to execution policy:

```powershell
# Temporarily allow script execution
Set-ExecutionPolicy -ExecutionPolicy Bypass -Scope Process
.\build_all_demos.ps1
```

Or run it explicitly:

```powershell
powershell -ExecutionPolicy Bypass -File .\build_all_demos.ps1
```

### Build failures

- Check the log file for detailed error messages
- Try building the failed demo individually to see full output
- Ensure all required tools and dependencies are installed
- Verify input files exist in the demo's `Input` directory

## Tips

1. **Use parallel builds** for faster execution when building all demos:

   ```powershell
   .\build_all_demos.ps1 -Parallel
   ```

2. **Test a subset** of demos first:

   ```powershell
   .\build_all_demos.ps1 -Filter "*Simple*"
   ```

3. **Check logs** for detailed error information if builds fail

4. **Clean outputs** before rebuilding if needed:

   ```powershell
   Get-ChildItem -Directory -Filter "Demo_*" | ForEach-Object {
       Remove-Item "$($_.FullName)\Output\*" -Recurse -Force -ErrorAction SilentlyContinue
   }
   ```
