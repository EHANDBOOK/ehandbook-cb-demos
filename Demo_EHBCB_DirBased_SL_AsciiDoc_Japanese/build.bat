cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Lcc" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_AsciiDoc_Japanese" ^
-gensvg ^
-styling ".\styling" ^
-labelconfig ".\configuration\LabelConfig.json" ^
-labelamendment ".\configuration\LabelAmendment.json" ^
-rootlevel ".\configuration\RootLevel.json" ^
-tableconfig ".\configuration\TableConfiguration.json" ^
-simlib ".\Flex_Simulink_Library" ^
-pdf

pause  