cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n enhanced_SL_view_V91_Hide ^
-gensvg ^
-nomatlab ^
-tableconfig "TableConfiguration.json" ^
-viewtype "AllView" ^
-simulinkview "SimulinkGlobalView.json" ^
-simlib ".\SimLib,%MATLAB_PATH%\toolbox\simulink"

pause




