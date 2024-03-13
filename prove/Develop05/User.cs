class User{
    protected int _userPoints;
    protected List<Goal> _listOfGoals = new List<Goal>{};
    public User(string filename){
        if (filename != ""){
            LoadFiles(filename);
        }
    }
    public void SaveFiles(string filename){
        using (StreamWriter outputFile = new StreamWriter(filename)){
            outputFile.WriteLine($"{_userPoints}");
            foreach(Goal goal in _listOfGoals){
                outputFile.WriteLine(goal.GetSaveFormat());
            }
        }
    }
    public void LoadFiles(string filename){
        string line1 = File.ReadLines(filename).First();
        _userPoints += Int32.Parse(line1);
        string[] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines){

            string[] parts = line.Split(":");

            string goalType = parts[0];
            if (goalType == "SimpleGoal"){
                string name = parts[1];
                string descritpion = parts[2];
                string points = parts[3];
                string completed = parts[4];
                int pointsNum = Int32.Parse(points);
                bool completedBool = Convert.ToBoolean(completed);
                SimpleGoal simpleGoal = new SimpleGoal(name, descritpion, pointsNum, completedBool);
                AddNewGoal(simpleGoal);
            } else if (goalType == "ChecklistGoal"){
                string name = parts[1];
                string descritpion = parts[2];
                string points = parts[3];
                string bonusPoints = parts[4];
                string bonusMark = parts[5];
                string numCompleted = parts[6];
                int pointsNum = Int32.Parse(points);
                int bonusPointsInt = Int32.Parse(bonusPoints);
                int bonusMarkInt = Int32.Parse(bonusMark);
                int numCompletedInt = Int32.Parse(numCompleted);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, descritpion, pointsNum, bonusPointsInt, bonusMarkInt, numCompletedInt);
                AddNewGoal(checklistGoal);
            }else {
                string name = parts[1];
                string descritpion = parts[2];
                string points = parts[3];
                int pointsNum = Int32.Parse(points);
                EternalGoal eternalGoal = new EternalGoal(name, descritpion, pointsNum);
                AddNewGoal(eternalGoal);
            }
        }
        DisplayGoals();
    }
    public void AddNewGoal(Goal newGoal){
        _listOfGoals.Add(newGoal);
    }
    public void RecordEvent(int indexOfGoal){
        int earnedPoints = _listOfGoals[indexOfGoal].RecordEvent();
        _userPoints += earnedPoints;
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        Console.WriteLine($"You now have {_userPoints} points");
    }
    public void DisplayGoals(){
        Console.WriteLine("The goals are:");
        int index = 1;
        foreach (Goal goal in _listOfGoals){
            Console.WriteLine($"{index}. {goal.DisplayGoal()}");
            index += 1;
        }
    }
    public void DisplayPoints(){
        Console.WriteLine($"You have {_userPoints} points.\n");
    }
}