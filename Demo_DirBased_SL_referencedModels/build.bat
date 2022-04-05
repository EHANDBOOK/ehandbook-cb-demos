cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n SL_modRef ^
-gensvg ^
-simlib ".\SimLib,%MATLAB_PATH%\toolbox\simulink" 

pause
