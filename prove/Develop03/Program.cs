using System;
using System.Data;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Choose a Scripture to memorize!");
        Console.WriteLine("1. Ether 12:27");
        Console.WriteLine("2. 1 Nephi 11:16-17");
        Console.WriteLine("3. Alma 7:11-13");
        Console.WriteLine("4. Alma 32:27");
        Console.WriteLine("5. Ether 12:4");
        Console.WriteLine("6. Moroni 10:3-5");
        Console.WriteLine("7. 2 Nephi 26:23-24");
        string userChoice = Console.ReadLine();
        int intChoice = Int32.Parse(userChoice);
        VerseChooser chooser = new VerseChooser(intChoice);
        Scripture scripture = chooser.ChooseVerse();
        string quit;
        do{
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("Please press enter or type quit.");
            quit = Console.ReadLine();
            scripture.HideWords();
        } while (quit != "quit" && scripture.IsCompletelyHidden() == false);
        Console.Clear();
        Console.WriteLine(scripture.GetRenderedText());
    }
}