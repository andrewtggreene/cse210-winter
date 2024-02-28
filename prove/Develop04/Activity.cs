using System.Runtime.CompilerServices;

class Activity{
    protected string _name = "";
    protected string _description = "";
    protected string _endMessage = "";
    protected int _duration;
    public Activity(){
        _endMessage = "Well done!";
        _description = "This is an activity!";
        _name = "Activity";
    }
    public Activity(int duration){
        _duration = duration;
        _endMessage = "Well done!!";
    }
    public Activity(int duration, string description, string endMessage, string name){
        _duration = duration;
        _name = name;
        _endMessage = endMessage;
        _description = description;
    }
    public string GetStartingMessage(){
        string welcomeString = $"Welcome to the {_name}.\n\n{_description}\nHow long, in seconds, would you like for your session? ";
        return welcomeString;
    }
    protected void SpinnerPause(int number){
        List<string> spins = new List<string>{"/","|","\\","-"};
        for (int i = number; i >= 0; i--){
            foreach (string spin in spins){
                Console.Write(spin);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
    protected void CountdownPause(int number){
        for (int i=number; i>=0;i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }
    }
    protected string GetEndingMessage(){
        Thread.Sleep(1000);
        return _endMessage;
    }
    public void SetDuration(int duration){
        _duration = duration;
    }
}