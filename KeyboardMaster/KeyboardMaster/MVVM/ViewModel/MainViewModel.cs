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



        public MainViewModel() 
        {
            Model = new KeyboardMasterModel();
            Timer = new Stopwatch();


        }

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


        public void StartScenario() 
        {
        
        
        }

         

    }
}
