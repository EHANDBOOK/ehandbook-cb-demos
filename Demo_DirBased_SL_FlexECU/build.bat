cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n ETAS_FlexECU_Dir_Simulink ^
-simlib ".\SimLib,%MATLAB_PATH%\toolbox\simulink" ^
-nomatlab ^
-gensvg ^
-styling ".\etas-styling" ^
-rootlevel ".\configuration\rootlevel.json"

pause


