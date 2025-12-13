cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese" ^
-gensvg ^
-styling ".\styling" ^
-labelconfig ".\configuration\LabelConfig.json" ^
-labelamendment ".\configuration\LabelAmendment.json" ^
-rootlevel ".\configuration\RootLevel.json" ^
-tableconfig ".\configuration\TableConfiguration.json" ^
-simlib ".\FlexECU_Simulink_Library" ^
-pdf

pause  