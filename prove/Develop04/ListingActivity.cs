class ListingActivty: Activity{
    private List<string> _listOfPrompts = new List<string>{};
    private int _numOfList = 0;
    public ListingActivty(int duration):base(duration){
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _listOfPrompts.Add("Who are people that you appreciate?");
        _listOfPrompts.Add("What are personal strengths of yours?");
        _listOfPrompts.Add("Who are people that you have helped this week?");
        _listOfPrompts.Add("When have you felt the Holy Ghost this month?");
        _listOfPrompts.Add("Who are some of your personal heroes?");
    }
    public ListingActivty(){
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _listOfPrompts.Add("Who are people that you appreciate?");
        _listOfPrompts.Add("What are personal strengths of yours?");
        _listOfPrompts.Add("Who are people that you have helped this week?");
        _listOfPrompts.Add("When have you felt the Holy Ghost this month?");
        _listOfPrompts.Add("Who are some of your personal heroes?");
    }
    private string GetRandomPrompt(){
        Random rnd = new Random();
        int r = rnd.Next(_listOfPrompts.Count);
        return _listOfPrompts[r];
    }
    private void DisplayPrompt(){
        Console.WriteLine("List as many responses you can to the following prompt.");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }
    private void GetAnswers(){
        Console.Write("> ");
        Console.ReadLine();
        _numOfList += 1;
    }
    public void RunListingActivity(){
        Console.Write("Get ready...");
        CountdownPause(5);
        Console.WriteLine("\n");
        DisplayPrompt();
        Console.Write("You may begin in: ");
        CountdownPause(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        do {
            GetAnswers();
            currentTime = DateTime.Now;
        }
        while (currentTime < futureTime);
        Console.WriteLine($"You listed {_numOfList} items!");
        Console.WriteLine(GetEndingMessage());
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");        
        SpinnerPause(3);
        Console.Clear();
    }
}