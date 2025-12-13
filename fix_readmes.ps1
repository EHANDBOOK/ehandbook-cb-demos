# Script to add missing Build Script sections to README files

$fixes = @(
    @{
        Demo = "Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed"
        BuildBat = @'
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed" ^
-nomatlab ^
-simlib "%MATLAB_PATH%\toolbox\simulink\blocks\library" ^
-gensvg
'@
        Description = @'
* `-i ".\Input"`: Specifies the input directory containing all source artifacts.
* `-o ".\Output"`: Specifies the output directory for the generated EHANDBOOK container.
* `-n "Demo_EHBCB_DirBased_ASCET_SL_CCODE_Mixed"`: Sets the name of the output file.
* `-nomatlab`: Instructs the builder to use its internal Simulink reader rather than launching MATLAB, speeding up the build.
* `-simlib "%MATLAB_PATH%\toolbox\simulink\blocks\library"`: Specifies the path to Simulink library blocks.
* `-gensvg`: Automatically generates SVG screenshots from the interactive models.
'@
    },
    @{
        Demo = "Demo_EHBCB_DirBased_AsciiDoc"
        BuildBat = @'
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_AsciiDoc" ^
-gensvg ^
-nomatlab ^
-styling ".\styling" ^
-simlib "%MATLAB_PATH%\toolbox\simulink"
'@
        Description = @'
* `-i ".\Input"`: Specifies the input directory containing all source artifacts.
* `-o ".\Output"`: Specifies the output directory for the generated EHANDBOOK container.
* `-n "Demo_EHBCB_DirBased_AsciiDoc"`: Sets the name of the output file.
* `-gensvg`: Automatically generates SVG screenshots from the interactive models.
* `-nomatlab`: Instructs the builder to use its internal Simulink reader rather than launching MATLAB.
* `-styling ".\styling"`: Applies custom styling from the specified directory.
* `-simlib "%MATLAB_PATH%\toolbox\simulink"`: Specifies the path to Simulink library blocks.
'@
    },
    @{
        Demo = "Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only"
        BuildBat = @'
# First, convert AUTOSAR ARXML files to EHB-CB input format
%EHB_CB_PATH%\eHandbookCB.exe ^
-i FlexECU_AUTOSAR_files ^
-o "FlexECU_AUTOSAR_files_ehb_cb_input" ^
-ar2ehbcbinput

# Then, build the EHANDBOOK container from the converted input
%EHB_CB_PATH%\eHandbookCB.exe ^
-i "FlexECU_AUTOSAR_files_ehb_cb_input" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only" ^
-o "./Output"
'@
        Description = @'
This demo uses a two-step build process:

1. **Convert AUTOSAR ARXML to EHB-CB Input Format:**
   * `-i FlexECU_AUTOSAR_files`: Specifies the directory containing AUTOSAR ARXML files.
   * `-o "FlexECU_AUTOSAR_files_ehb_cb_input"`: Specifies the output directory for the converted files.
   * `-ar2ehbcbinput`: Triggers the conversion from AUTOSAR format to EHB-CB input format.

2. **Build the EHANDBOOK Container:**
   * `-i "FlexECU_AUTOSAR_files_ehb_cb_input"`: Uses the converted files as input.
   * `-n "Demo_EHBCB_DirBased_AUTOSAR_FlexECU_Only"`: Sets the name of the output file.
   * `-o "./Output"`: Specifies the output directory for the generated EHANDBOOK container.
'@
    },
    @{
        Demo = "Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only"
        BuildBat = @'
# First, convert AUTOSAR ARXML files to EHB-CB input format
%EHB_CB_PATH%\eHandbookCB.exe ^
-i RTA_RTE_Case_Study_AUTOSAR_files ^
-o "RTA_RTE_Case_Study_AUTOSAR_files_ehb_cb_input" ^
-ar2ehbcbinput

# Then, build the EHANDBOOK container from the converted input
%EHB_CB_PATH%\eHandbookCB.exe ^
-i "RTA_RTE_Case_Study_AUTOSAR_files_ehb_cb_input" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only" ^
-o "./Output"
'@
        Description = @'
This demo uses a two-step build process:

1. **Convert AUTOSAR ARXML to EHB-CB Input Format:**
   * `-i RTA_RTE_Case_Study_AUTOSAR_files`: Specifies the directory containing AUTOSAR ARXML files.
   * `-o "RTA_RTE_Case_Study_AUTOSAR_files_ehb_cb_input"`: Specifies the output directory for the converted files.
   * `-ar2ehbcbinput`: Triggers the conversion from AUTOSAR format to EHB-CB input format.

2. **Build the EHANDBOOK Container:**
   * `-i "RTA_RTE_Case_Study_AUTOSAR_files_ehb_cb_input"`: Uses the converted files as input.
   * `-n "Demo_EHBCB_DirBased_AUTOSAR_RTA_RTE_Only"`: Sets the name of the output file.
   * `-o "./Output"`: Specifies the output directory for the generated EHANDBOOK container.
'@
    },
    @{
        Demo = "Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping"
        BuildBat = @'
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping" ^
-gensvg ^
-nomatlab ^
-matlabpath "%MATLAB_PATH%\bin" ^
-simlib "%MATLAB_PATH%\toolbox\simulink" ^
-componentconnectormappingfile ".\ComponentMapping.json"
'@
        Description = @'
* `-i ".\Input"`: Specifies the input directory containing all source artifacts.
* `-o ".\Output"`: Specifies the output directory for the generated EHANDBOOK container.
* `-n "Demo_EHBCB_DirBased_AUTOSAR_Signal_Mapping"`: Sets the name of the output file.
* `-gensvg`: Automatically generates SVG screenshots from the interactive models.
* `-nomatlab`: Instructs the builder to use its internal Simulink reader rather than launching MATLAB.
* `-matlabpath "%MATLAB_PATH%\bin"`: Specifies the path to the MATLAB installation (used for certain operations even with `-nomatlab`).
* `-simlib "%MATLAB_PATH%\toolbox\simulink"`: Specifies the path to Simulink library blocks.
* `-componentconnectormappingfile ".\ComponentMapping.json"`: Specifies a JSON file that maps component connectors for signal mapping.
'@
    },
    @{
        Demo = "Demo_EHBCB_DirBased_Language_Support"
        BuildBat = @'
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_Language_Support" ^
-styling ".\styling" ^
-pdf
'@
        Description = @'
* `-i ".\Input"`: Specifies the input directory containing all source artifacts.
* `-o ".\Output"`: Specifies the output directory for the generated EHANDBOOK container.
* `-n "Demo_EHBCB_DirBased_Language_Support"`: Sets the name of the output file.
* `-styling ".\styling"`: Applies custom styling from the specified directory.
* `-pdf`: Generates a PDF document from the container content.
'@
    },
    @{
        Demo = "Demo_EHBCB_DirBased_SL_Libraries"
        BuildBat = @'
%EHB_CB_PATH%\eHandbookCB.exe ^
-i ".\Input" ^
-o ".\Output" ^
-n "Demo_EHBCB_DirBased_SL_Libraries" ^
-simlib ".\simlibs,%MATLAB_PATH%\toolbox\simulink" ^
-simulinkview ".\configuration\SimulinkViewConfig.json" ^
-viewtype "GlobalView" ^
-gensvg
'@
        Description = @'
* `-i ".\Input"`: Specifies the input directory containing all source artifacts.
* `-o ".\Output"`: Specifies the output directory for the generated EHANDBOOK container.
* `-n "Demo_EHBCB_DirBased_SL_Libraries"`: Sets the name of the output file.
* `-simlib ".\simlibs,%MATLAB_PATH%\toolbox\simulink"`: Specifies paths to Simulink library files.
* `-simulinkview ".\configuration\SimulinkViewConfig.json"`: Applies view configuration for know-how protection.
* `-viewtype "GlobalView"`: Selects the specific view type to apply.
* `-gensvg`: Automatically generates SVG screenshots from the interactive models.
'@
    }
)

foreach ($fix in $fixes) {
    $readmePath = Join-Path $fix.Demo "README.md"
    
    if (Test-Path $readmePath) {
        Write-Host "Processing $($fix.Demo)..."
        
        $content = Get-Content $readmePath -Raw
        
        # Check if Build Script section already exists
        if ($content -notmatch '### Build Script') {
            $newSection = @"


### Build Script: ``build.bat``

The ``build.bat`` script uses the following command:

``````batch
$($fix.BuildBat)
``````

$($fix.Description)
"@
            
            # Append the new section to the end of the file
            $content += $newSection
            Set-Content -Path $readmePath -Value $content -NoNewline
            Write-Host "  Added Build Script section to $($fix.Demo)" -ForegroundColor Green
        } else {
            Write-Host "  Build Script section already exists in $($fix.Demo)" -ForegroundColor Yellow
        }
    } else {
        Write-Host "  README.md not found for $($fix.Demo)" -ForegroundColor Red
    }
}

Write-Host "`nDone!" -ForegroundColor Green
