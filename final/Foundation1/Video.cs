class Video{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _listOfComments = new List<Comment>{};
    public Video(string title, string author, double length){
        _title = title;
        _author = author;
        _length = length;
    }
    public void DisplayBaseInfo(){
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Runtime: {_length} seconds");
        Console.WriteLine("Comments:");
        ListComments();
    }
    public void AddComment(Comment comment){
        _listOfComments.Add(comment);
    }
    private void ListComments(){
        foreach(Comment comment in _listOfComments){
            comment.DisplayComment();
        }
    }
}