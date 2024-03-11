class SimpleGoal: Goal{
    private bool _completed;
    public SimpleGoal(string name, string descritpion, int points): base(name, descritpion, points){
        _completed = false;
    }
    public override string DisplayGoal(){
        string goalString = "";
        if (_completed){
            goalString += "[x] ";
        } else {
            goalString += "[ ] ";
        }
        goalString += _name + " (" + _description + ")";
        return goalString;
    }
    public override int RecordEvent(){
        _completed = true;
        return _point;
    }
    public override string GetSaveFormat(){
        string newString = "";
        newString += $"SimpleGoal:{_name}:{_description}:{_point}:{_completed}";
        return newString;
    }
}