class BreathingActivity : Activity{
    public BreathingActivity(int duration):base(duration){
        _name = "Breathing Activity";
        _description = "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public BreathingActivity(){
        _name = "Breathing Activity";
        _description = "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    private void DisplayCountdown(){
        Console.WriteLine("Get ready...");
        SpinnerPause(3);
    }
    private void BreatheIn(){
        Console.Write("Breathe in...");
        CountdownPause(4);
    }
    private void BreatheOut(){
        Console.Write("Now breathe out...");
        CountdownPause(8);
    }
    public void RunBreathingActivity(){
        int numOfBreaths = _duration / 12;
        DisplayCountdown();
        for (int i = numOfBreaths; i > 0; i--){
            Console.WriteLine("");
            BreatheIn();
            Console.WriteLine("");
            BreatheOut();
            Console.WriteLine("");
        }
        Console.WriteLine(GetEndingMessage());
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        SpinnerPause(3);
        Console.Clear();
    }
}