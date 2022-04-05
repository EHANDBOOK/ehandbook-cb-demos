cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n DirBased_SL_FlexECU_adoc_all_V1 ^
-gensvg ^
-nomatlab ^
-simlib ".\SimLib,%MATLAB_PATH%\toolbox\simulink"

pause


