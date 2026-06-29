@echo off
REM ============================================================
REM  Encrypted Container - Password from File
REM  Demonstrates container encryption using -epwdf flag
REM  with password read from a file.
REM
REM  Prerequisites:
REM    Run set_tool_paths.bat in the repository root first.
REM    Ensure password.txt exists in the Input/ folder.
REM ============================================================

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_Encrypted_Container_File" ^
-epwdf ".\password.txt" ^
-gensvg ^
-nomatlab

pause
