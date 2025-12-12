cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\FlexECU_ASAM_AUTOSAR\asamCC.ccx" ^
-o "." ^
-n "Demo_EHBCB_ASAMBased_AUTOSAR_SL" ^
-simlib "Flex_Simulink_Library" ^
-nomatlab ^
-gensvg ^
-styling ".\styling" ^
-rootlevel ".\configuration\rootlevel.json" ^
-labelamendment ".\configuration\labelamendment.json"

pause