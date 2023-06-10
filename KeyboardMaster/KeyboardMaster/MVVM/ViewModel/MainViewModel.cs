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
        public ObservableCollection<string> ChooseScenario { get; set; }
        private string ScenarioText { get; set; }
        private string ScenarioDesc { get;set; }

        public MainViewModel() 
        {
            Model = new KeyboardMasterModel();
            ScenarioText = "";
            ScenarioDesc = "";
            StartScenarioCommand = new RelayCommand(StartScenario);
            CheckResultCommand = new RelayCommand(CheckResult); 
            InitializeScenario(11);
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
            get => ScenarioDesc;
            set
            {
                ScenarioDesc = value;
                OnPropertyChanged(nameof(ScenarioDescription));
            }
        }

        public string LineOne
        {
            get => Model.LineOne;
            set
            {
                Model.LineOne = value;
                OnPropertyChanged(nameof(LineOne));
            }
        }

        public string LineTwo
        {
            get => Model.LineTwo;
            set
            {
                Model.LineTwo = value;
                OnPropertyChanged(nameof(LineTwo));
            }
        }

        public string LineThree
        {
            get => Model.LineThree;
            set
            {
                Model.LineThree = value;
                OnPropertyChanged(nameof(LineThree));
            }
        }
        public void StartScenario() 
        {
            Result = "";
            if (Model != null)
            {
                Model.Score = 0;
                Model.Timer.Start();
            }
            Task.Run(() => UpdateScenario());
        } 

        private async void CheckResult() 
        {
            Result = "";
            if (Model != null)
            {
                Model.Score = 0;
                Model.Timer.Stop();

                int time = (int)Model.Timer.ElapsedMilliseconds / 1000;

                await Task.Run(() => Model.CheckCorrectAnswers());
                Result = "Score: " + Model.Score.ToString() + "%" + " Time: " + time.ToString() + "sec";
            }
        }

        private void InitializeScenario(int scenarios) 
        {
            ChooseScenario = new ObservableCollection<string>();
            for (int i = 1; i <= scenarios; i++)
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
                    break;
                case 2:
                    ScenarioDescription = "letters a s d f";
                    break;
                case 3:
                    ScenarioDescription = "letters j k l i";
                    break;
                case 4:
                    ScenarioDescription = "letters a s d f e";
                    break;
                case 5:
                    ScenarioDescription = "letters j k l u i";
                    break;
                case 6:
                    ScenarioDescription = "letters s d f e u j k l";
                    break;
                case 7:
                    ScenarioDescription = "letters a s d f e r";
                    break;
                case 8:
                    ScenarioDescription = "letters j k l u i o";
                    break;
                case 9:
                    ScenarioDescription = "letters a s d f r e w";
                    break;
                case 10:
                    ScenarioDescription = "letters j k l u i o";
                    break;
                case 11:
                    ScenarioDescription = "letters a s d f g w e r";
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
