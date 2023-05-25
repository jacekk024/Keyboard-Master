using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace KeyboardMaster.MVVM.Model
{
    class KeyboardMasterModel
    {
        public List<string>? ScenarioText { get; set; }
        public int Scenario { get; set; }
        public double Result = 0;
        public int Score { get; set; }

        public string Answer { get; set; }  
        public KeyboardMasterModel()
        {
            ScenarioText = new List<string>();
            Scenario = 1;
        }


        public void GenerateScenario()
        {
            // Generate a new scenario with random letters
            currentScenario = GenerateRandomLetters();
        }

        private string GenerateRandomLetters()
        {
            // Generate and return a random sequence of letters for the scenario
            // Implement your logic here to generate the letters
        }

        public bool CheckAnswer(string answer)
        {
            // Compare the answer with the current scenario
            // and update the score accordingly
            // Implement your logic here to check the answer
        }

        public int GetScore()
        {
            return score;
        }

        public void ResetScore()
        {
            score = 0;
        }
    }
}
