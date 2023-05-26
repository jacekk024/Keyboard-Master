using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace KeyboardMaster.MVVM.Model;

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


    public async void GenerateScenario()
    {


    }

    private string GenerateRandomLetters()
    {

        return "";
    }

    public bool CheckAnswer(string answer)
    {

        return true;
    }

    public int GetScore()
    {
        return 1;
    }

    public void ResetScore()
    {
      
    }

}
