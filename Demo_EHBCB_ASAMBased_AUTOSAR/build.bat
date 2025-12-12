cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\FlexECU_ASAM_AUTOSAR\asamCC.ccx" ^
-o "." ^
-n "FlexECU_ASAM_AUTOSAR" ^
-simlib "Flex_Simulink_Library" ^
-nomatlab ^
-gensvg ^
-styling ".\etas-styling" ^
-rootlevel ".\configuration\rootlevel.json" ^
-labelamendment ".\configuration\labelamendment.json"

pause