cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping" ^
-gensvg ^
-nomatlab ^
-simlib "%MATLAB_PATH%\toolbox\simulink" ^
-componentconnectormappingfile ".\ComponentMapping.json"
