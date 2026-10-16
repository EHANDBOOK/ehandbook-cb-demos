@echo off
REM ============================================================================
REM Build All Demos Script
REM ============================================================================
REM This script builds all eHandbook-CB demo projects in the workspace.
REM It recursively finds all build.bat files and executes each one.
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

REM Recursively find all build.bat files (excluding this script's own directory entry)
for /r %%F in (build.bat) do (
    REM Skip the root-level build_all_demos itself (build.bat in root would be this file)
    set DEMO_BUILD=%%F
    set DEMO_DIR=%%~dpF
    REM Remove trailing backslash
    set DEMO_DIR=!DEMO_DIR:~0,-1!

    REM Skip if this build.bat is in the repository root (avoid self-reference)
    if /i not "!DEMO_DIR!"=="%~dp0." (
        REM Compute relative path for display
        set REL_DIR=!DEMO_DIR:%~dp0=!

        echo ------------------------------------------------------------------------
        echo Processing: !REL_DIR!
        echo ------------------------------------------------------------------------
        echo Processing: !REL_DIR! >> "%LOG_FILE%"

        echo [Building] !REL_DIR!
        echo [Building] !REL_DIR! >> "%LOG_FILE%"

        REM Change to demo directory
        pushd "!DEMO_DIR!"

        REM Execute build.bat (without pause)
        call build.bat < nul > nul 2>&1

        REM Check exit code
        if !errorlevel! equ 0 (
            echo [SUCCESS] !REL_DIR! built successfully
            echo [SUCCESS] !REL_DIR! built successfully >> "..\%LOG_FILE%"
            set /a SUCCESS_COUNT+=1
        ) else (
            echo [FAILED] !REL_DIR! build failed with error code !errorlevel!
            echo [FAILED] !REL_DIR! build failed with error code !errorlevel! >> "..\%LOG_FILE%"
            set /a FAILED_COUNT+=1
        )

        REM Return to root directory
        popd

        echo.
        echo. >> "%LOG_FILE%"
    )
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
