﻿using KeyboardMaster.MVVM.Core;
using KeyboardMaster.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KeyboardMaster.MVVM.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        private KeyboardMasterModel? Model { get; set; }
        private Stopwatch? Timer { get; set; }
        public ObservableCollection<string> ChooseScenario { get; set; }
        private int ScenarioNumber { get; set; }
        private string ScenarioText { get; set; }
        private string scenarioDesc { get;set; }
        private string lineOne { get; set; }
        private string lineTwo { get; set; }
        private string lineThree { get; set; }

        public MainViewModel() 
        {
            Model = new KeyboardMasterModel();
            Timer = new Stopwatch();
            ScenarioText = "";
            lineOne = "";
            lineTwo = "";
            lineThree = "";
            scenarioDesc = "";
            ScenarioNumber = 8;
            StartScenarioCommand = new RelayCommand(StartScenario);
            CheckResultCommand = new RelayCommand(CheckResult); 
            InitializeScenario();
        }

        public ICommand StartScenarioCommand { get; }
        public ICommand CheckResultCommand { get; }

        public string AnswerOne
        {
            get => Model.AnswerOne; 
            set
            {
                Model.AnswerOne = value;
                OnPropertyChanged(nameof(AnswerOne));
            }
        }

        public string AnswerTwo
        {
            get => Model.AnswerTwo;
            set
            {
                Model.AnswerTwo = value;
                OnPropertyChanged(nameof(AnswerTwo));
            }
        }

        public string AnswerThree
        {
            get => Model.AnswerThree;
            set
            {
                Model.AnswerThree = value;  
                OnPropertyChanged(nameof(AnswerThree));
            }
        }

        public string Result
        {
            get => Model.Result;
            set
            {
                Model.Result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public string Scenario
        {
            get => ScenarioText; 
            set
            {
                ScenarioText = value;
                OnPropertyChanged(nameof(Scenario));
            }
        }
        public string ScenarioDescription
        {
            get => scenarioDesc;
            set
            {
                scenarioDesc = value;
                OnPropertyChanged(nameof(ScenarioDescription));
            }
        }

        public string LineOne
        {
            get => lineOne;
            set
            {
                lineOne = value;
                OnPropertyChanged(nameof(LineOne));
            }
        }

        public string LineTwo
        {
            get => lineTwo;
            set
            {
                lineTwo = value;
                OnPropertyChanged(nameof(LineTwo));
            }
        }

        public string LineThree
        {
            get => lineThree;
            set
            {
                lineThree = value;
                OnPropertyChanged(nameof(LineThree));
            }
        }
        public void StartScenario() 
        {
            Result = "";
            Model.Timer.Start();
            Task.Run(() => UpdateScenario());
        } 

        private void CheckResult() 
        {
            Model.Timer.Stop();
            int time = (int)Model.Timer.ElapsedMilliseconds / 1000;
            Result = "Time youe complete the task: " + time.ToString() + "sec";
        }

        private void InitializeScenario() 
        {
            ChooseScenario = new ObservableCollection<string>();
            for (int i = 1; i <= ScenarioNumber; i++)
            {
                ChooseScenario.Add(i.ToString());
            }
        }
        private void UpdateScenario() 
        {
            int scenario = int.Parse(Scenario);
            switch(scenario)              
            {
                case 1:
                    ScenarioDescription = "letters j k l";
                    Model.Scenario = 1;
                    break;
                case 2:
                    ScenarioDescription = "letters a s d f";
                    Model.Scenario = 2;
                    break;
                case 3:
                    ScenarioDescription = "letters j k l i";
                    Model.Scenario = 3;
                    break;
                case 4:
                    ScenarioDescription = "letters a s d f e";
                    Model.Scenario = 4;
                    break;
                case 5:
                    ScenarioDescription = "letters j k l u i";
                    Model.Scenario = 5;
                    break;
                case 6:
                    ScenarioDescription = "letters s d f e u j k l";
                    Model.Scenario = 6;
                    break;
                case 7:
                    ScenarioDescription = "letters a s d f e r";
                    Model.Scenario = 7;
                    break;
                case 8:
                    ScenarioDescription = "letters j k l u i o";
                    Model.Scenario = 8;
                    break;
                default:
                    
                break;
            }
            LineOne = Model.GenerateScenario(scenario);
            LineTwo = Model.GenerateScenario(scenario);
            LineThree = Model.GenerateScenario(scenario);
        }
    }
}
