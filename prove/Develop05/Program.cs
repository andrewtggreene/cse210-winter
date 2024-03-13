using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Is there a file you would like to load? ");
        Console.WriteLine("1. Yes\n2. No");
        string haveFile = Console.ReadLine();
        string filename="";
        if (haveFile == "1"){
            Console.Write("Please Enter a File Name: ");
            filename = Console.ReadLine();
        }
        User user = new User(filename);
        string userChoice = "";
        do{
            Console.WriteLine("");
            user.DisplayPoints();

            Console.WriteLine("\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals\n\t5. Record Event\n\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();
            switch(userChoice){
                case "1":
                    Console.WriteLine("The ypes of Goals are:\n\t1. Simple Goal\n\t2. Eternal Goal");
                    Console.WriteLine("\t3. Checklist Goal\nWhich type of goal would you like to create? ");
                    string typeOfGoal = Console.ReadLine();
                    string name;
                    string description;
                    string points;
                    int pointsInt;
                    switch(typeOfGoal){
                        case "1":
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            points = Console.ReadLine();
                            pointsInt = Int32.Parse(points);
                            SimpleGoal simpleGoal = new SimpleGoal(name, description, pointsInt);
                            user.AddNewGoal(simpleGoal);
                            break;
                        case "2":
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            points = Console.ReadLine();
                            pointsInt = Int32.Parse(points);
                            EternalGoal eternalGoal = new EternalGoal(name, description, pointsInt);
                            user.AddNewGoal(eternalGoal);
                            break;
                        case "3":
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            points = Console.ReadLine();
                            pointsInt = Int32.Parse(points);
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            string bonusMark = Console.ReadLine();
                            int bonusMarkInt = Int32.Parse(bonusMark);
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            string bonusPoints = Console.ReadLine();
                            int bonusPointsInt = Int32.Parse(bonusPoints);
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, pointsInt, bonusPointsInt, bonusMarkInt);
                            user.AddNewGoal(checklistGoal);
                            break;
                    }
                    break;
                case "2":
                    user.DisplayGoals();
                    break;
                case "3":
                    Console.Write("What is the file name for the goal file? ");
                    string filenameSave = Console.ReadLine();
                    user.SaveFiles(filenameSave);
                    break;
                case "4":
                    Console.Write("What is the name of the file? ");
                    string filenameLoad = Console.ReadLine();
                    user.LoadFiles(filenameLoad);
                    break;
                case "5":
                    user.DisplayGoals();
                    Console.Write("Which goal did you accomplish? ");
                    string selectGoal = Console.ReadLine();
                    int selectedGoal = Int32.Parse(selectGoal);
                    selectedGoal -= 1;
                    user.RecordEvent(selectedGoal);
                    break;
                default:
                    break;
            }
        }while (userChoice != "6");
    }
}