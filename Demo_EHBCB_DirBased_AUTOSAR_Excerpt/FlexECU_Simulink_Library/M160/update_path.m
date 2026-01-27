% title:    update_path.m
% autor:    Alexander Weber
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
% path for parameters
addpath '.\parameters'
if(1)
% load parameters Sensors
load('Egc_parameters.mat')
load('Ctc_parameters.mat')
load('Mtc_parameters.mat')
load('Mpc_parameters.mat')
load('Cpc_parameters.mat')
load('Bvc_parameters.mat')
load('Opc_parameters.mat')
load('Amc_parameters.mat')
% load parameters Actuators
load('Tvc_parameters.mat')
load('Mrs_parameters.mat')
load('Icc_parameters.mat')
load('Fps_parameters.mat')
load('Ivc_parameters.mat')
load('Wcs_parameters.mat')
load('Wgc_parameters.mat')
load('Ics_parameters.mat')
load('Apv_parameters.mat')
load('Ais_parameters.mat')
load('Cov_parameters.mat')
load('Str_parameters.mat')
% load parameters Functions
load('Doh_parameters.mat')
load('Opm_parameters.mat')
load('Dummy_parameters.mat')
load('Amf_parameters.mat')
load('Afr_parameters.mat')
load('Tqs_parameters.mat')
load('Itc_parameters.mat')
load('Fmc_parameters.mat')
load('Iac_parameters.mat')
load('T2t_parameters.mat')
load('ICC_1_parameters.mat')
load('Stc_parameters.mat')
load('Lcc_parameters.mat')
load('Isc_parameters.mat')
end
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
% path for signals
addpath '.\signals'
if(1)
% load signals BSW
load('BSW.mat')
% load signals Sensors
load('Egc_signals.mat')
load('Ctc_signals.mat')
load('Mtc_signals.mat')
load('Mpc_signals.mat')
load('Cpc_signals.mat')
load('Bvc_signals.mat')
load('Opc_signals.mat')
load('Amc_signals.mat')
load('Klemme50_signals.mat')
% load signals Actuators
load('Tvc_signals.mat')
load('Mrs_signals.mat')
load('Icc_signals.mat')
load('Fps_signals.mat')
load('Ivc_signals.mat')
load('Wcs_signals.mat')
load('Wgc_signals.mat')
load('Ics_signals.mat')
load('Apv_signals.mat')
load('Ais_signals.mat')
load('Cov_signals.mat')
load('Str_signals.mat')
% load signals Functions
load('Eih_signals.mat')
load('Eoh_signals.mat')
load('Doh_signals.mat')
load('Opm_signals.mat')
load('Dummy_signals.mat')
load('Amf_signals.mat')
load('Afr_signals.mat')
load('Tqs_signals.mat')
load('Itc_signals.mat')
load('Fmc_signals.mat')
load('Iac_signals.mat')
load('T2t_signals.mat')
load('ICC_1_signals.mat')
load('Stc_signals.mat')
load('Lcc_signals.mat')
load('Isc_signals.mat')
end
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
% path for enumerations
addpath '.\enumerations'
if(1)
% define enumerations
run('Pwmout_act_t_')
run('enumOperationMode')
run('CdrvInterfaceError_type_')
run('Diagnosis_Errors')
end
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
% path for tables
addpath '.\tables'
if(1)
% define tables
run('Egc_tables')
run('Ctc_tables')
run('Mtc_tables')
run('Mpc_tables')
run('Cpc_tables')
run('Amc_tables')
run('Tvc_tables')
run('Amf_tables')
run('Afr_tables')
run('Tqs_tables')
run('Itc_tables')
run('Iac_tables')
run('T2t_tables')
run('Stc_tables')
run('Lcc_tables')
run('Isc_tables')
end
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
% path for images
addpath '.\images'