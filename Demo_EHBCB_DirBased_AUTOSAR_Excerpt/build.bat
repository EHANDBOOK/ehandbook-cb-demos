cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_Excerpt" ^
-simlib "Flex_Simulink_Library" ^
-nomatlab ^
-gensvg ^
-styling ".\etas-styling" ^
-rootlevel ".\configuration\rootlevel.json" ^
-labelamendment ".\configuration\labelamendment.json"

pause