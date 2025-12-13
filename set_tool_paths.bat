@echo off
REM ============================================================================
REM Set Tool Paths (Batch)
REM ============================================================================
REM This script sets the required environment variables for eHandbook-CB demos
REM ============================================================================

REM Set eHandbook-CB path
set EHB_CB_PATH=C:\ETAS\EHANDBOOK-Container-Build_13.5.0_Windows
set EHB_UGG_PATH=C:\ETAS\EHANDBOOK-Container-Build_13.5.0_Windows

REM Set MATLAB path
set MATLAB_PATH=C:\Program Files\MATLAB\R2021a

REM Display the set variables
echo Environment variables set:
echo   EHB_CB_PATH  = %EHB_CB_PATH%
echo   EHB_UGG_PATH = %EHB_UGG_PATH%
echo   MATLAB_PATH  = %MATLAB_PATH%
echo.
echo Note: These variables are set only for the current command prompt session.
echo To make them permanent, add them to your system environment variables.