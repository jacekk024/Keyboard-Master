# Keyboard-Master

## Table of Contents
* [Project Description](#general-info)
* [Tools](#tools)
* [Technologies](#technologies)
* [Implementation Details](#implementation-details)
* [Useful Resources](#useful-resources)
* [Results](#results)

## Project Description
    Keyboard Master is a desktop application designed to help users improve their typing speed and accuracy.
    It provides a user-friendly interface where users can practice typing
    various exercises and track their progress over time.
    The application is built using C# and WPF,
    providing a rich and interactive experience.
## Tools
* Visual Studio 
## Technologies
* WPF
* .NET Core
* C#
* MVVM

## Implementation Details
    Keyboard Master follows the MVVM (Model-View-ViewModel) architectural pattern to separate concerns and promote maintainability and testability. Here's a breakdown of the project structure:

    Models: This layer represents the data model and encapsulates the business logic.
    It includes classes such as Exercise, User, and PerformanceData for storing and manipulating data.

    Views: This layer handles the visual representation of the application. It includes XAML files that define the UI components, layouts, and styles. Views are responsible for binding to the ViewModel layer.

    ViewModels: This layer acts as the intermediary between the Models and Views. It contains classes that expose properties and commands to the Views, handle user interactions, and update the Models accordingly. It also implements data bindings to facilitate communication between the Views and Models. 
## Results

### Program Start 
<img src="https://github.com/jacekk024/Keyboard-Master/assets/45696277/fd0a0370-a5d2-4f2d-9b0b-f668657bee4f" alt="Start"/>

### Test Result
<img src="https://github.com/jacekk024/Keyboard-Master/assets/45696277/ed0f695b-965e-4bd5-bbca-46e815952fd1" alt="Test" />

