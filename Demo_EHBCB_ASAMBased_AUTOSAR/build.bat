cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input\asamCC.ccx" ^
-o ".\Output" ^
-n "Demo_EHBCB_ASAMBased_AUTOSAR" ^
-simlib "FlexECU_Simulink_Library" ^
-nomatlab ^
-gensvg ^
-styling ".\styling" ^
-rootlevel ".\configuration\rootlevel.json" ^
-labelamendment ".\configuration\labelamendment.json"

pause