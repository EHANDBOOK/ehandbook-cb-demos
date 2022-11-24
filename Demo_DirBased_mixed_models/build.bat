cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n Demo_DirBased_mixed_models ^
-nomatlab ^
-simlib "%MATLAB_PATH%\toolbox\simulink\blocks\library" ^
-gensvg 

pause
