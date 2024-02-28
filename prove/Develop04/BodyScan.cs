class BodyScan: Activity{
    List<string> _listOfBodyParts = new List<string>{};
    public BodyScan(){
        _name = "Body Scan Activity";
        _description = "This will help you relax by walking you through a body scan exercise, allowing you to become more attune to your body. This exercise works best with several minutes to spend on the activity. The minimum time is set to 85 seconds.";
        _listOfBodyParts.Add("Feet");
        _listOfBodyParts.Add("Ankles");
        _listOfBodyParts.Add("Calves");
        _listOfBodyParts.Add("Knees");
        _listOfBodyParts.Add("Thighs");
        _listOfBodyParts.Add("Abdomen");
        _listOfBodyParts.Add("Lower Back");
        _listOfBodyParts.Add("Chest");
        _listOfBodyParts.Add("Fingers");
        _listOfBodyParts.Add("Palms");
        _listOfBodyParts.Add("Forearms");
        _listOfBodyParts.Add("Elbows");
        _listOfBodyParts.Add("Upper Arm");
        _listOfBodyParts.Add("Shoulders");
        _listOfBodyParts.Add("Neck");
        _listOfBodyParts.Add("Face");
        _listOfBodyParts.Add("Top of your head");
    }
    public BodyScan(int duration): base(duration){
        _name = "Body Scan Activity";
        _description = "This will help you relax by walking you through a body scan exercise, allowing you to become more attune to your body.";
        _listOfBodyParts.Add("Feet");
        _listOfBodyParts.Add("Ankles");
        _listOfBodyParts.Add("Calves");
        _listOfBodyParts.Add("Knees");
        _listOfBodyParts.Add("Thighs");
        _listOfBodyParts.Add("Abdomen");
        _listOfBodyParts.Add("Lower Back");
        _listOfBodyParts.Add("Chest");
        _listOfBodyParts.Add("Fingers");
        _listOfBodyParts.Add("Palms");
        _listOfBodyParts.Add("Forearms");
        _listOfBodyParts.Add("Elbows");
        _listOfBodyParts.Add("Upper Arm");
        _listOfBodyParts.Add("Shoulders");
        _listOfBodyParts.Add("Neck");
        _listOfBodyParts.Add("Face");
        _listOfBodyParts.Add("Top of your head");
    }
    private void DisplayCountdown(){
        Console.WriteLine("Get ready...");
        SpinnerPause(3);
    }
    public void RunBodyScanActivity(){
        int lenOfPart = _duration / _listOfBodyParts.Count;
        Console.WriteLine("We will begin this activity by focusing on one individual body part at a time. Think about the different sensations each body part feels. Do not judge these sensations but simply notice them.");
        DisplayCountdown();
        Console.Clear();
        foreach (string x in _listOfBodyParts){
            Console.WriteLine($"Move your focus to your {x}. Notice the sensations. If you notice any sensations, don't judge them, simply notice them.");
            CountdownPause(lenOfPart);
            Console.WriteLine("\n");
        }
        Console.WriteLine(GetEndingMessage());
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        SpinnerPause(3);
        Console.Clear();        
    }    
}