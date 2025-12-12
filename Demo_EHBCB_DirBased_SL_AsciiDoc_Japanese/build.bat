cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Lcc" ^
-o "." ^
-n "Demo_Simulink_model_with_Japanese_documentation" ^
-gensvg ^
-styling ".\css" ^
-labelconfig ".\configuration\LabelConfig.json" ^
-labelamendment ".\configuration\LabelAmendment.json" ^
-rootlevel ".\configuration\RootLevel.json" ^
-tableconfig ".\configuration\TableConfiguration.json" ^
-simlib ".\Flex_Simulink_Library" ^
-pdf

pause  