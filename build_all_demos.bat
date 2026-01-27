@echo off
REM ============================================================================
REM Build All Demos Script
REM ============================================================================
REM This script builds all eHandbook-CB demo projects in the workspace.
REM It iterates through each Demo_* directory and executes its build.bat file.
REM ============================================================================

setlocal enabledelayedexpansion

echo ============================================================================
echo Building All eHandbook-CB Demos
echo ============================================================================
echo.

REM Check if EHB_CB_PATH is set
if not defined EHB_CB_PATH (
    echo ERROR: EHB_CB_PATH environment variable is not set!
    echo Please run set_tool_paths.bat first or set the environment variable manually.
    echo.
    pause
    exit /b 1
)

echo Using eHandbookCB from: %EHB_CB_PATH%
echo.

REM Initialize counters
set /a SUCCESS_COUNT=0
set /a FAILED_COUNT=0
set /a SKIPPED_COUNT=0

REM Create log file
set LOG_FILE=build_all_demos_%date:~-4,4%%date:~-7,2%%date:~-10,2%_%time:~0,2%%time:~3,2%%time:~6,2%.log
set LOG_FILE=%LOG_FILE: =0%
echo Build started at %date% %time% > "%LOG_FILE%"
echo. >> "%LOG_FILE%"

REM Get list of all Demo directories
for /d %%D in (Demo_*) do (
    set DEMO_DIR=%%D
    
    echo ------------------------------------------------------------------------
    echo Processing: !DEMO_DIR!
    echo ------------------------------------------------------------------------
    echo Processing: !DEMO_DIR! >> "%LOG_FILE%"
    
    REM Check if build.bat exists
    if exist "!DEMO_DIR!\build.bat" (
        echo [Building] !DEMO_DIR!
        echo [Building] !DEMO_DIR! >> "%LOG_FILE%"
        
        REM Change to demo directory
        pushd "!DEMO_DIR!"
        
        REM Execute build.bat (without pause)
        REM We redirect output to capture it, and use findstr to avoid the pause command
        call build.bat < nul > nul 2>&1
        
        REM Check exit code
        if !errorlevel! equ 0 (
            echo [SUCCESS] !DEMO_DIR! built successfully
            echo [SUCCESS] !DEMO_DIR! built successfully >> "..\%LOG_FILE%"
            set /a SUCCESS_COUNT+=1
        ) else (
            echo [FAILED] !DEMO_DIR! build failed with error code !errorlevel!
            echo [FAILED] !DEMO_DIR! build failed with error code !errorlevel! >> "..\%LOG_FILE%"
            set /a FAILED_COUNT+=1
        )
        
        REM Return to root directory
        popd
    ) else (
        echo [SKIPPED] !DEMO_DIR! - No build.bat found
        echo [SKIPPED] !DEMO_DIR! - No build.bat found >> "%LOG_FILE%"
        set /a SKIPPED_COUNT+=1
    )
    
    echo.
    echo. >> "%LOG_FILE%"
)

REM Print summary
echo ============================================================================
echo Build Summary
echo ============================================================================
echo Successful builds: %SUCCESS_COUNT%
echo Failed builds:     %FAILED_COUNT%
echo Skipped (no build.bat): %SKIPPED_COUNT%
echo.
echo Build completed at %date% %time%
echo Log file: %LOG_FILE%
echo ============================================================================

echo. >> "%LOG_FILE%"
echo ============================================================================ >> "%LOG_FILE%"
echo Build Summary >> "%LOG_FILE%"
echo ============================================================================ >> "%LOG_FILE%"
echo Successful builds: %SUCCESS_COUNT% >> "%LOG_FILE%"
echo Failed builds:     %FAILED_COUNT% >> "%LOG_FILE%"
echo Skipped (no build.bat): %SKIPPED_COUNT% >> "%LOG_FILE%"
echo. >> "%LOG_FILE%"
echo Build completed at %date% %time% >> "%LOG_FILE%"

REM Exit with error code if any builds failed
if %FAILED_COUNT% gtr 0 (
    echo.
    echo WARNING: %FAILED_COUNT% demo(s) failed to build!
    pause
    exit /b 1
)

echo.
echo All demos built successfully!
pause
exit /b 0
