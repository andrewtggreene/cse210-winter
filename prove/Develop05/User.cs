class User{
    protected int _userPoints;
    protected List<Goal> _listOfGoals = new List<Goal>{};
    protected string _trophyRoadStatus;
    protected List<string> _trophyRoad = new List<string>{"Baby Ninja:50", "Amateur Ninja:100",
"Professional Ninja:250", "Ninja Dragon Egg:500", "Ninja Dragon Hatchling:1000",
"Ninja Dragon Youngling:2000", "A Majestic Flying Ninja Dragon:10000", 
"Young Ninja Dragon Rider:15000", "Ninja Dragon Rider:25000", "Ultimate Ninja Dragon Warrior:100000"};
    public User(string filename){
        if (filename != ""){
            LoadFiles(filename);
        } else{
            _userPoints = 0;
            _trophyRoadStatus = "Non Ninja";
        }
    }
    public void SaveFiles(string filename){
        using (StreamWriter outputFile = new StreamWriter(filename)){
            outputFile.WriteLine($"{_userPoints}:{_trophyRoadStatus}");
            foreach(Goal goal in _listOfGoals){
                outputFile.WriteLine(goal.GetSaveFormat());
            }
        }
    }
    public void LoadFiles(string filename){
        string line1 = File.ReadLines(filename).First();
        string[] parts1 = line1.Split(":");
        _userPoints += Int32.Parse(parts1[0]);
        _trophyRoadStatus = parts1[1];
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
    private void AddNewGoal(Goal newGoal){
        _listOfGoals.Add(newGoal);
    }
    public void RecordEvent(int indexOfGoal){
        int earnedPoints = _listOfGoals[indexOfGoal].RecordEvent();
        _userPoints += earnedPoints;
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        Console.WriteLine($"You now have {_userPoints} points");
        AdvanceTrophyRoad();
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
        Console.WriteLine($"You have {_userPoints} points.");
        Console.WriteLine($"You are a {_trophyRoadStatus}.\n");
    }
    public void CreateNewGoal(string typeOfGoal){
        string name;
        string description;
        string points;
        int pointsInt;
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        points = Console.ReadLine();
        pointsInt = Int32.Parse(points);
        switch(typeOfGoal){
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal(name, description, pointsInt);
                AddNewGoal(simpleGoal);
                break;
            case "2":
                EternalGoal eternalGoal = new EternalGoal(name, description, pointsInt);
                AddNewGoal(eternalGoal);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string bonusMark = Console.ReadLine();
                int bonusMarkInt = Int32.Parse(bonusMark);
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonusPoints = Console.ReadLine();
                int bonusPointsInt = Int32.Parse(bonusPoints);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, pointsInt, bonusPointsInt, bonusMarkInt);
                AddNewGoal(checklistGoal);
                break;
        }
    }
    public void ViewTrophyRoad(){
        foreach(string trophyRoad in _trophyRoad){
            string[] parts = trophyRoad.Split(":");
            int pointsTillNext = Int32.Parse(parts[1]);
            if (pointsTillNext > _userPoints){
                Console.WriteLine($"Level: {parts[0]}---Unlocks at {parts[1]} points---{pointsTillNext - _userPoints} points untill this level!");
            } else {
                Console.WriteLine($"Level: {parts[0]}---Unlocked at {parts[1]}");
            }
        } 
    }
    private void AdvanceTrophyRoad(){
        int pointsTillNext = 0;
        foreach(string trophyRoad in _trophyRoad){
            string[] parts = trophyRoad.Split(":");
            int pointsNext = Int32.Parse(parts[1]);
            if (_userPoints >= pointsNext){
                _trophyRoadStatus = parts[0];
            } else {
                pointsTillNext = pointsNext - _userPoints;
                break;
            }
        }
        Console.WriteLine($"You are a {_trophyRoadStatus}! You need {pointsTillNext} to get to the next level!");
    }
}