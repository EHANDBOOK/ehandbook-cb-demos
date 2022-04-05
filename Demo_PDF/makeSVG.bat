for /L %%n in (1,1,11) do "C:\Program Files\Inkscape\bin\inkscape" --pdf-page=%%n C:\eHandbook\Container\FlexECUDemo\Demos\Demo_PDF\sampledata.pdf -o C:\eHandbook\Container\FlexECUDemo\Demos\Demo_PDF\sampledata%%n.svg

pause