using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardMaster.MVVM.Model
{
    class KeyboardMasterModel
    {
        public List<string>? ScenarioText { get; set; }
        public int Scenario { get; set; }
        public Stopwatch? StopWatch { get; set; }
        public double Result { get; set; }

        public KeyboardMasterModel(int scenarrio)
        {
            ScenarioText = new List<string>();
            StopWatch = new Stopwatch();
            Scenario = scenarrio;
        }
        public List<int> GenerateRandomScenario()
        {
            // w zależnosci od scenariusza losujemy 40 znakow na linie + 9 spacji pomiedzy 4 znakami

            Random random = new Random();

            switch (Scenario)
            {
                case 1:

                    break;
                case 2:

                    break;

                case 3:
                    break;
                case 4:
                    break;

                default:
                    break;




            }




        }


    }
}
