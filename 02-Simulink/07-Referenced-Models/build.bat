cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_ReferencedModels" ^
-gensvg ^
-simlib ".\simlib,%MATLAB_PATH%\toolbox\simulink" 

pause
