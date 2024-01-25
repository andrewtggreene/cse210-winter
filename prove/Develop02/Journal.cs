using System.ComponentModel.DataAnnotations;
using System.IO;

class Journal{
    List<Entry> Entries = new List<Entry>();
    public Journal(){

    }
    public void DisplayEntries(){
        foreach (Entry entry in Entries){
            Console.WriteLine(entry.date);
            Console.Write(entry.prompt);
            Console.WriteLine(entry.userEntry);
        }
    }
    public void LoadEntries(string FileName){
        string[] lines = System.IO.File.ReadAllLines(FileName);

        foreach (string line in lines) {
            string[] parts = line.Split(";");

            string date = parts[0];
            string prompt = parts[1];
            string userEntry = parts[2];
            Entry loadedEntry = new Entry(date, prompt, userEntry);
            Entries.Add(loadedEntry);
            }
    }
    public void SaveEntries(string FileName){
        using (StreamWriter outputFile = new StreamWriter(FileName)){
            foreach (Entry entry in Entries) {
                string entryString = $"{entry.date}; {entry.prompt}; {entry.userEntry}";
                outputFile.WriteLine(entryString);
            }
        }
    }
    public void AddEntry(){
        PromptGenerator newPromptGenerator = new PromptGenerator();
        string newPrompt = newPromptGenerator.getPrompt();
        Console.WriteLine(newPrompt);
        Console.Write("> ");
        string userEntry = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Entry newEntry = new Entry(dateText, newPrompt, userEntry);
        Entries.Add(newEntry);
    }
}