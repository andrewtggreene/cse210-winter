using System.Runtime.CompilerServices;

class Activity{
    protected string _name = "";
    protected string _description = "";
    protected string _endMessage = "";
    protected int _duration;
    public Activity(int duration){
        _duration = duration;
        _endMessage = "The Standard End Message.";
    }
    public Activity(int duration, string description, string endMessage, string name){
        _duration = duration;
        _name = name;
        _endMessage = endMessage;
        _description = description;
    }
    protected string GetStartingMessage(){
        return _description;
    }
    protected void SpinnerPause(){

    }
    protected void CountdownPause(){

    }
    protected string GetEndingMessage(){
        return _endMessage;
    }
    protected void Animation(){

    }
}