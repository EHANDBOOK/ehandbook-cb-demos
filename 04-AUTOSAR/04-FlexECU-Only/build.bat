cls

SET ARXML_DIR=FlexECU_AUTOSAR_files
SET EHB_CB_INPUT_DIR="%ARXML_DIR%_ehb_cb_input"

md %EHB_CB_INPUT_DIR%

%EHB_CB_PATH%\eHandbookCB.exe ^
-i %ARXML_DIR% ^
-o %EHB_CB_INPUT_DIR% ^
-ar2ehbcbinput

%EHB_CB_PATH%\eHandbookCB.exe ^
-i %EHB_CB_INPUT_DIR% ^
-n "Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only" ^
-o "./Output"

pause