using KeyboardMaster.MVVM.Core;
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


        private string lineOne { get; set; }
        private string lineTwo { get; set; }
        private string lineThree { get; set; }


        public MainViewModel() 
        {
            Model = new KeyboardMasterModel();
            Timer = new Stopwatch();
            ChooseScenario = new ObservableCollection<string>();
            ScenarioText = "";
            lineOne = "";
            lineTwo = "";
            lineThree = "";
            ScenarioNumber = 8;

            StartScenarioCommand = new RelayCommand(StartScenario);

        }

        public ICommand StartScenarioCommand { get; }

        public string Answer 
        {
            get => Model?.Answer; 
            set
            {
                OnPropertyChanged(nameof(Answer));
            }
        }

        public string Result
        {
            get => Model.Result;
            set
            {
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
            Timer?.Start();
            InitializeScenario();
            Task.Run(() => UpdateScenario(2));
        }

        private void InitializeScenario() 
        {
            for (int i = 1; i <= ScenarioNumber; i++)
            {
                ChooseScenario.Add(i.ToString());
            }
        }

        private void UpdateScenario(int scenario) 
        {
            switch(scenario)              
            {
                case 1:
                    Scenario = "letters j k l";
                    Model.Scenario = 1;
                    break;
                case 2:
                    Scenario = "letters a s d f";
                    Model.Scenario = 2;
                    break;
                case 3:
                    Scenario = "letters j k l i";
                    Model.Scenario = 3;
                    break;
                case 4:
                    Scenario = "letters a s d f e";
                    Model.Scenario = 4;
                    break;
                case 5:
                    Scenario = "letters j k l u i";
                    Model.Scenario = 5;
                    break;
                case 6:
                    Scenario = "letters s d f e u j k l";
                    Model.Scenario = 6;
                    break;
                case 7:
                    Scenario = "letters a s d f e r";
                    Model.Scenario = 7;
                    break;
                case 8:
                    Scenario = "letters j k l u i o";
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
