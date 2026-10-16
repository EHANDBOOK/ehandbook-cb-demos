cls

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_ViewConcept_External" ^
-viewtype "EXTERNAL" ^
-gensvg 

%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_ViewConcept_Internal" ^
-viewtype "INTERNAL" ^
-gensvg 

pause
