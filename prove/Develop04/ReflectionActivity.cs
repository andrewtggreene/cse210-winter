class ReflectionActivity : Activity{
    private List<string> _listOfPrompts = new List<string>{};
    private List<string> _listOfQuestions = new List<string>{};
    public ReflectionActivity(int duration): base(duration){
        _name = "Breathing Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _listOfPrompts.Add("Think of a time when you stood up for someone else.");
        _listOfPrompts.Add("Think of a time when you did something really difficult.");
        _listOfPrompts.Add("Think of a time when you helped someone in need.");
        _listOfPrompts.Add("Think of a time when you did something truly selfless.");
        _listOfQuestions.Add("Why was this experience meaningful to you?");
        _listOfQuestions.Add("Have you ever done anything like this before?");
        _listOfQuestions.Add("How did you get started?");
        _listOfQuestions.Add("How did you feel when it was complete?");
        _listOfQuestions.Add("What made this time different than other times when you were not successful?");
        _listOfQuestions.Add("What is your favorite thing about this experience?");
        _listOfQuestions.Add("What could you learn from this experience that applies to other situations?");
        _listOfQuestions.Add("What did you learn about yourself through this experience?");
        _listOfQuestions.Add("How can you keep this experience in mind in the future?");
    }
    public ReflectionActivity(){
        _name = "Breathing Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _listOfPrompts.Add("Think of a time when you stood up for someone else.");
        _listOfPrompts.Add("Think of a time when you did something really difficult.");
        _listOfPrompts.Add("Think of a time when you helped someone in need.");
        _listOfPrompts.Add("Think of a time when you did something truly selfless.");
        _listOfQuestions.Add("Why was this experience meaningful to you?");
        _listOfQuestions.Add("Have you ever done anything like this before?");
        _listOfQuestions.Add("How did you get started?");
        _listOfQuestions.Add("How did you feel when it was complete?");
        _listOfQuestions.Add("What made this time different than other times when you were not successful?");
        _listOfQuestions.Add("What is your favorite thing about this experience?");
        _listOfQuestions.Add("What could you learn from this experience that applies to other situations?");
        _listOfQuestions.Add("What did you learn about yourself through this experience?");
        _listOfQuestions.Add("How can you keep this experience in mind in the future?");
    }
    private string GetRandomPrompt(){
        Random rnd = new Random();
        int r = rnd.Next(_listOfPrompts.Count);
        return _listOfPrompts[r];
    }
    private string GetRandomQuestion(){
        Random rnd = new Random();
        int r = rnd.Next(_listOfQuestions.Count);
        return _listOfQuestions[r];
    }
    private void DisplayPrompt(){
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
    }
    private void DisplayQuestion(){
        Console.Write($"> {GetRandomQuestion()} ");
    }
    public void RunReflectionActivity(){
        DisplayPrompt();
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        CountdownPause(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        do {
            DisplayQuestion();
            currentTime = DateTime.Now;
            SpinnerPause(5);
            Console.WriteLine();
        }
        while (currentTime < futureTime);
        Console.WriteLine(GetEndingMessage());
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        SpinnerPause(3);
        Console.Clear();
    }
}