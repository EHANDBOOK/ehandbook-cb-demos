@echo off
REM ============================================================
REM  Encrypted Container - AI Allowance
REM  Demonstrates repackaging an existing encrypted container
REM  with AI usage enabled using the -allowai flag.
REM
REM  Prerequisites:
REM    Run set_tool_paths.bat in the repository root first.
REM ============================================================

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input\Demo_EHBCB_DirBased_Encrypted_Container_Simple.ehbcrypt" ^
-o ".\Output" ^
-n "Demo_EHBCB_Encrypted_Container_Simple" ^
-epwd "DemoPassword123" ^
-allowai

pause
