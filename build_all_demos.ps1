# ============================================================================
# Build All Demos Script (PowerShell)
# ============================================================================
# This script builds all eHandbook-CB demo projects in the workspace.
# It iterates through each Demo_* directory and executes its build.bat file.
# 
# Usage:
#   .\build_all_demos.ps1                    # Build all demos sequentially
#   .\build_all_demos.ps1 -Parallel          # Build demos in parallel (requires PowerShell 7+)
#   .\build_all_demos.ps1 -Filter "*AUTOSAR*" # Build only matching demos
# ============================================================================

[CmdletBinding()]
param(
    [Parameter(HelpMessage="Build demos in parallel (requires PowerShell 7+)")]
    [switch]$Parallel,
    
    [Parameter(HelpMessage="Filter demos by name pattern (e.g., '*AUTOSAR*')")]
    [string]$Filter = "Demo_*",
    
    [Parameter(HelpMessage="Continue building even if some demos fail")]
    [switch]$ContinueOnError
)

# Initialize
$ErrorActionPreference = "Continue"
$startTime = Get-Date

# Check PowerShell version for parallel execution
if ($Parallel -and $PSVersionTable.PSVersion.Major -lt 7) {
    Write-Host "============================================================================" -ForegroundColor Red
    Write-Host "ERROR: Parallel execution requires PowerShell 7 or higher" -ForegroundColor Red
    Write-Host "============================================================================" -ForegroundColor Red
    Write-Host ""
    Write-Host "Current PowerShell version: $($PSVersionTable.PSVersion)" -ForegroundColor Yellow
    Write-Host ""
    Write-Host "Options:" -ForegroundColor Cyan
    Write-Host "  1. Run without -Parallel flag: .\build_all_demos.ps1" -ForegroundColor White
    Write-Host "  2. Install PowerShell 7+: https://aka.ms/powershell" -ForegroundColor White
    Write-Host "  3. Use pwsh.exe after installing: pwsh .\build_all_demos.ps1 -Parallel" -ForegroundColor White
    Write-Host ""
    Read-Host "Press Enter to exit"
    exit 1
}

Write-Host "============================================================================" -ForegroundColor Cyan
Write-Host "Building eHandbook-CB Demos" -ForegroundColor Cyan
Write-Host "============================================================================" -ForegroundColor Cyan
Write-Host ""

# Check if EHB_CB_PATH is set
if (-not $env:EHB_CB_PATH) {
    Write-Host "EHB_CB_PATH environment variable is not set." -ForegroundColor Yellow
    
    # Try to load from set_tool_paths.ps1 if it exists
    $setupScript = Join-Path $PSScriptRoot "set_tool_paths.ps1"
    if (Test-Path $setupScript) {
        Write-Host "Loading environment variables from set_tool_paths.ps1..." -ForegroundColor Cyan
        . $setupScript
        Write-Host ""
    }
    else {
        Write-Host "ERROR: EHB_CB_PATH environment variable is not set!" -ForegroundColor Red
        Write-Host "Please run .\set_tool_paths.ps1 first or set the environment variable manually." -ForegroundColor Yellow
        Write-Host ""
        Read-Host "Press Enter to exit"
        exit 1
    }
    
    # Verify it's now set
    if (-not $env:EHB_CB_PATH) {
        Write-Host "ERROR: Failed to set EHB_CB_PATH!" -ForegroundColor Red
        Write-Host ""
        Read-Host "Press Enter to exit"
        exit 1
    }
}

Write-Host "Using eHandbookCB from: $env:EHB_CB_PATH" -ForegroundColor Green
Write-Host ""

# Initialize counters
$successCount = 0
$failedCount = 0
$skippedCount = 0
$failedDemos = @()

# Create log file
$timestamp = Get-Date -Format "yyyyMMdd_HHmmss"
$logFile = "build_all_demos_$timestamp.log"
"Build started at $(Get-Date)" | Out-File -FilePath $logFile
"" | Out-File -FilePath $logFile -Append

# Get list of all Demo directories
$demoDirs = Get-ChildItem -Directory -Filter $Filter | Where-Object { $_.Name -like "Demo_*" }

if ($demoDirs.Count -eq 0) {
    Write-Host "No demo directories found matching pattern: $Filter" -ForegroundColor Yellow
    exit 0
}

Write-Host "Found $($demoDirs.Count) demo(s) to build" -ForegroundColor Cyan
Write-Host ""

# Function to build a single demo
function Invoke-DemoBuild {
    param(
        [Parameter(Mandatory=$true)]
        [System.IO.DirectoryInfo]$DemoDir,
        
        [Parameter(Mandatory=$true)]
        [string]$LogFile
    )
    
    $result = @{
        Name = $DemoDir.Name
        Success = $false
        Skipped = $false
        ErrorMessage = ""
    }
    
    $buildBat = Join-Path $DemoDir.FullName "build.bat"
    
    if (-not (Test-Path $buildBat)) {
        $result.Skipped = $true
        $result.ErrorMessage = "No build.bat found"
        return $result
    }
    
    try {
        # Execute build.bat
        $process = Start-Process -FilePath "cmd.exe" `
            -ArgumentList "/c", "`"$buildBat`" < nul" `
            -WorkingDirectory $DemoDir.FullName `
            -NoNewWindow `
            -Wait `
            -PassThru `
            -RedirectStandardOutput (Join-Path $env:TEMP "$($DemoDir.Name)_stdout.log") `
            -RedirectStandardError (Join-Path $env:TEMP "$($DemoDir.Name)_stderr.log")
        
        if ($process.ExitCode -eq 0) {
            $result.Success = $true
        } else {
            $result.ErrorMessage = "Build failed with exit code $($process.ExitCode)"
        }
    }
    catch {
        $result.ErrorMessage = "Exception: $($_.Exception.Message)"
    }
    
    return $result
}

# Build demos
if ($Parallel) {
    Write-Host "Building demos in parallel..." -ForegroundColor Cyan
    Write-Host ""
    
    $results = $demoDirs | ForEach-Object -Parallel {
        $demo = $_
        $logFilePath = $using:logFile
        
        # Load the function in parallel context
        function Invoke-DemoBuild {
            param($DemoDir, $LogFile)
            
            $result = @{
                Name = $DemoDir.Name
                Success = $false
                Skipped = $false
                ErrorMessage = ""
            }
            
            $buildBat = Join-Path $DemoDir.FullName "build.bat"
            
            if (-not (Test-Path $buildBat)) {
                $result.Skipped = $true
                $result.ErrorMessage = "No build.bat found"
                return $result
            }
            
            try {
                $process = Start-Process -FilePath "cmd.exe" `
                    -ArgumentList "/c", "`"$buildBat`" < nul" `
                    -WorkingDirectory $DemoDir.FullName `
                    -NoNewWindow `
                    -Wait `
                    -PassThru `
                    -RedirectStandardOutput (Join-Path $env:TEMP "$($DemoDir.Name)_stdout.log") `
                    -RedirectStandardError (Join-Path $env:TEMP "$($DemoDir.Name)_stderr.log")
                
                if ($process.ExitCode -eq 0) {
                    $result.Success = $true
                } else {
                    $result.ErrorMessage = "Build failed with exit code $($process.ExitCode)"
                }
            }
            catch {
                $result.ErrorMessage = "Exception: $($_.Exception.Message)"
            }
            
            return $result
        }
        
        Invoke-DemoBuild -DemoDir $demo -LogFile $logFilePath
    } -ThrottleLimit 4
    
    # Process results
    foreach ($result in $results) {
        $logEntry = "------------------------------------------------------------------------`n"
        $logEntry += "Demo: $($result.Name)`n"
        
        if ($result.Skipped) {
            Write-Host "[SKIPPED] $($result.Name) - $($result.ErrorMessage)" -ForegroundColor Yellow
            $logEntry += "[SKIPPED] $($result.ErrorMessage)`n"
            $skippedCount++
        }
        elseif ($result.Success) {
            Write-Host "[SUCCESS] $($result.Name)" -ForegroundColor Green
            $logEntry += "[SUCCESS]`n"
            $successCount++
        }
        else {
            Write-Host "[FAILED]  $($result.Name) - $($result.ErrorMessage)" -ForegroundColor Red
            $logEntry += "[FAILED] $($result.ErrorMessage)`n"
            $failedCount++
            $failedDemos += $result.Name
        }
        
        $logEntry | Out-File -FilePath $logFile -Append
    }
}
else {
    # Sequential build
    foreach ($demoDir in $demoDirs) {
        Write-Host "------------------------------------------------------------------------" -ForegroundColor Gray
        Write-Host "Processing: $($demoDir.Name)" -ForegroundColor Cyan
        Write-Host "------------------------------------------------------------------------" -ForegroundColor Gray
        
        $logEntry = "------------------------------------------------------------------------`n"
        $logEntry += "Processing: $($demoDir.Name)`n"
        $logEntry | Out-File -FilePath $logFile -Append
        
        $result = Invoke-DemoBuild -DemoDir $demoDir -LogFile $logFile
        
        if ($result.Skipped) {
            Write-Host "[SKIPPED] $($result.Name) - $($result.ErrorMessage)" -ForegroundColor Yellow
            "[SKIPPED] $($result.ErrorMessage)`n" | Out-File -FilePath $logFile -Append
            $skippedCount++
        }
        elseif ($result.Success) {
            Write-Host "[SUCCESS] $($result.Name) built successfully" -ForegroundColor Green
            "[SUCCESS] Built successfully`n" | Out-File -FilePath $logFile -Append
            $successCount++
        }
        else {
            Write-Host "[FAILED]  $($result.Name) - $($result.ErrorMessage)" -ForegroundColor Red
            "[FAILED] $($result.ErrorMessage)`n" | Out-File -FilePath $logFile -Append
            $failedCount++
            $failedDemos += $result.Name
            
            if (-not $ContinueOnError) {
                Write-Host ""
                Write-Host "Build failed! Use -ContinueOnError to continue building remaining demos." -ForegroundColor Yellow
                break
            }
        }
        
        Write-Host ""
    }
}

# Calculate duration
$endTime = Get-Date
$duration = $endTime - $startTime

# Print summary
Write-Host ""
Write-Host "============================================================================" -ForegroundColor Cyan
Write-Host "Build Summary" -ForegroundColor Cyan
Write-Host "============================================================================" -ForegroundColor Cyan
Write-Host "Successful builds:       " -NoNewline; Write-Host $successCount -ForegroundColor Green
Write-Host "Failed builds:           " -NoNewline; Write-Host $failedCount -ForegroundColor $(if ($failedCount -gt 0) { "Red" } else { "Gray" })
Write-Host "Skipped (no build.bat):  " -NoNewline; Write-Host $skippedCount -ForegroundColor Yellow
Write-Host "Total duration:          $($duration.ToString('hh\:mm\:ss'))" -ForegroundColor Cyan
Write-Host ""
Write-Host "Log file: $logFile" -ForegroundColor Gray
Write-Host "============================================================================" -ForegroundColor Cyan

# Write summary to log
$summary = @"

============================================================================
Build Summary
============================================================================
Successful builds:       $successCount
Failed builds:           $failedCount
Skipped (no build.bat):  $skippedCount
Total duration:          $($duration.ToString('hh\:mm\:ss'))

Build completed at $(Get-Date)
"@
$summary | Out-File -FilePath $logFile -Append

if ($failedDemos.Count -gt 0) {
    Write-Host ""
    Write-Host "Failed demos:" -ForegroundColor Red
    foreach ($demo in $failedDemos) {
        Write-Host "  - $demo" -ForegroundColor Red
    }
    "`nFailed demos:" | Out-File -FilePath $logFile -Append
    $failedDemos | ForEach-Object { "  - $_" } | Out-File -FilePath $logFile -Append
}

Write-Host ""

# Exit with appropriate code
if ($failedCount -gt 0) {
    Write-Host "WARNING: $failedCount demo(s) failed to build!" -ForegroundColor Yellow
    Read-Host "Press Enter to exit"
    exit 1
}

Write-Host "All demos built successfully!" -ForegroundColor Green
Read-Host "Press Enter to exit"
exit 0
