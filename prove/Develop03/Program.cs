using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        string verse = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        Reference reference = new Reference("Ether", 12, 27);
        Scripture scripture = new Scripture(reference, verse);
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