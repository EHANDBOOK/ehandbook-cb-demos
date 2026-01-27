# ============================================================================
# Set Tool Paths (PowerShell)
# ============================================================================
# This script sets the required environment variables for eHandbook-CB demos
# ============================================================================

# Set eHandbook-CB path
$env:EHB_CB_PATH = "C:\ETAS\EHANDBOOK-Container-Build_13.5.0_Windows"
$env:EHB_UGG_PATH = "C:\ETAS\EHANDBOOK-Container-Build_13.5.0_Windows"

# Set MATLAB path
$env:MATLAB_PATH = "C:\Program Files\MATLAB\R2021a"

# Display the set variables
Write-Host "Environment variables set:" -ForegroundColor Green
Write-Host "  EHB_CB_PATH  = $env:EHB_CB_PATH" -ForegroundColor Cyan
Write-Host "  EHB_UGG_PATH = $env:EHB_UGG_PATH" -ForegroundColor Cyan
Write-Host "  MATLAB_PATH  = $env:MATLAB_PATH" -ForegroundColor Cyan
Write-Host ""
Write-Host "Note: These variables are set only for the current PowerShell session." -ForegroundColor Yellow
Write-Host "To make them permanent, add them to your system environment variables." -ForegroundColor Yellow
