cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_ReferencedModels" ^
-gensvg ^
-simlib ".\SimLib,%MATLAB_PATH%\toolbox\simulink" 

pause
