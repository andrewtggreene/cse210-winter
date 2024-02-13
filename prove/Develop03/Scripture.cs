using System.Globalization;

class Scripture{
    private Reference _reference;
    private List<Word> _listOfWords = new List<Word>();
    public Scripture(Reference reference, string verse){
        _reference = reference;
        string[] splitVerse = verse.Split(' ');
        foreach (string word in splitVerse){
            Word word1 = new Word(word);
            _listOfWords.Add(word1);
        }
    }
    public void HideWords(){
        int numberOfHiddenWords = 0;
        Random rnd = new Random();
        do {
        int r = rnd.Next(_listOfWords.Count);
        if (_listOfWords[r].GetIsHidden() == false){
            numberOfHiddenWords += 1;    
        }
        _listOfWords[r].Hide();
        } while (IsCompletelyHidden() == false && numberOfHiddenWords < 4);

    }
    public string GetRenderedText(){
        string renderedString = "";
        renderedString +=  _reference.GetRenderedText();
        foreach (Word word in _listOfWords){
            renderedString += word.GetRenderedText();
        }
        return renderedString;
    }
    public bool IsCompletelyHidden(){
        foreach (Word word in _listOfWords){
            if (word.GetIsHidden()==false){
                return false;
            }
        }
        return true;
    }
}