% Afr_tables
% Definition of tables as Simulink parameters
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Afr_atMani2facLambdaReqCorr_CUR_y = Simulink.Parameter;
Afr_atMani2facLambdaReqCorr_CUR_y.DataType = 'single';
Afr_atMani2facLambdaReqCorr_CUR_y.Value = [0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0	0.0];
Afr_atMani2facLambdaReqCorr_CUR_y.StorageClass = 'ImportedExtern';
Afr_atMani2facLambdaReqCorr_CUR_x = Simulink.Parameter;
Afr_atMani2facLambdaReqCorr_CUR_x.DataType = 'single';
Afr_atMani2facLambdaReqCorr_CUR_x.Value = [233.0	273.0	283.0	293.0	303.0	323.0	343.0	363.0	383.0	403.0];
Afr_atMani2facLambdaReqCorr_CUR_x.StorageClass = 'ImportedExtern';
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Afr_atCool2facLambdaReqCorr_CUR_y = Simulink.Parameter;
Afr_atCool2facLambdaReqCorr_CUR_y.DataType = 'single';
Afr_atCool2facLambdaReqCorr_CUR_y.Value = [-0.4025	-0.202	-0.162	-0.127	-0.081	-0.029	0.0	0.0	0.0	0.0];
Afr_atCool2facLambdaReqCorr_CUR_y.StorageClass = 'ImportedExtern';
Afr_atCool2facLambdaReqCorr_CUR_x = Simulink.Parameter;
Afr_atCool2facLambdaReqCorr_CUR_x.DataType = 'single';
Afr_atCool2facLambdaReqCorr_CUR_x.Value = [233.0	273.0	283.0	293.0	303.0	323.0	343.0	363.0	383.0	403.0];
Afr_atCool2facLambdaReqCorr_CUR_x.StorageClass = 'ImportedExtern';
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Afr_rpmEngSpdfacRelAir2facLambdaReqBase_MAP_z = Simulink.Parameter;
Afr_rpmEngSpdfacRelAir2facLambdaReqBase_MAP_z.DataType = 'single';
Afr_rpmEngSpdfacRelAir2facLambdaReqBase_MAP_z.Value = ...
[1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0 1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	0.9609375	0.9609375	0.9609375	1.0	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	0.9375	0.9609375	0.9609375	1.0	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	0.9375	0.9609375	0.9609375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	0.9375	0.9609375	0.9609375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	0.9375	0.9609375	0.9609375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	0.9375	0.9609375	0.9609375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	0.9375	0.9609375	0.9609375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	0.9375	0.9609375	0.9609375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	0.9375	0.9609375	0.9609375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	0.9375	0.9609375	0.9609375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	0.9375	0.9609375	0.9609375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375
1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	1.0	0.9375	0.9609375	0.9609375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375	0.8984375]';
Afr_rpmEngSpdfacRelAir2facLambdaReqBase_MAP_z.StorageClass = 'ImportedExtern';
Afr_rpmEngSpdfacRelAir2facLambdaReqBase_MAP_y = Simulink.Parameter;
Afr_rpmEngSpdfacRelAir2facLambdaReqBase_MAP_y.DataType = 'single';
Afr_rpmEngSpdfacRelAir2facLambdaReqBase_MAP_y.Value = [0.000 0.050 0.100 0.150 0.200 0.250 0.300 0.400 0.500 0.600 0.700 0.800 0.900 1.000 1.100 1.200 1.300 1.400 1.500 1.600 1.700 1.800 1.900 2.000 2.100 2.200 2.300 2.400 2.500];
Afr_rpmEngSpdfacRelAir2facLambdaReqBase_MAP_y.StorageClass = 'ImportedExtern';
Afr_rpmEngSpdfacRelAir2facLambdaReqBase_MAP_x = Simulink.Parameter;
Afr_rpmEngSpdfacRelAir2facLambdaReqBase_MAP_x.DataType = 'single';
Afr_rpmEngSpdfacRelAir2facLambdaReqBase_MAP_x.Value = [500.0	750.0	1000.0	1250.0	1500.0	1750.0	2000.0	2250.0	2500.0	2750.0	3000.0	3500.0	4000.0	4500.0	5000.0	5500.0	6000.0	6500.0	7000.0];
Afr_rpmEngSpdfacRelAir2facLambdaReqBase_MAP_x.StorageClass = 'ImportedExtern';