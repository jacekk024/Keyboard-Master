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

        private string ScenarioText { get; set; }


        private string lineOne { get; set; }


        public MainViewModel() 
        {
            Model = new KeyboardMasterModel();
            Timer = new Stopwatch();
            ScenarioText = "";
            lineOne = "";
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

        public double Result
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


        public void StartScenario() 
        {
            //UpdateScenario(1);
            //Scenario = "litery j k l";

             Timer?.Start();
             Task.Run(() => UpdateScenario(1));

        }

        private void UpdateScenario(int scenario) 
        {
            switch(scenario)              
            {
                case 1:
                    Scenario = "letters j k l";

                    LineOne = Model.GenerateScenario(1);

                    break;
                case 2:
                    Scenario = "letters a s d f";
                    break;
                case 3:
                    Scenario = "letters j k l i";
                    break;
                case 4:
                    Scenario = "letters a s d f e";
                    break;
                case 5:
                    Scenario = "letters j k l u i";
                    break;
                case 6:
                    Scenario = "letters s d f e u j k l";
                    break;
                case 7:
                    Scenario = "letters a s d f e r";
                    break;
                case 8:
                    Scenario = "letters j k l u i o";
                    break;

                default:
                    
                break;
            
            }       
        }




    }
}
