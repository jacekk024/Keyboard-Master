using KeyboardMaster.MVVM.Core;
using KeyboardMaster.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KeyboardMaster.MVVM.ViewModel
{
    class MainViewModel : BaseViewModel
    {

        private KeyboardMasterModel? Model { get; set; }
        private Stopwatch? Timer { get; set; }

        private string ScenarioText { get; set; }


        public MainViewModel() 
        {
            Model = new KeyboardMasterModel();
            Timer = new Stopwatch();

            StartScenarioCommand = new RelayCommand(StartScenario);

        }

        public ICommand StartScenarioCommand;

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
                OnPropertyChanged(nameof(Scenario));
            }
        }


        public void StartScenario() 
        {
            //Timer?.Start();
            Task.Run(() => UpdateScenario(Model.Scenario));
            
        }

        private void UpdateScenario(int scenario) 
        {
            switch(scenario)              
            {
                case 1:
                    ScenarioText = "litery j k l";
                break;

                default:
                    
                break;
            
            }       
        }      
    }
}
