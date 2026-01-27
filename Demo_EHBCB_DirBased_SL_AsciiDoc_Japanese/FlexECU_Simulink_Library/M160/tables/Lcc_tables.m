% Lcc_tables
% Definition of tables as Simulink parameters
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Lcc_EngSpd2facIntegrator_CUR_y = Simulink.Parameter;
Lcc_EngSpd2facIntegrator_CUR_y.DataType = 'single';
Lcc_EngSpd2facIntegrator_CUR_y.Value = [0.15 0.22 0.3 0.45 0.52	0.6	0.68];
Lcc_EngSpd2facIntegrator_CUR_y.StorageClass = 'ImportedExtern';
Lcc_EngSpd2facIntegrator_CUR_x = Simulink.Parameter;
Lcc_EngSpd2facIntegrator_CUR_x.DataType = 'single';
Lcc_EngSpd2facIntegrator_CUR_x.Value = [400.0	1000.0	2000.0	3000.0	4000.0	5000.0	6000.0];
Lcc_EngSpd2facIntegrator_CUR_x.StorageClass = 'ImportedExtern';
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Lcc_tiTnLambdaCorrPID_MAP_z = Simulink.Parameter;
Lcc_tiTnLambdaCorrPID_MAP_z.DataType = 'single';
Lcc_tiTnLambdaCorrPID_MAP_z.Value = ...
[1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0]';
Lcc_tiTnLambdaCorrPID_MAP_z.StorageClass = 'ImportedExtern';
Lcc_tiTnLambdaCorrPID_MAP_y = Simulink.Parameter;
Lcc_tiTnLambdaCorrPID_MAP_y.DataType = 'single';
Lcc_tiTnLambdaCorrPID_MAP_y.Value = [20000 50000 70000 90000 110000 130000 150000 170000 190000 210000];
Lcc_tiTnLambdaCorrPID_MAP_y.StorageClass = 'ImportedExtern';
Lcc_tiTnLambdaCorrPID_MAP_x = Simulink.Parameter;
Lcc_tiTnLambdaCorrPID_MAP_x.DataType = 'single';
Lcc_tiTnLambdaCorrPID_MAP_x.Value = [500.0	1000.0	1500.0	2000.0	2500.0	3000.0	3500.0	4000.0	4500.0	5000.0	5500.0	6000.0];
Lcc_tiTnLambdaCorrPID_MAP_x.StorageClass = 'ImportedExtern';
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Lcc_tiTvLambdaCorrPID_MAP_z = Simulink.Parameter;
Lcc_tiTvLambdaCorrPID_MAP_z.DataType = 'single';
Lcc_tiTvLambdaCorrPID_MAP_z.Value = ...
[0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0
0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0]';
Lcc_tiTvLambdaCorrPID_MAP_z.StorageClass = 'ImportedExtern';
Lcc_tiTvLambdaCorrPID_MAP_y = Simulink.Parameter;
Lcc_tiTvLambdaCorrPID_MAP_y.DataType = 'single';
Lcc_tiTvLambdaCorrPID_MAP_y.Value = [20000 50000 70000 90000 110000 130000 150000 170000 190000 210000];
Lcc_tiTvLambdaCorrPID_MAP_y.StorageClass = 'ImportedExtern';
Lcc_tiTvLambdaCorrPID_MAP_x = Simulink.Parameter;
Lcc_tiTvLambdaCorrPID_MAP_x.DataType = 'single';
Lcc_tiTvLambdaCorrPID_MAP_x.Value = [500.0	1000.0	1500.0	2000.0	2500.0	3000.0	3500.0	4000.0	4500.0	5000.0	5500.0	6000.0];
Lcc_tiTvLambdaCorrPID_MAP_x.StorageClass = 'ImportedExtern';
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Lcc_facKLambdaCorrPID_MAP_z = Simulink.Parameter;
Lcc_facKLambdaCorrPID_MAP_z.DataType = 'single';
Lcc_facKLambdaCorrPID_MAP_z.Value = ...
[1.0 1.0 1.0 1.0 1.0 1.0 0.0 0.0 0.0 0.0 0.0 0.0
1.0	1.0	1.0	1.0	1.0	1.0	0.0	0.0	0.0	0.0	0.0	0.0
1.0	1.0	1.0	1.0	1.0	1.0	0.0	0.0	0.0	0.0	0.0	0.0
1.0	1.0	1.0	1.0	1.0	1.0	0.0	0.0	0.0	0.0	0.0	0.0
1.0	1.0	1.0	1.0	1.0	1.0	0.0	0.0	0.0	0.0	0.0	0.0
1.0	1.0	1.0	1.0	1.0	1.0	0.0	0.0	0.0	0.0	0.0	0.0
1.0	1.0	1.0	1.0	1.0	1.0	0.0	0.0	0.0	0.0	0.0	0.0
1.0	1.0	1.0	1.0	1.0	1.0	0.0	0.0	0.0	0.0	0.0	0.0
1.0	1.0	1.0	1.0	1.0	1.0	0.0	0.0	0.0	0.0	0.0	0.0
1.0	1.0	1.0	1.0	1.0	1.0	0.0	0.0	0.0	0.0	0.0	0.0]';
Lcc_facKLambdaCorrPID_MAP_z.StorageClass = 'ImportedExtern';
Lcc_facKLambdaCorrPID_MAP_y = Simulink.Parameter;
Lcc_facKLambdaCorrPID_MAP_y.DataType = 'single';
Lcc_facKLambdaCorrPID_MAP_y.Value = [20000 50000 70000 90000 110000 130000 150000 170000 190000 210000];
Lcc_facKLambdaCorrPID_MAP_y.StorageClass = 'ImportedExtern';
Lcc_facKLambdaCorrPID_MAP_x = Simulink.Parameter;
Lcc_facKLambdaCorrPID_MAP_x.DataType = 'single';
Lcc_facKLambdaCorrPID_MAP_x.Value = [500.0	1000.0	1500.0	2000.0	2500.0	3000.0	3500.0	4000.0	4500.0	5000.0	5500.0	6000.0];
Lcc_facKLambdaCorrPID_MAP_x.StorageClass = 'ImportedExtern';