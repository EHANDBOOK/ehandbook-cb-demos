cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_AsciiDoc" ^
-gensvg ^
-nomatlab ^
-styling ".\styling" ^
-simlib "%MATLAB_PATH%\toolbox\simulink"

pause