cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_FlexECU" ^
-simlib ".\SimLib,%MATLAB_PATH%\toolbox\simulink" ^
-nomatlab ^
-gensvg ^
-styling ".\etas-styling" ^
-rootlevel ".\configuration\rootlevel.json"

pause


