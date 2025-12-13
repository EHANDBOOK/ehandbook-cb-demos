cls

rem set MATLAB_PATH=C:\Program Files\MATLAB\R2021a

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_TargetLink_Library" ^
-simlib ".\simlib,%MATLAB_PATH%\toolbox\simulink" ^
-simulinkview ".\configuration\SimulinkViewConfig.json" ^
-viewtype "GlobalView" ^
-gensvg

pause


