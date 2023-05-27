using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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


    public string GenerateScenario(int scenario)
    {
        Random rnd;
        switch (scenario)
        {
            case 1:
                const string chars = "jkl";

                rnd = new Random();
                StringBuilder sb = new();
                
                for()

                return new string(Enumerable.Repeat(chars, 4)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());

            case 2:
                const string chars = "asdf";
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
                return "";

        }

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
