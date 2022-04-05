cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n AsciiDocDemo ^
-gensvg ^
-nomatlab ^
-styling ".\styling" ^
-simlib "%MATLAB_PATH%\toolbox\simulink"

pause