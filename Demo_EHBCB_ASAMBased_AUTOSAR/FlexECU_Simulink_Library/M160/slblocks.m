function blkStruct = slblocks
% title:    slblocks.m
% autor:    Alexander Weber
%
% Define the library list for the Simulink Library browser.
%

Browser(1).Library = 'M160_lib';
Browser(1).Name    = 'M160';

Browser(2).Library = 'M160_control_lib';
Browser(2).Name    = 'M160_control';

blkStruct.Browser = Browser;
 
% End of slblocks.m
