% Throttle_formulas
% Definition of formulas as Simulink NumericType
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_10 = Simulink.NumericType;
fac_10.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_10.Signedness = 'Auto';
fac_10.WordLength = 16;
fac_10.Slope = 1/10;
fac_10.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_100 = Simulink.NumericType;
fac_100.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_100.Signedness = 'Auto';
fac_100.WordLength = 16;
fac_100.Slope = 1/100;
fac_100.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_1000 = Simulink.NumericType;
fac_1000.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_1000.Signedness = 'Auto';
fac_1000.WordLength = 16;
fac_1000.Slope = 1/1000;
fac_1000.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_10000 = Simulink.NumericType;
fac_10000.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_10000.Signedness = 'Auto';
fac_10000.WordLength = 16;
fac_10000.Slope = 1/10000;
fac_10000.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_1024 = Simulink.NumericType;
fac_1024.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_1024.Signedness = 'Signed';
fac_1024.WordLength = 16;
fac_1024.Slope = 1/1024;
fac_1024.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_128 = Simulink.NumericType;
fac_128.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_128.Signedness = 'Unsigned';
fac_128.WordLength = 16;
fac_128.Slope = 1/128;
fac_128.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_16 = Simulink.NumericType;
fac_16.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_16.Signedness = 'Auto';
fac_16.WordLength = 16;
fac_16.Slope = 1/16;
fac_16.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_16384 = Simulink.NumericType;
fac_16384.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_16384.Signedness = 'Auto';
fac_16384.WordLength = 16;
fac_16384.Slope = 1/16384;
fac_16384.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_1div10 = Simulink.NumericType;
fac_1div10.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_1div10.Signedness = 'Unsigned';
fac_1div10.WordLength = 16;
fac_1div10.Slope = 10;
fac_1div10.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_1div100 = Simulink.NumericType;
fac_1div100.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_1div100.Signedness = 'Auto';
fac_1div100.WordLength = 16;
fac_1div100.Slope = 100;
fac_1div100.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_1div1024 = Simulink.NumericType;
fac_1div1024.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_1div1024.Signedness = 'Auto';
fac_1div1024.WordLength = 16;
fac_1div1024.Slope = 1024;
fac_1div1024.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_1div16 = Simulink.NumericType;
fac_1div16.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_1div16.Signedness = 'Auto';
fac_1div16.WordLength = 16;
fac_1div16.Slope = 16;
fac_1div16.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_1div4 = Simulink.NumericType;
fac_1div4.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_1div4.Signedness = 'Auto';
fac_1div4.WordLength = 16;
fac_1div4.Slope = 4;
fac_1div4.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_1div6 = Simulink.NumericType;
fac_1div6.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_1div6.Signedness = 'Auto';
fac_1div6.WordLength = 16;
fac_1div6.Slope = 6;
fac_1div6.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_1div8 = Simulink.NumericType;
fac_1div8.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_1div8.Signedness = 'Auto';
fac_1div8.WordLength = 16;
fac_1div8.Slope = 8;
fac_1div8.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_2 = Simulink.NumericType;
fac_2.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_2.Signedness = 'Auto';
fac_2.WordLength = 16;
fac_2.Slope = 1/2;
fac_2.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_2048 = Simulink.NumericType;
fac_2048.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_2048.Signedness = 'Auto';
fac_2048.WordLength = 16;
fac_2048.Slope = 1/2048;
fac_2048.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_256 = Simulink.NumericType;
fac_256.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_256.Signedness = 'Auto';
fac_256.WordLength = 16;
fac_256.Slope = 1/256;
fac_256.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_32 = Simulink.NumericType;
fac_32.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_32.Signedness = 'Auto';
fac_32.WordLength = 16;
fac_32.Slope = 1/32;
fac_32.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_4 = Simulink.NumericType;
fac_4.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_4.Signedness = 'Auto';
fac_4.WordLength = 16;
fac_4.Slope = 1/4;
fac_4.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_4096 = Simulink.NumericType;
fac_4096.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_4096.Signedness = 'Auto';
fac_4096.WordLength = 16;
fac_4096.Slope = 1/4096;
fac_4096.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_512 = Simulink.NumericType;
fac_512.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_512.Signedness = 'Unsigned';
fac_512.WordLength = 16;
fac_512.Slope = 1/512;
fac_512.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_64 = Simulink.NumericType;
fac_64.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_64.Signedness = 'Auto';
fac_64.WordLength = 16;
fac_64.Slope = 1/64;
fac_64.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_65536 = Simulink.NumericType;
fac_65536.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_65536.Signedness = 'Auto';
fac_65536.WordLength = 16;
fac_65536.Slope = 1/65536;
fac_65536.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_8 = Simulink.NumericType;
fac_8.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_8.Signedness = 'Auto';
fac_8.WordLength = 16;
fac_8.Slope = 1/8;
fac_8.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
fac_8192 = Simulink.NumericType;
fac_8192.DataTypeMode = 'Fixed-point: slope and bias scaling';
fac_8192.Signedness = 'Auto';
fac_8192.WordLength = 16;
fac_8192.Slope = 1/8192;
fac_8192.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
IA_10bit_2_u = Simulink.NumericType;
IA_10bit_2_u.DataTypeMode = 'Fixed-point: slope and bias scaling';
IA_10bit_2_u.Signedness = 'Signed';
IA_10bit_2_u.WordLength = 16;
IA_10bit_2_u.Slope = 5/1023;
IA_10bit_2_u.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
ident = Simulink.NumericType;
ident.DataTypeMode = 'Fixed-point: slope and bias scaling';
ident.Signedness = 'Unsigned';
ident.WordLength = 8;
ident.Slope = 1;
ident.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
IGN_4div3 = Simulink.NumericType;
IGN_4div3.DataTypeMode = 'Fixed-point: slope and bias scaling';
IGN_4div3.Signedness = 'Auto';
IGN_4div3.WordLength = 16;
IGN_4div3.Slope = 3/4;
IGN_4div3.isAlias = true;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%