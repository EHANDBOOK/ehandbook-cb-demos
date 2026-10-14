% Iac_tables
% Definition of tables as Simulink parameters
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Iac_deltaDegIgn_y = Simulink.Parameter;
Iac_deltaDegIgn_y.DataType = 'single';
Iac_deltaDegIgn_y.Value = [55.5	55.5	55.5	55.5	50.25	39.75	45.0	33.0	22.5	15.0	8.25	0.0];
Iac_deltaDegIgn_y.StorageClass = 'ImportedExtern';
Iac_deltaDegIgn_x = Simulink.Parameter;
Iac_deltaDegIgn_x.DataType = 'single';
Iac_deltaDegIgn_x.Value = [0.1	0.12	0.19	0.28	0.4	0.55	0.7	0.82	0.9	0.975	0.99	1.0];
Iac_deltaDegIgn_x.StorageClass = 'ImportedExtern';
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_z = Simulink.Parameter;
Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_z.DataType = 'single';
Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_z.Value = ...
[30.5	30.375	30.25	30.0	30.0	30.0	30.0	30.0	30.0	30.0	30.0	25.5	28.5	30.0	30.0	30.0
30.0	30.0	30.0	30.0	30.0	30.0	30.0	30.0	29.625	29.25	28.5	24.75	27.75	30.0	30.0	30.0
25.5	25.5	25.5	26.25	25.875	25.5	27.375	29.25	28.125	27.0	23.25	21.0	24.75	27.75	24.75	25.5
21.0	21.0	21.0	21.75	21.375	21.0	22.5	24.0	23.25	22.5	22.5	19.5	22.5	23.25	22.5	23.25
15.75	15.75	15.75	16.5	17.625	18.75	20.25	21.75	20.875	20.0	20.0	17.25	19.5	21.0	20.25	21.0
11.75	11.75	11.75	12.0	15.0	18.0	18.75	19.5	18.0	16.5	17.25	16.5	17.5	18.75	18.75	20.25
6.0	6.0	6.75	7.5	7.875	8.25	9.375	10.5	10.875	11.25	15.75	15.75	15.0	16.5	18.0	19.5
0.0	3.75	4.5	5.25	5.25	5.25	6.0	6.75	8.375	10.0	12.0	13.5	10.5	12.75	15.0	16.5
0.0	0.0	0.0	0.0	0.75	1.5	3.0	4.5	6.375	8.25	8.25	10.5	9.75	9.75	13.5	15.0
0.0	0.0	0.0	0.0	0.0	0.0	1.0	2.0	3.625	5.25	4.5	8.25	8.25	8.25	10.5	12.0
0.0	0.0	0.0	0.0	0.0	0.0	0.375	0.75	2.375	4.0	3.0	4.5	6.0	6.0	7.5	8.25
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	1.125	2.25	1.75	3.0	3.75	4.5	5.25	6.0
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.75	1.25	2.25	3.0	3.75	4.5
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.75	1.5	2.25	3.0	3.75
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.75	1.5	2.25	3.0
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.75	1.5	2.25]';
Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_z.StorageClass = 'ImportedExtern';
Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_y = Simulink.Parameter;
Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_y.DataType = 'single';
Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_y.Value = [0.165 0.203 0.383 0.502 0.623 0.735 0.855 0.975 1.087 1.208 1.327 1.440 1.560 1.680 1.793 1.913];
Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_y.StorageClass = 'ImportedExtern';
Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_x = Simulink.Parameter;
Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_x.DataType = 'single';
Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_x.Value = [750.0	1000.0	1250.0	1500.0	1750.0	2000.0	2250.0	2500.0	2750.0	3000.0	3500.0	4000.0	4500.0	5000.0	5250.0	5800.0];
Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP_x.StorageClass = 'ImportedExtern';
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Iac_rpmEngSpdfacRelAir2degBase_MAP_z = Simulink.Parameter;
Iac_rpmEngSpdfacRelAir2degBase_MAP_z.DataType = 'single';
Iac_rpmEngSpdfacRelAir2degBase_MAP_z.Value = ...
[30.5	30.375	30.25	30.0	30.0	30.0	30.0	30.0	30.0	30.0	30.0	25.5	28.5	30.0	30.0	30.0
30.0	30.0	30.0	30.0	30.0	30.0	30.0	30.0	29.625	29.25	28.5	24.75	27.75	30.0	30.0	30.0
25.5	25.5	25.5	26.25	25.875	25.5	27.375	29.25	28.125	27.0	23.25	21.0	24.75	27.75	24.75	25.5
21.0	21.0	21.0	21.75	21.375	21.0	22.5	24.0	23.25	22.5	22.5	19.5	22.5	23.25	22.5	23.25
15.75	15.75	15.75	16.5	17.625	18.75	20.25	21.75	20.875	20.0	20.0	17.25	19.5	21.0	20.25	21.0
11.75	11.75	11.75	12.0	15.0	18.0	18.75	19.5	18.0	16.5	17.25	16.5	17.5	18.75	18.75	20.25
6.0	6.0	6.75	7.5	7.875	8.25	9.375	10.5	10.875	11.25	15.75	15.75	15.0	16.5	18.0	19.5
0.0	3.75	4.5	5.25	5.25	5.25	6.0	6.75	8.375	10.0	12.0	13.5	10.5	12.75	15.0	16.5
0.0	0.0	0.0	0.0	0.75	1.5	3.0	4.5	6.375	8.25	8.25	10.5	9.75	9.75	13.5	15.0
0.0	0.0	0.0	0.0	0.0	0.0	1.0	2.0	3.625	5.25	4.5	8.25	8.25	8.25	10.5	12.0
0.0	0.0	0.0	0.0	0.0	0.0	0.375	0.75	2.375	4.0	3.0	4.5	6.0	6.0	7.5	8.25
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	1.125	2.25	1.75	3.0	3.75	4.5	5.25	6.0
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.75	1.25	2.25	3.0	3.75	4.5
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.75	1.5	2.25	3.0	3.75
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.75	1.5	2.25	3.0
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.75	1.5	2.25]';
Iac_rpmEngSpdfacRelAir2degBase_MAP_z.StorageClass = 'ImportedExtern';
Iac_rpmEngSpdfacRelAir2degBase_MAP_y = Simulink.Parameter;
Iac_rpmEngSpdfacRelAir2degBase_MAP_y.DataType = 'single';
Iac_rpmEngSpdfacRelAir2degBase_MAP_y.Value = [0.165 0.203 0.383 0.502 0.623 0.735 0.855 0.975 1.087 1.208 1.327 1.440 1.560 1.680 1.793 1.913];
Iac_rpmEngSpdfacRelAir2degBase_MAP_y.StorageClass = 'ImportedExtern';
Iac_rpmEngSpdfacRelAir2degBase_MAP_x = Simulink.Parameter;
Iac_rpmEngSpdfacRelAir2degBase_MAP_x.DataType = 'single';
Iac_rpmEngSpdfacRelAir2degBase_MAP_x.Value = [750.0	1000.0	1250.0	1500.0	1750.0	2000.0	2250.0	2500.0	2750.0	3000.0	3500.0	4000.0	4500.0	5000.0	5250.0	5800.0];
Iac_rpmEngSpdfacRelAir2degBase_MAP_x.StorageClass = 'ImportedExtern';