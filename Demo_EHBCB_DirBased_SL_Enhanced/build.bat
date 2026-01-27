cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_Enhanced" ^
-gensvg ^
-nomatlab ^
-tableconfig "TableConfiguration.json" ^
-viewtype "AllView" ^
-simulinkview "SimulinkGlobalView.json" ^
-simlib ".\simlib,%MATLAB_PATH%\toolbox\simulink"

pause




