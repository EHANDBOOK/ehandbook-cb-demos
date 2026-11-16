%CREATE_ABS_MODEL Generate a minimal ABS slip controller Simulink model.
%   Creates Input/ABS/ABS_Ctrl.slx with the blocks:
%   Slip Calculation -> Slip Error (with Desired Slip) -> Bang-Bang Controller
%   -> Hydraulic Lag -> Brake Gain.
%   Calibration parameters are stored as Simulink.Parameter objects in the
%   model workspace.

mdl = 'ABS_Ctrl';
outDir = fullfile(fileparts(mfilename('fullpath')), 'Input', 'ABS');

if bdIsLoaded(mdl)
    close_system(mdl, 0);
end

if ~isfolder(outDir)
    mkdir(outDir);
end

new_system(mdl);
set_param(mdl, 'StopTime', '10', ...
    'Description', 'Simplified ABS slip controller (bang-bang) for EHANDBOOK training.');

%% Calibration parameters (model workspace)
%        Name             Value   Unit   Min     Max     Description
params = {'ABS_SlipRef', 0.2, '1', 0, 1, 'Target wheel slip (near peak tire friction)'
          'ABS_HydrLagTb', 0.01, 's', 0.001, 0.5, 'Time constant of the brake hydraulics'
          'ABS_BrkGainKf', 1500, 'N*m', 0, 5000, 'Brake gain from pressure command to brake torque'
          'ABS_WhlRadius', 0.3, 'm', 0.1, 0.6, 'Dynamic wheel radius'};

hws = get_param(mdl, 'ModelWorkspace');

for k = 1:size(params, 1)
    p = Simulink.Parameter(params{k, 2});
    p.Unit = params{k, 3};
    p.Min = params{k, 4};
    p.Max = params{k, 5};
    p.Description = params{k, 6};
    hws.assignin(params{k, 1}, p);
end

%% Blocks
add_block('simulink/Sources/In1', [mdl '/v_veh'], ...
    'Position', [30 56 60 70], 'Unit', 'm/s');
add_block('simulink/Sources/In1', [mdl '/w_whl'], ...
    'Position', [30 90 60 104], 'Unit', 'rad/s');

% 140x100 px so the normalized wheel icon below renders as a circle
add_block('simulink/User-Defined Functions/MATLAB Function', [mdl '/Slip Calculation'], ...
    'Position', [120 30 260 130], ...
    'Description', 'Wheel slip lambda = 1 - w*R/v');
chart = sfroot().find('-isa', 'Stateflow.EMChart', 'Path', [mdl '/Slip Calculation']);
chart.Script = sprintf([ ...
                            'function lambda = slip_calc(v_veh, w_whl, ABS_WhlRadius)\n' ...
                            '%%#codegen\n' ...
                            '%% Guard against division by zero at standstill\n' ...
                            'v = max(v_veh, 0.1);\n' ...
                        'lambda = 1 - (w_whl * ABS_WhlRadius) / v;\n']);
radiusData = chart.find('-isa', 'Stateflow.Data', 'Name', 'ABS_WhlRadius');
radiusData.Scope = 'Parameter';

% Mask icon: tire with rim and hub, rotation arrow, road line and slip formula
iconCode = {
            'tt = linspace(0, 2*pi, 48);'
            'cx = 0.5; cy = 0.6; rx = 0.16; ry = 0.22;'
            'patch(cx + rx*cos(tt), cy + ry*sin(tt), [0.25 0.27 0.32]);'
            'patch(cx + 0.6*rx*cos(tt), cy + 0.6*ry*sin(tt), [0 0.45 0.81]);'
            'patch(cx + 0.2*rx*cos(tt), cy + 0.2*ry*sin(tt), [1 1 1]);'
            'ta = linspace(5*pi/6, pi/6, 20);'
            'plot(cx + 0.22*cos(ta), cy + 0.30*sin(ta));'
            'patch([0.69 0.686 0.636], [0.75 0.839 0.799], [0 0 0]);'
            'plot([0.28 0.72], [0.38 0.38]);'
            'text(0.5, 0.16, ''\lambda = 1 - \omega R / v'', ''horizontalAlignment'', ''center'', ''texmode'', ''on'');'
            'port_label(''input'', 1, ''v'');'
            'port_label(''input'', 2, ''\omega'', ''texmode'', ''on'');'
            'port_label(''output'', 1, ''\lambda'', ''texmode'', ''on'');'
            };
slipMask = Simulink.Mask.create([mdl '/Slip Calculation']);
slipMask.Type = 'Wheel Slip';
slipMask.Description = 'Computes the longitudinal wheel slip from vehicle speed and wheel speed.';
slipMask.IconUnits = 'normalized';
slipMask.IconOpaque = 'opaque';
slipMask.Display = strjoin(iconCode, newline);

add_block('simulink/Sources/Constant', [mdl '/Desired Slip'], ...
    'Position', [280 15 340 45], 'Value', 'ABS_SlipRef', ...
    'Description', 'Target slip reference');

add_block('simulink/Math Operations/Sum', [mdl '/Slip Error'], ...
    'Position', [400 60 430 100], 'Inputs', '+-', 'IconShape', 'round', ...
    'Description', 'e = lambda_ref - lambda');

add_block('simulink/Math Operations/Sign', [mdl '/Bang-Bang Controller'], ...
    'Position', [480 65 520 95], ...
    'Description', '+1: build up pressure, -1: release pressure');

add_block('simulink/Continuous/Transfer Fcn', [mdl '/Hydraulic Lag'], ...
    'Position', [570 55 670 105], ...
    'Numerator', '1', 'Denominator', '[ABS_HydrLagTb 1]', ...
    'Description', 'First-order lag of the brake hydraulics');

add_block('simulink/Math Operations/Gain', [mdl '/Brake Gain'], ...
    'Position', [720 65 760 95], 'Gain', 'ABS_BrkGainKf', ...
    'Description', 'Converts pressure command to brake torque');

add_block('simulink/Sinks/Out1', [mdl '/T_brake'], ...
    'Position', [810 73 840 87], 'Unit', 'N*m');

%% Signal lines
addSignal = @(src, dst, name) set_param( ...
    add_line(mdl, src, dst, 'autorouting', 'smart'), 'Name', name);

addSignal('v_veh/1', 'Slip Calculation/1', 'v_veh');
addSignal('w_whl/1', 'Slip Calculation/2', 'w_whl');
addSignal('Desired Slip/1', 'Slip Error/1', 'lambda_ref');
addSignal('Slip Calculation/1', 'Slip Error/2', 'lambda');
addSignal('Slip Error/1', 'Bang-Bang Controller/1', 'e_slip');
addSignal('Bang-Bang Controller/1', 'Hydraulic Lag/1', 'u_cmd');
addSignal('Hydraulic Lag/1', 'Brake Gain/1', 'p_brake');
addSignal('Brake Gain/1', 'T_brake/1', 'T_brake');

%% Save
save_system(mdl, fullfile(outDir, [mdl '.slx']));
open_system(mdl);
fprintf('Model saved to %s\n', fullfile(outDir, [mdl '.slx']));
