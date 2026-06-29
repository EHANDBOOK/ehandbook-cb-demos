% Amc_tables
% Definition of tables as Simulink parameters
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Amc_uSens2AirMassFlow_CUR_y = Simulink.Parameter;
Amc_uSens2AirMassFlow_CUR_y.DataType = 'single';
Amc_uSens2AirMassFlow_CUR_y.Value = [8.0	10.0	15.0	30.0	60.0	120.0	250.0	370.0	480.0];
Amc_uSens2AirMassFlow_CUR_y.StorageClass = 'ImportedExtern';
Amc_uSens2AirMassFlow_CUR_x = Simulink.Parameter;
Amc_uSens2AirMassFlow_CUR_x.DataType = 'single';
Amc_uSens2AirMassFlow_CUR_x.Value = [1.293	1.364	1.524	1.875	2.371	3.0	3.749	4.17	4.458];
Amc_uSens2AirMassFlow_CUR_x.StorageClass = 'ImportedExtern';