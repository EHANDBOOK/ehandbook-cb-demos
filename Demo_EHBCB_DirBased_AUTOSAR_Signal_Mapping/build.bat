cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping" ^
-gensvg ^
-nomatlab ^
-matlabpath "C:\Program Files\MATLAB\R2019b\bin" ^
-simlib "C:\Program Files\MATLAB\R2019b\toolbox\simulink" ^
-componentconnectormappingfile ".\ComponentMapping.json"
