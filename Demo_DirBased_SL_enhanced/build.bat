cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "DirBased_Simulink_Example" ^
-gensvg ^
-nomatlab ^
-tableconfig "TableConfiguration.json" ^
-viewtype "AllView" ^
-simulinkview "SimulinkGlobalView.json" ^
-simlib ".\SimLib,%MATLAB_PATH%\toolbox\simulink"

pause




