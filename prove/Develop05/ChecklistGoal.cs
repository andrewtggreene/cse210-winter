class ChecklistGoal: Goal{
    private int _bonusPoints;
    private int _bonusMark;
    private int _numCompleted;
    public ChecklistGoal(string name, string descritpion, int points, int bonusPoints, int bonusMark):base(name, descritpion, points){
        _bonusMark = bonusMark;
        _bonusPoints = bonusPoints;
        _numCompleted = 0;
    }
    public ChecklistGoal(string name, string descritpion, int points, int bonusPoints, int bonusMark, int numCompleted):base(name, descritpion, points){
        _bonusMark = bonusMark;
        _bonusPoints = bonusPoints;
        _numCompleted = numCompleted;
    }    
    public override string DisplayGoal(){
        string goalString = "";
        if (_numCompleted >= _bonusMark){
            goalString += "[x] ";
        } else {
            goalString += "[ ] ";
        }
        goalString += _name + " (" + _description + ") -- Currently completed: "+_numCompleted+"/"+_bonusMark ;
        return goalString;        

    }
    public override int RecordEvent(){
        _numCompleted += 1;
        if (_bonusMark % _numCompleted == 0){
            return _bonusPoints + _point;
        } else {
            return _point;
        }
    }
    public override string GetSaveFormat(){
        string newString = "";
        newString += $"Eternal Goal:{_name}:{_description}:{_point}:{_bonusPoints}:{_bonusMark}:{_numCompleted}";
        return newString;
    }
}