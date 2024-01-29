using System;
using Microsoft.VisualBasic;
class PromptGenerator{
    List<string> _prompts = new List<string>{};
    string _randomPrompt;
    string _typePrompt;
    public PromptGenerator(string typeOfPrompt){
        _typePrompt = typeOfPrompt;
    }
    public string GetPrompt(){
        string[] lines = new string[]{};
        switch (_typePrompt)
        {
            case "1":
                lines = System.IO.File.ReadAllLines("reflectiveprompts.txt");
                break;
            case "2":
                lines = System.IO.File.ReadAllLines("mindestprompts.txt");
                break;
            case "3":
                lines = System.IO.File.ReadAllLines("gratitudeprompts.txt");
                break;
            case "4":
                lines = System.IO.File.ReadAllLines("goalprompts.txt");
                break;
            case "5":
                lines = System.IO.File.ReadAllLines("funprompts.txt");
                break;
            case "6":
                lines = System.IO.File.ReadAllLines("morningprompts.txt");
                break;
            case "7":
                lines = System.IO.File.ReadAllLines("eveningprompts.txt");
                break;
        }
        foreach (string line in lines){
            _prompts.Add(line);
        }
        var random = new Random();

        int randomIndex = random.Next(_prompts.Count);
        _randomPrompt = _prompts[randomIndex];

    return _randomPrompt;
    }
}