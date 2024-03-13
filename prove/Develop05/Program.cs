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
            Console.WriteLine("\t4. Load Goals\n\t5. Record Event\n\t6. View Trophy Road");
            Console.WriteLine("\t7. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();
            switch(userChoice){
                case "1":
                    Console.WriteLine("The ypes of Goals are:\n\t1. Simple Goal\n\t2. Eternal Goal");
                    Console.WriteLine("\t3. Checklist Goal\nWhich type of goal would you like to create? ");
                    string typeOfGoal = Console.ReadLine();
                    user.CreateNewGoal(typeOfGoal);
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
                case "6":
                    user.ViewTrophyRoad();
                    break;
                default:
                    break;
            }
        }while (userChoice != "7");
    }
}