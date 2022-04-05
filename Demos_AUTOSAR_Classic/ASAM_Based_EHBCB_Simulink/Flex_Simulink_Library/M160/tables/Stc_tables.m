% Stc_tables
% Definition of tables as Simulink parameters
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Stc_facFuelCorr_MAP_z = Simulink.Parameter;
Stc_facFuelCorr_MAP_z.DataType = 'single';
Stc_facFuelCorr_MAP_z.Value = ...
[9.6 9.6 8.4 8.4 7.2 6.0 4.8 3.6 2.4 1.2 1.2
7.2	7.2	6.0	6.0	5.4	5.4	4.8	3.6	2.4	1.2	1.2
4.8	4.8	4.2	4.2	3.6	3.6	2.4	2.4	1.2	1.2	1.2
2.4	2.4	2.4	2.28 2.16 2.04 1.8 1.56	1.2	1.2	1.2
2.04 2.04 1.92 1.8 1.68	1.56 1.44 1.32 1.2 1.2 1.2
1.2	1.2	1.2	1.2	1.2	1.2	1.2	1.2	1.2	1.2	1.2]';
Stc_facFuelCorr_MAP_z.StorageClass = 'ImportedExtern';
Stc_facFuelCorr_MAP_y = Simulink.Parameter;
Stc_facFuelCorr_MAP_y.DataType = 'single';
Stc_facFuelCorr_MAP_y.Value = [243 263 273 293 323 363];
Stc_facFuelCorr_MAP_y.StorageClass = 'ImportedExtern';
Stc_facFuelCorr_MAP_x = Simulink.Parameter;
Stc_facFuelCorr_MAP_x.DataType = 'single';
Stc_facFuelCorr_MAP_x.Value = [0.0	2.5	5.0	7.5	10.0	12.5	15.0	17.5	20.0	22.5	25.0];
Stc_facFuelCorr_MAP_x.StorageClass = 'ImportedExtern';