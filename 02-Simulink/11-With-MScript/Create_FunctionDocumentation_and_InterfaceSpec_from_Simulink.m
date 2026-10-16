%===============================================================================
% The script creates xls, adoc and rtf out of slx/mdl files for EHB-CB
% It parses a directory structure for any model and places
% a xls, adoc and rtf there
%
% Limits:
% only one model per sub-dir
% script only works, if an empty root directory is there as input!!!!!
%===============================================================================

clc
clear all

%-------------------------------------------------------------------------------
%--- Pre-defined value for system 
%-------------------------------------------------------------------------------
%--- for MS-Word language version
KOR       = 0;
ENG       = 1;
GER       = 2;
%--- for Background Color 
BLUE      = 'blue';
WHITE     = 'white';
%--- input file extention *.slx or *.mdl
MDL       = '*.mdl';
SLX       = '*.slx';

%-------------------------------------------------------------------------------
%--- Tasks : Running Configuration
%-------------------------------------------------------------------------------
%--- Create RTF file true/false
CreateRTF  = false;
%--- Create ASCIIDoc file true/false
CreateASCIIDoc  = true;
%--- Create XLS file true/false
CreateXLS  = true;
%--- Delete all comments from model true/false
DelComment = false;
%--- Change color for all sub system blocks true/false
BackgroundColor           = WHITE
ChangeBackgroundColor     = false;
%--- MS-Word version KOR/ENG/GER
MSWordVer       = GER;
%--- Open folder via UI or fixed path
FixedWorkingPath = false;
WorkingPathName  = '';
%--- set input file extention MDL/SLX
InputFileExtention = SLX

		
%-------------------------------------------------------------------------------
%--- Set font style for RTF depending of the MS Word Language Version
%-------------------------------------------------------------------------------
if MSWordVer == KOR
	FileNameTempStyle='力格 1';
	FunctionOverviewStyle='力格 2';
	ehbfunctionoverviewbeginStyle='钎霖';
	FunctionDescriptionStyle='力格 2';
	ehbmodelrefStyle='钎霖';
	SubSystemNameStyle = '母记';
elseif MSWordVer == ENG
	FileNameTempStyle='Heading 1';
	FunctionOverviewStyle='Heading 2';
	ehbfunctionoverviewbeginStyle='Normal';
	FunctionDescriptionStyle='Heading 2';
	ehbmodelrefStyle='Normal';
	SubSystemNameStyle = 'Caption';
elseif MSWordVer == GER
	FileNameTempStyle='躡erschrift 1';
	FunctionOverviewStyle='躡erschrift 2';
	ehbfunctionoverviewbeginStyle='Standard';
	FunctionDescriptionStyle='躡erschrift 2';
	ehbmodelrefStyle='Standard';
	SubSystemNameStyle = 'Beschriftung';
end

%--- search for all model files in a root directory via UI menu
if FixedWorkingPath ~= true
	disp('Select search path...');
	WorkingPathName = uigetdir;
end 

%--- search for all sub directories --------------------------------------------
dirs = genpath(WorkingPathName);
subSearch = regexp(dirs, ';', 'split');

path = [];
file = [];
iterFile = 1;
disp(['Path is: ', WorkingPathName]);
disp('Searching for models there... ');

%--- look, if a model is in any sub directory ----------------------------------
for iterSub = 1: length(subSearch)
    fileFound = dir(fullfile(subSearch{iterSub}, InputFileExtention)); 
	
    if ~isempty(fileFound)
        path{iterFile} = strcat(subSearch{iterSub},'\');
        file{iterFile} = fileFound.name;
        % calFiles{iterFile} = strcat(sub{iterSub},'\',fileFound.name);
        iterFile = iterFile+1;
    end
end

disp([int2str(length(path)),' models found!']);

	[ActXWord]=StartWord;

for iterFile = 1:length(path)

    fileNameTemp = file{iterFile};
    %--- delete slx from file name
    fileNameTemp = fileNameTemp(1:end-4);
    modelNamePath = strcat(path{iterFile},fileNameTemp);

    open_system(modelNamePath,'loadonly');
    disp(['Calculate input data for EHB-CB from ',modelNamePath]);

    % EHB_txt = find_system(bdroot,'FindAll','On','type','Annotation');
    % EHB_txt_names = get(EHB_txt,'Name');
    % EHB_txt_paths = get(EHB_txt,'Path');

    %---------------------------------------------------------------------------
    %--- Delete Comment or Changing background color
	%---------------------------------------------------------------------------
	if (DelComment == true) ||  (ChangeBackgroundColor == true)
		%--- Set Table attribute and hide original map name
		SL_obj = find_system(bdroot,'FindAll','On','LookUnderMasks','all','BlockType','Lookup_n-D');
		[x1,y1]=size(SL_obj);
		for k=1:x1
			%--- set the %<Table> attribute in its annotation fields to make it visible in EHB
			set(SL_obj(k,1),'AttributesFormatString','%<Table>');
			%--- hide the original map name (here 2-D Lookup Table, which is useless for EHB).
			set(SL_obj(k,1),'ShowName','off');
		end
		
		%-----------------------------------------------------------------------
		%--- Changing background color
		%-----------------------------------------------------------------------
		if (ChangeBackgroundColor == true)
			% --- Get all Sub Systems 
			SL_obj = find_system(bdroot,'FindAll','On','LookUnderMasks','all','BlockType','SubSystem');
		EHB_const = find_system(bdroot,'FindAll','On','LookUnderMasks','all','BlockType','Constant');            
			[x1,y1]=size(SL_obj);
			for k=1:x1
				set(SL_obj(k,1),'BackgroundColor',BackgroundColor); 
			end
		end
		
		%-----------------------------------------------------------------------
		%--- Delete Comment 
		%-----------------------------------------------------------------------
		if (DelComment == true)
			% --- Get all Annotations 
			SL_obj = find_system(bdroot,'FindAll','On','LookUnderMasks','all','type','Annotation');
			[x1,y1]=size(SL_obj);
			for k=1:x1
				delete (SL_obj(k,1));
			end
		end 
		save_system(fileNameTemp);
	end 

    %---------------------------------------------------------------------------
    %--- Create XLS file
	%---------------------------------------------------------------------------
	if CreateXLS == true
		%-----------------------------------------------------------------------
		%--- Get the Local Variables 
		%-----------------------------------------------------------------------
		k = 1;
		EHB_loc = find_system(bdroot,'FindAll','On','LookUnderMasks','all','Type',...
							  'line','SegmentType','trunk'); %'FollowLinks','on',
		temp=get(EHB_loc(:),'Name');
		[x1,y1]=size(EHB_loc);
		result = cell(x1+1,12);
		%--- Define column headings for signals tab in xls
		result(1,:) = {'*', 'Mark', 'Xref', 'Class', 'Name', 'Description', 'Tag',... 
					   'SignalType', 'Unit', 'OutMin', 'OutMax','Parent'};

        
% 		for i =1:length(EHB_loc)
% 			if ~isempty(get(EHB_loc(i,1),'Name'))
% 				temp = strcmp((get(EHB_loc(i,1),'SignalPropagation')),'on');
% 				if temp == 0
% 				% EHB_loc = get(L(i),'Name');
% 				result(k+1,:) = {'','','LOC','RAM',char(get(EHB_loc(i,1),'Name')),...
% 								 char(get(EHB_loc(i,1),'Description')),...
% 								 char(get(EHB_loc(i,1),'Tag')),...
% 								 char(get(EHB_loc(i,1),'Type')),...
% 								 '',...
% 								 '',...
% 								 '',...
% 								 char(get(EHB_loc(i,1),'Parent'));};
% 				k = k + 1;
% 				end
% 			end
% 		end

		%--- Write results to Excel file
		excelFile = strcat(modelNamePath,'.xlsx');
		status = xlswrite(excelFile, result, 'Signal');
		[lastmsg,lastid] = lastwarn;
		warning('off',lastid);
		
		last_pos_xls = k;

		%-----------------------------------------------------------------------
		%--- Get In- & Output Port Signals 
		%-----------------------------------------------------------------------
		%--- Query the system for the inport blocks on root level
		EHB_inports = find_system(bdroot,'FindAll','On','SearchDepth',1,'BlockType','Inport');

		%--- Query the system for the outport blocks on root level
		EHB_outports = find_system(bdroot,'FindAll','On','SearchDepth',1,'BlockType','Outport');

		EHB_ports = [EHB_inports;EHB_outports];

		%--- Get size of port names cell array
		[x1,y1]=size(EHB_ports);

		%--- Define size of result cell array
		result = cell(x1,11);

		%--- Collect in- & output signals --------------------------------------
		for k=1:x1
			mode = char(get(EHB_ports(k,1),'BlockType'));
			mode = upper(mode(1:end-4));
			result(k,:) = { '', '', mode, 'RAM',... 
							char(get(EHB_ports(k,1),'Name')),... 
							char(get(EHB_ports(k,1),'Description')),...
							char(get(EHB_ports(k,1),'Tag')),... 
							char(get(EHB_ports(k,1),'SignalType')),... 
							char(get(EHB_ports(k,1),'Unit')),... 
							char(get(EHB_ports(k,1),'OutMin')),... 
							char(get(EHB_ports(k,1),'OutMax')) ; };
		end

		% Write results to Excel file
		pos = strcat('A',int2str(last_pos_xls+1));
		excelFile = strcat(modelNamePath,'.xlsx');
		status = xlswrite(excelFile, result, 'Signal',pos);
		[lastmsg,lastid] = lastwarn;
		warning('off',lastid);
		
		%-----------------------------------------------------------------------
		% --- Get Maps & Curves 
		%-----------------------------------------------------------------------
		EHB_maps = find_system(bdroot,'FindAll','On','LookUnderMasks','all','BlockType','Lookup_n-D');
		[x1,y1]=size(EHB_maps);
		result = cell(x1+1,14);
		result(1,:) = {'*', 'Mark', 'Xref', 'Class', 'Name', 'Description', 'Tag',... 
					   'Type', 'Value', 'X-Axis', 'Y-Axis', 'OutMin', 'OutMax','Parent'};
		for k=1:x1
			mode = char(get(EHB_maps(k,1),'NumberOfTableDimensions'));
			if mode == '2' % --- Map
				result(k+1,:) = { '', '', 'LOC', 'MAP',... 
								  char(get(EHB_maps(k,1),'Name')),...
								  char(get(EHB_maps(k,1),'Description')),...
								  char(get(EHB_maps(k,1),'Tag')),...
								  char(get(EHB_maps(k,1),'Type')),...
								  char(get(EHB_maps(k,1),'Table')),...
								  char(get(EHB_maps(k,1),'BreakpointsForDimension1')),...
								  char(get(EHB_maps(k,1),'BreakpointsForDimension2')),...
								  char(get(EHB_maps(k,1),'OutMin')),...
								  char(get(EHB_maps(k,1),'OutMax')),...
								  char(get(EHB_maps(k,1),'Parent')) ; };

			else   % --- Curve
				result(k+1,:) = { '', '', 'LOC', 'CURVE',... 
								  char(get(EHB_maps(k,1),'Name')),... 
								  char(get(EHB_maps(k,1),'Description')),...
								  char(get(EHB_maps(k,1),'Tag')),...
								  char(get(EHB_maps(k,1),'Type')),...
								  char(get(EHB_maps(k,1),'Table')),...
								  char(get(EHB_maps(k,1),'BreakpointsForDimension1')),...
								  ' - ',...
								  char(get(EHB_maps(k,1),'OutMin')),...
								  char(get(EHB_maps(k,1),'OutMax')),...
								  char(get(EHB_maps(k,1),'Parent')) ; };

			end
		end
		last_pos_xls = x1+1;

		% Write results to Excel file
		status = xlswrite(excelFile, result, 'Calibration');
		[lastmsg,lastid] = lastwarn;
		warning('off',lastid);
		
		%-----------------------------------------------------------------------
		% --- Get Constant Parameters 
		%-----------------------------------------------------------------------
		EHB_const = find_system(bdroot,'FindAll','On','LookUnderMasks','all','BlockType','Constant');
		[x1,y1]=size(EHB_const);
		result = cell(x1,14);
		for k=1:x1
			constVal= char(get(EHB_const(k,1),'Value'));
			if isnan(str2double(constVal))
				% set(EHB_const(k,1),'NAME',constName); %change the constant
				%--- name in the model to the name in the 'value' field
				constName = char(get(EHB_const(k,1),'Value'));
			else
				constName = char(get(EHB_const(k,1),'Name'));
			end
			result(k,:) = { '', '', 'LOC', 'CONST', constName,... 
							char(get(EHB_const(k,1),'Description')),...
							char(get(EHB_const(k,1),'Tag')),...
							char(get(EHB_const(k,1),'Type')),...
							char(get(EHB_const(k,1),'Value')),...
							' - ',...
							' - ',...
							char(get(EHB_const(k,1),'OutMin')),...
							char(get(EHB_const(k,1),'OutMax')),...
							char(get(EHB_const(k,1),'Parent')) ; };
		end

		pos = strcat('A',int2str(last_pos_xls+1));

		% Write results to Excel file
		status = xlswrite(excelFile, result, 'Calibration',pos);
		[lastmsg,lastid] = lastwarn;
		warning('off',lastid);
		disp(['File written: ..\',fileNameTemp,'.xlsx']);
	end 
	
    %---------------------------------------------------------------------------
    %--- Create RTF file
	%---------------------------------------------------------------------------
	if CreateRTF == true	
		%-----------------------------------------------------------------------
		%--- Create RTF document with content
		%-----------------------------------------------------------------------
		% disp(['Creating RTF file in  ', path{iterFile}]);

		WordFileName = strcat(modelNamePath,'.rtf');
		[WordHandle]=OpenWordFile(ActXWord, WordFileName);
		
		EHB_path = find_system(bdroot,'FindAll','On','LookUnderMasks','all','SearchDepth',1,'BlockType','SubSystem');
		subSystemName = char(get(EHB_path(1,1),'Name'));
		subSystemPath = char(get(EHB_path(1,1),'Parent'));

		%--- Title of Model
		WordText(ActXWord,fileNameTemp,FileNameTempStyle,[0,2]); 

		%--- 'Function Overview'
		WordText(ActXWord,'Function Overview',FunctionOverviewStyle,[0,1]);

		%--- Function Overview model view and 'Here you get an overview of this module:'
		WordText(ActXWord,'Here you get an overview of this module:',ehbfunctionoverviewbeginStyle,[0,1]);
		WordText(ActXWord,'[ehbfunctionoverview-begin]',ehbfunctionoverviewbeginStyle,[0,1]);
		%--- Org
% 		[filepath,name,ext] = fileparts(excelFile);
		result = regexp(modelNamePath,'\','split');
		subDir = char(result(length(result)-1));
		% WordText(ActXWord,subDir,ehbfunctionoverviewbeginStyle,[0,1]);
		WordText(ActXWord,subDir,ehbfunctionoverviewbeginStyle,[0,1]);
		WordText(ActXWord,'[ehbfunctionoverview-end]',ehbfunctionoverviewbeginStyle,[0,1]);

		%--- 'Function Description'
		WordText(ActXWord,'Function Description',FunctionDescriptionStyle,[0,1]);

		%--- 'The following model screenshot shows the first level subsystem of the function.'
		WordText(ActXWord,'The following model screenshot shows the first level subsystem of the function.',ehbmodelrefStyle,[0,1]);
		WordText(ActXWord,'[ehbmodelref]',ehbmodelrefStyle,[0,1]);

		%--- Model load
		modelPath = strcat(subSystemPath,'/',subSystemName);
		WordText(ActXWord,modelPath,SubSystemNameStyle,[0,1]);

		SaveWordFile(WordHandle,WordFileName);
		close_system(fileNameTemp);
		disp(['File written: ..\',fileNameTemp,'.rtf']);
    end
    
    %---------------------------------------------------------------------------
    %--- Create ASCIIDoc file
	%---------------------------------------------------------------------------
	if CreateASCIIDoc == true	    
        %-----------------------------------------------------------------------
		%--- Create ASCIIDOC document with content
		%-----------------------------------------------------------------------
		% disp(['Creating ASCIIDOC file in  ', path{iterFile}]);

		ASCIIDocFileName = strcat(modelNamePath,'.adoc');
        disp(ASCIIDocFileName);
        
        asciidoc_file_id=fopen(ASCIIDocFileName,'w');
        
		EHB_path = find_system(bdroot,'FindAll','On','LookUnderMasks','all','SearchDepth',1,'BlockType','SubSystem');
		subSystemName = char(get(EHB_path(1,1),'Name'));
		subSystemPath = char(get(EHB_path(1,1),'Parent'));
        
        fprintf(asciidoc_file_id, '= Function Documentation \n\n');        
        
        % Function Overview
        fprintf(asciidoc_file_id, '== Function Overview \n\n');        
        fprintf(asciidoc_file_id, 'Here you get an overview of this module:\n\n');  
        result = regexp(modelNamePath,'\','split');
		function_name = char(result(length(result)-1));        
        fprintf(asciidoc_file_id, strcat('ehbfunctionoverview::' , function_name , '[Function Overview  ',function_name,'] \n\n'));
                
        % Simulink model reference
        fprintf(asciidoc_file_id, '== Function Description \n\n');
        fprintf(asciidoc_file_id, 'The following model screenshot shows the first level subsystem of the function.\n\n');  
        %fprintf(asciidoc_file_id, strcat('ehbmodelref::' , bdroot , '[] \n\n'));
        fprintf(asciidoc_file_id, strcat('ehbmodelref::',subSystemPath,'/',subSystemName,'[',subSystemPath,'/',subSystemName,'] \n\n'));
        
        fclose(asciidoc_file_id);		
		disp(['File written: ..\',fileNameTemp,'.adoc']);        
    end
    
    disp('.');
end

CloseWord(ActXWord);
disp('Done!');


%-------------------------------------------------------------------------------
%--- Start Word
%-------------------------------------------------------------------------------
function [actx_word]=StartWord
    % Start an ActiveX session with Word:
    actx_word = actxserver('Word.Application');
    actx_word.Visible = false;
    trace(actx_word.Visible);
return
end

%-------------------------------------------------------------------------------
%--- Open Word File
%-------------------------------------------------------------------------------
function [word_handle]=OpenWordFile(actx_word, word_file_p)
    if ~exist(word_file_p,'file')
        % Create new document:
        word_handle = invoke(actx_word.Documents,'Add');
    else
        % Open existing document:
        word_handle = invoke(actx_word.Documents,'Open',word_file_p);
    end
return
end

%-------------------------------------------------------------------------------
%--- Save Word File
%-------------------------------------------------------------------------------
function SaveWordFile(word_handle_p,word_file_p)
    if ~exist(word_file_p,'file')
        % Save file as new:
        invoke(word_handle_p,'SaveAs',word_file_p,6); %6 = RTF 1 = DOCX
    else
        % Save existing file:
        invoke(word_handle_p,'Save');
    end
    % Close the word window:
    invoke(word_handle_p,'Close');
return
end

%-------------------------------------------------------------------------------
%--- Close Word File
%-------------------------------------------------------------------------------
function CloseWord(actx_word_p)
    % Quit MS Word
    invoke(actx_word_p,'Quit');
    % Close Word and terminate ActiveX:
    delete(actx_word_p);
return
end

%-------------------------------------------------------------------------------
%--- Word Text
%-------------------------------------------------------------------------------
function WordText(actx_word_p,text_p,style_p,enters_p,color_p)
	%--- VB Macro
	% Selection.TypeText Text:="Test!"
	%--- in Matlab
	% set(word.Selection,'Text','test');
	%--- this also works
	% word.Selection.TypeText('This is a test');
    if(enters_p(1))
        actx_word_p.Selection.TypeParagraph; %--- enter
    end
	actx_word_p.Selection.Style = style_p;
    if(nargin == 5) %--- check to see if color_p is defined
        actx_word_p.Selection.Font.ColorIndex=color_p;
    end

	actx_word_p.Selection.TypeText(text_p);
    actx_word_p.Selection.Font.ColorIndex='wdAuto';%set back to default color
    for k=1:enters_p(2)
        actx_word_p.Selection.TypeParagraph; %--- enter
    end
return
end

%-------------------------------------------------------------------------------
%--- SubFolder Searching
%-------------------------------------------------------------------------------
function [sub,fls] = subfolder(CurrPath,sub,fls)
	tmp = dir(CurrPath);
	tmp = tmp(~ismember({tmp.name},{'.' '..'}));
	for i = {tmp([tmp.isdir]).name}
	   sub{end+1} = [CurrPath '\' i{:}];
	   if nargin==2
		  sub = subfolder(sub{end},sub);
	   else
		  tmp = dir(sub{end});
		  fls{end+1} = {tmp(~[tmp.isdir]).name};
		  [sub fls] = subfolder(sub{end},sub,fls);
	   end
	end
end