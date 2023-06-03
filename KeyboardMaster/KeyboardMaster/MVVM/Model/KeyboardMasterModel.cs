using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardMaster.MVVM.Model;

class KeyboardMasterModel
{
    StringBuilder? ScenarioText { get; set; }
    public int Scenario { get; set; }
    public string Result { get; set; }
    public Stopwatch Timer { get; set; }
    public  int Score { get; set; }
    public string AnswerOne { get; set; }
    public string AnswerTwo { get; set; }
    public string AnswerThree { get; set; }

    public string LineOne { get; set; }
    public string LineTwo { get; set; }
    public string LineThree { get; set; }


    public KeyboardMasterModel()
    {
        ScenarioText = new StringBuilder();
        Timer = new Stopwatch();
        Scenario = 1;
        AnswerOne = "";
        AnswerTwo = "";
        AnswerThree = "";

        LineOne = "";
        LineTwo = "";
        LineThree = "";

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
                chars = "jkli";
                break;
            case 4:
                chars = "asdfe";
                break;
            case 5:
                chars = "jklui";
                break;
            case 6:
                chars = "sdfeujkl";
                break;
            case 7:
                chars = "asdfer";
                break;
            case 8:
                chars = "jkluio";
                break;
            default:
                return "";
        }

        for(int i = 0; i < 10; i++) 
        {
            sb.Append(new string(Enumerable.Repeat(chars, 4)
            .Select(s => s[rnd.Next(s.Length)]).ToArray()) + " ");       
        }

        ScenarioText?.Append(sb.ToString());

        return sb.ToString();
    }
}
