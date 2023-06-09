# Keyboard-Master
https://github.com/jacekk024/Keyboard-Master/assets/45696277/85872311-5dc0-4a20-b317-3afea41b5e2c
## Table of Contents
* [Project Description](#general-info)
* [Tools](#tools)
* [Technologies](#technologies)
* [Implementation Details](#implementation-details)
* [Useful Resources](#useful-resources)
* [Results](#results)

## Project Description
    Keyboard Master is a desktop application designed to help users improve their typing speed and accuracy.
    It provides a user-friendly interface where users can practice typing various exercises and track
    their progress over time. The application is built using C# and WPF, 
    providing a rich and interactive experience.
## Tools
* Visual Studio 
## Technologies
* WPF
* .NET Core
* C#
* MVVM

## Implementation Details
Keyboard Master follows the MVVM (Model-View-ViewModel) architectural
pattern to separate concerns and promote maintainability and testability.
Here's a breakdown of the project structure:

    Models: KeyboardMasterModel store information about score, time of test pass,
    scenario, answers. Generate random scenario and check result of test

    Views: MainWindow store basic view of app.

    
    ViewModels: MainViewModel Binds Model an View together. 
    MainViewModel inherits after BaseViewModel which
    implements INotifyPropertyChanged interface
 

## Results
### Program Start 
<img src="https://github.com/jacekk024/Keyboard-Master/assets/45696277/fd0a0370-a5d2-4f2d-9b0b-f668657bee4f" alt="Start"/>

### Test Result
<img src="https://github.com/jacekk024/Keyboard-Master/assets/45696277/ed0f695b-965e-4bd5-bbca-46e815952fd1" alt="Test" />

