class Comment{
    private string _comment;
    private string _commentor;
    public Comment(string comment, string commentor){
        _comment = comment;
        _commentor = commentor;
    }
    public void DisplayComment(){
        Console.WriteLine($"\t{_commentor} said \"{_comment}\"");
    }
}