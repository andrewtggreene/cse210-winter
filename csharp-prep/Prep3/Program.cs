using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        do {
            Random randomGenerator = new Random();
            int numberInt = randomGenerator.Next(1, 11);
            int guessInt;
            int guessTries = 0;
            do {
                guessTries += 1;
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessInt = int.Parse(guess);
        
                if (numberInt == guessInt) {
                    Console.WriteLine("You guessed it!");
                } else if (guessInt > numberInt) {
                    Console.WriteLine("Lower");
                } else if (guessInt < numberInt) {
                    Console.WriteLine("Higher");
                }
            } while (numberInt != guessInt);
            Console.WriteLine($"It took you {guessTries} tries!");
            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine();
        } while (playAgain == "yes");
    }
}