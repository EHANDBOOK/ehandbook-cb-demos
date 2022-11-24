cls

SET ARXML_DIR=FlexECU_AUTOSAR_files
SET EHB_CB_INPUT_DIR="%ARXML_DIR%_ehb_cb_input"

md %EHB_CB_INPUT_DIR%

C:\ETAS\EHANDBOOK-Container-Build_10.1.0-Windows\eHandbookCB.exe ^
-i %ARXML_DIR% ^
-o %EHB_CB_INPUT_DIR% ^
-ar2ehbcbinput

C:\ETAS\EHANDBOOK-Container-Build_10.1.0-Windows\eHandbookCB.exe ^
-i %EHB_CB_INPUT_DIR% ^
-n %ARXML_DIR% ^
-o "./Output"

pause