using System;

class Program
{
    static void Main(string[] args)
    {
        string UserChoice;
        Journal newJournal = new Journal();
         do{
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            UserChoice = Console.ReadLine();

            if (UserChoice == "1"){
                Console.WriteLine("Please select one of the follow types of prompts:");
                Console.WriteLine("1. Reflective");
                Console.WriteLine("2. Mindset");
                Console.WriteLine("3. Grattitude");
                Console.WriteLine("4. Goals");
                Console.WriteLine("5. Fun");
                Console.WriteLine("6. Morning");
                Console.WriteLine("7. Evening");
                Console.Write("Which kind of prompt would you like to respond to? ");
                string promptType = Console.ReadLine();
                newJournal.AddEntry(promptType);
            } else if (UserChoice == "2"){
                newJournal.DisplayEntries();
            } else if (UserChoice == "3"){
                Console.WriteLine("What is the filename? ");
                Console.Write("> ");
                string filename = Console.ReadLine();
                newJournal.LoadEntries(filename);
            }else if (UserChoice == "4"){
                Console.WriteLine("What is the filename? ");
                Console.Write("> ");
                string filename = Console.ReadLine();
                newJournal.SaveEntries(filename);
            } else {
                break;
            }
         } while(UserChoice != "5");

    }
}
