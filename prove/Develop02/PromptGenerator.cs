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
                Console.WriteLine("Reflective");
                lines = System.IO.File.ReadAllLines("reflectiveprompts.txt");
                break;
            case "2":
                Console.WriteLine("Mindset");
                lines = System.IO.File.ReadAllLines("mindsetprompts.txt");
                break;
            case "3":
                Console.WriteLine("Grattitude");
                lines = System.IO.File.ReadAllLines("gratitudeprompts.txt");
                break;
            case "4":
                Console.WriteLine("Goals");
                lines = System.IO.File.ReadAllLines("goalprompts.txt");
                break;
            case "5":
                Console.WriteLine("Fun");
                lines = System.IO.File.ReadAllLines("funprompts.txt");
                break;
            case "6":
                Console.WriteLine("Morning");
                lines = System.IO.File.ReadAllLines("morningprompts.txt");
                break;
            case "7":
                Console.WriteLine("Evening");
                lines = System.IO.File.ReadAllLines("eveningprompts");
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