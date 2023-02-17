cls

set EHB_CB_PATH=C:\ETAS\EHANDBOOK-CB10.3
set EHB_UGG_PATH=C:\ETAS\EHANDBOOK-UGG10.3
set MATLAB_PATH=C:\Program Files\MATLAB\R2021a

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "EHB_Demo_DirBased_SL_Libraries_with_matlab_with_view" ^
-simlib ".\simlibs,%MATLAB_PATH%\toolbox\simulink" ^
-simulinkview ".\configuration\SimulinkViewConfig.json" ^
-viewtype "GlobalView" ^
-gensvg

pause


