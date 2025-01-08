This repository contains a set of demos for EHANDBOOK Container-Build. 

## Prerequisite

To run the demos, please ensure that you have the latest EHANDBOOK Container-Build tools installed. 

## Clone Repository

A guide how to setup SSH for cloning the repository can be found here https://confluence.etas-dev.com/display/ETASDEVU/SSH+Git+Access+to+Bitbucket#SSHGitAccesstoBitbucket-Createpublicandprivatekeypair .

## Setup

After cloning the respository, you first should adapt the file `set_tool_paths.bat` to your local environment. 

    set EHB_CB_PATH=C:\ETAS\EHANDBOOK-Container-Build_10.0.0-Windows
    set EHB_UGG_PATH=C:\ETAS\EHANDBOOK-UGG_10.0.0-Windows
    set MATLAB_PATH=C:\Program Files\MATLAB\R2021a

## How to run a demo

Each demo folder contains a batch file `build.bat` which invokes the EHANDBOOK Container-Build tool(s) on the given input data.
The build then generates an EHANDBOOK Container file and - where configured - a corresponding PDF output. 


# AI-generated code notice

Use of generative AI in this repository:

The repository partially contains AI-generated code by using GitHub Copilot Business.

This notice needs to remain attached to any reproduction of this repository.