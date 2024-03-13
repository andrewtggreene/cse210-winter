class EternalGoal:Goal{
    public EternalGoal(string name, string descritpion, int points):base(name, descritpion, points){}
    public override string DisplayGoal(){
        string goalString = "[ ] ";
        goalString += _name + " (" + _description + ")";
        return goalString;
    }
    public override int RecordEvent(){
        return _point;
    }
    public override string GetSaveFormat(){
        string newString = "";
        newString += $"EternalGoal:{_name}:{_description}:{_point}";
        return newString;
    }
}