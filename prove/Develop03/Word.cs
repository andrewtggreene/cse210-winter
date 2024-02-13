class Word{
    private string _word;

    private bool _isHidden;
    public Word(string word){
        _word = word;
        _isHidden = false;
    }
    public Word(string word, bool isHidden){
        _word = word;
        _isHidden = isHidden;
    }
    public void Hide(){
        string newString = "";

        for (int i=0;i < _word.Length; i++){
            switch (_word.Substring(i,1))
            {
                case ",":
                    newString += ",";
                    break;
                case ".":
                    newString += ".";
                    break;
                case ";":
                    newString += ";";
                    break;
                case "?":
                    newString += "?";
                    break;
                case "!":
                    newString += "!";
                    break;
                case ":":
                    newString += ":";
                    break;
                case "(":
                    newString += "(";
                    break;
                case ")":
                    newString += ")";
                    break;
                default:
                    newString += "_";
                    break;
            }
        }
        _word = newString;
        _isHidden = true;
    }
    public string Show(){
        return _word;
    }
    public string GetRenderedText(){
        string renderedString = _word + " ";
        return renderedString;
    }
    public bool GetIsHidden(){
        return _isHidden;
    }
}