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
    public string Result { get; set; }
    public int Score { get; set; }
    public string Answer { get; set; }  
    public KeyboardMasterModel()
    {
        ScenarioText = new List<string>();
        Scenario = 1;
        Result = "";
    }


    public string GenerateScenario(int scenario)
    {
        Random rnd = new();
        StringBuilder sb = new();

        string chars = "";

        switch (scenario)
        {
            case 1:
                chars = "jkl";
            break;
            case 2:
                chars = "asdf";
            break;
            case 3:
                chars = "letters j k l i";
                break;
            case 4:
                chars = "letters a s d f e";
                break;
            case 5:
                chars = "letters j k l u i";
                break;
            case 6:
                chars = "letters s d f e u j k l";
                break;
            case 7:
                chars = "letters a s d f e r";
                break;
            case 8:
                chars = "letters j k l u i o";
                break;

            default:
                return "";

        }

        for(int i = 0; i < 10; i++) 
        {
            sb.Append(new string(Enumerable.Repeat(chars, 4)
            .Select(s => s[rnd.Next(s.Length)]).ToArray()) + " ");
            
        }   
        return sb.ToString();
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
