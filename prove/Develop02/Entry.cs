class Entry{
    public string prompt;
    public string userEntry;
    public string date;

    public Entry( string dateOfEntry, string GeneratedPrompt, string response){
        date = dateOfEntry;
        prompt = GeneratedPrompt;
        userEntry = response;
    }

}