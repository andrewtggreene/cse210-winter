class User{
    protected int _userPoints;
    protected List<Goal> _listOfGoals = new List<Goal>{};
    public User(string filename){
        LoadFiles(filename);
    }
    public User(){

    }
    public void SaveFiles(string filename){

    }
    public void LoadFiles(string filename){

    }
    public void AddNewGoal(Goal newGoal){
        _listOfGoals.Add(newGoal);
    }
    public void RecordEvent(int indexOfGoal){
        int earnedPoints = _listOfGoals[indexOfGoal].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        Console.WriteLine($"You now have {_userPoints} points");
    }
    public void DisplayGoals(){
        Console.WriteLine("The goals are");
        foreach (Goal goal in _listOfGoals){
            Console.WriteLine(goal.DisplayGoal());
        }
        Console.WriteLine($"\nYou have {_userPoints} points.");
    }
    public void DisplayPoints(){
        Console.WriteLine($"You have {_userPoints}.\n");
    }
}