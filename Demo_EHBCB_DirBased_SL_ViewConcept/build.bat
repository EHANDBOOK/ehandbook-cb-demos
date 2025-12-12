cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_Simulink_External_View" ^
-viewtype "EXTERNAL" ^
-gensvg 

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_Simulink_Internal_View" ^
-viewtype "INTERNAL" ^
-gensvg 

pause
