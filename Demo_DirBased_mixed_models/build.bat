cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n mixedModelsFC1_V2 ^
-nomatlab ^
-simlib "%MATLAB_PATH%\toolbox\simulink\blocks\library" ^
-gensvg 

pause
