% Mpc_tables
% Definition of tables as Simulink parameters
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Mpc_uSens2pManiBase_CUR_y = Simulink.Parameter;
Mpc_uSens2pManiBase_CUR_y.DataType = 'single';
Mpc_uSens2pManiBase_CUR_y.Value = [20000.0	250000.0];
Mpc_uSens2pManiBase_CUR_y.StorageClass = 'ImportedExtern';
Mpc_uSens2pManiBase_CUR_x = Simulink.Parameter;
Mpc_uSens2pManiBase_CUR_x.DataType = 'single';
Mpc_uSens2pManiBase_CUR_x.Value = [0.4	4.65];
Mpc_uSens2pManiBase_CUR_x.StorageClass = 'ImportedExtern';
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
Mpc_atManiTmp2facPresCorr_CUR_y = Simulink.Parameter;
Mpc_atManiTmp2facPresCorr_CUR_y.DataType = 'single';
Mpc_atManiTmp2facPresCorr_CUR_y.Value = [1.0 1.0 1.0 1.0];
Mpc_atManiTmp2facPresCorr_CUR_y.StorageClass = 'ImportedExtern';
Mpc_atManiTmp2facPresCorr_CUR_x = Simulink.Parameter;
Mpc_atManiTmp2facPresCorr_CUR_x.DataType = 'single';
Mpc_atManiTmp2facPresCorr_CUR_x.Value = [233.0	283.0	358.0	403.0];
Mpc_atManiTmp2facPresCorr_CUR_x.StorageClass = 'ImportedExtern';