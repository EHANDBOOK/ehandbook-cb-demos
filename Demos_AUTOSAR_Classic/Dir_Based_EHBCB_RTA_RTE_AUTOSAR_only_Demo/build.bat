cls

SET ARXML_DIR=RTA_RTE_Case_Study_AUTOSAR_files
SET EHB_CB_INPUT_DIR="%ARXML_DIR%_ehb_cb_input"

md %EHB_CB_INPUT_DIR%

%EHB_CB_PATH%\eHandbookCB.exe ^
-i %ARXML_DIR% ^
-o %EHB_CB_INPUT_DIR% ^
-ar2ehbcbinput

%EHB_CB_PATH%\eHandbookCB.exe ^
-i %EHB_CB_INPUT_DIR% ^
-n %ARXML_DIR% ^
-o "./Output"

pause