% enumOperationMode
% Definition of enums as Simulink parameters
Off = Simulink.Parameter;
Off.DataType = 'single';
Off.Value = 0;
Off.StorageClass = 'ImportedExtern';
Normal = Simulink.Parameter;
Normal.DataType = 'single';
Normal.Value = 1;
Normal.StorageClass = 'ImportedExtern';
IOError = Simulink.Parameter;
IOError.DataType = 'single';
IOError.Value = 2;
IOError.StorageClass = 'ImportedExtern';