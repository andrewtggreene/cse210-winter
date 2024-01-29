using System.ComponentModel.DataAnnotations;
using System.IO;

class Journal{
    List<Entry> _entries = new List<Entry>();
    public Journal(){
        
    }
    public void DisplayEntries(){
        foreach (Entry entry in _entries){
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
            Console.WriteLine(entry._userEntry);
        }
    }
    public void LoadEntries(string _fileName){
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines) {
            string[] parts = line.Split(";");

            string date = parts[0];
            string prompt = parts[1];
            string userEntry = parts[2];
            Entry loadedEntry = new Entry(date, prompt, userEntry);
            _entries.Add(loadedEntry);
            }
        Console.WriteLine($"{_fileName} was successfully loaded!");
    }
    public void SaveEntries(string _fileName){
        using (StreamWriter outputFile = new StreamWriter(_fileName)){
            foreach (Entry entry in _entries) {
                string entryString = $"{entry._date}; {entry._prompt}; {entry._userEntry}";
                outputFile.WriteLine(entryString);
            }
        }
        Console.WriteLine($"Journal was successfully saved to {_fileName}.");
    }
    public void AddEntry(string promptType){
        PromptGenerator newPromptGenerator = new PromptGenerator(promptType);
        string newPrompt = newPromptGenerator.GetPrompt();
        Console.WriteLine(newPrompt);
        Console.Write("> ");
        string userEntry = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Entry newEntry = new Entry(dateText, newPrompt, userEntry);
        _entries.Add(newEntry);
    }
}