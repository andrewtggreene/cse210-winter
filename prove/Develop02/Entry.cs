class Entry{
    public string _prompt;
    public string _userEntry;
    public string _date;

    public Entry( string dateOfEntry, string GeneratedPrompt, string response){
        _date = dateOfEntry;
        _prompt = GeneratedPrompt;
        _userEntry = response;
    }
}