class Reference{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private bool _isSingleVerse;
    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _isSingleVerse = true;
    }
    public Reference(string book, int chapter, int verse, int endverse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endverse;
        _isSingleVerse = false;
    }    
    public string GetRenderedText(){
        string renderedString;
        if (_isSingleVerse){
            renderedString = $"{_book} {_chapter}:{_verse} ";
        } else {
            renderedString = $"{_book} {_chapter}:{_verse}-{_endVerse} ";
        }
        return renderedString;
    }
}