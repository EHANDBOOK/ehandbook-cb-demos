@echo off
REM ============================================================
REM  Encrypted Container - Simple (Password in Script)
REM  Demonstrates container encryption using -epwd flag
REM  with a plaintext password.
REM
REM  Prerequisites:
REM    Run set_tool_paths.bat in the repository root first.
REM ============================================================

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_Encrypted_Container_Simple" ^
-epwd "DemoPassword123" ^
-gensvg ^
-nomatlab


pause
