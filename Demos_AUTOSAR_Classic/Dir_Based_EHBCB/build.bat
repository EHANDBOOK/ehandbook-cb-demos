cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i "FlexECU_Dir_AUTOSAR" ^
-o "." ^
-n "FlexECU_Dir_AUTOSAR" ^
-simlib "Flex_Simulink_Library" ^
-nomatlab ^
-gensvg ^
-styling ".\etas-styling" ^
-rootlevel ".\configuration\rootlevel.json" ^
-labelamendment ".\configuration\labelamendment.json"

pause