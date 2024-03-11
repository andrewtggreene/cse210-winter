abstract class Goal{
    protected string _name;
    protected string _description;
    protected int _point;
    public Goal(string name, string descritpion, int points){
        _name = name;
        _description = descritpion;
        _point = points;
    }
    public abstract string DisplayGoal();
    public abstract int RecordEvent();    
    public abstract string GetSaveFormat();
}