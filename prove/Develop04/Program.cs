using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        string durationString;
        int duration;
        do{
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Start Breathing Activity");
        Console.WriteLine("\t2. Start Reflecting Activity");
        Console.WriteLine("\t3. Start Listing Activity");
        Console.WriteLine("\t4. Quit");
        Console.Write("Select a choice from the menu: ");
        userChoice = Console.ReadLine();
        Console.Clear();
        switch(userChoice){
            case "1":
                BreathingActivity breathe = new BreathingActivity();
                Console.Write(breathe.GetStartingMessage());
                durationString = Console.ReadLine();
                duration = Int32.Parse(durationString);
                breathe.SetDuration(duration);
                Console.Clear();
                breathe.RunBreathingActivity();
                break;
            case "2":
                ReflectionActivity reflect = new ReflectionActivity();
                Console.Write(reflect.GetStartingMessage());
                durationString = Console.ReadLine();
                duration = Int32.Parse(durationString);
                reflect.SetDuration(duration);
                Console.Clear();
                reflect.RunReflectionActivity();
                break;
            case "3":
                ListingActivty listing = new ListingActivty();
                Console.Write(listing.GetStartingMessage());
                durationString = Console.ReadLine();
                duration = Int32.Parse(durationString);
                listing.SetDuration(duration);
                Console.Clear();
                listing.RunListingActivity();
                break;
            case "4":
                break;
            default:
                Console.WriteLine("Please type a valid selection!");
                break;
            }
        } while (userChoice != "4");
    }
}
