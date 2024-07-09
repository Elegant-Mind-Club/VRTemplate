%% cleans up workspace and closes any open graphs
clear;
close all;

%% Important Variables
%{
    This section should have everything you'd normally need to edit.
%}

%rtDataFile = 'C:\Users\elega\Documents\GitHub\VRMovementTracking\Assets\Data\MingTest2-rtData-2024-06-06-11-15-17.csv';
eyeTrackingDataFile ='C:\Users\elega\Documents\GitHub\Eyetracking test\Assets\Logs\eyeTr-2024-07-09-15-07-33.csv';
eyeTrackingData = readtable(eyeTrackingDataFile, 'Delimiter', ';');

xecc=eyeTrackingData.CalcXEccentricity;




