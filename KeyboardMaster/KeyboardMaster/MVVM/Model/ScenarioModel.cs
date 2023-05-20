using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardMaster.MVVM.Model
{
    class ScenarioModel
    {
        public IEnumerable<string>? ScenarioText { get; set; }
        public int Scenario { get; set; }
        public Stopwatch? StopWatch { get; set; }

        public void GenerateRandomScenario() 
        {
            // w zależnosci od scenariusza losujemy 40 znakow na linie + 9 spacji pomiedzy 4 znakami
        
            
        
        }
    }
}
