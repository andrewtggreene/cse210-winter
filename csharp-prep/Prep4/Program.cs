using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> listOfNumbers = new List<int>(); 
        int userNumber;
        do {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            userNumber = int.Parse(number);
            if (userNumber != 0) {
            listOfNumbers.Add(userNumber);
            }
        } while (userNumber != 0);
        double sum = 0;
        int largest = 0;
        int closestToZero = int.MaxValue;
        foreach (int number in listOfNumbers) {
            sum += number;
            if (number > largest) {
                largest = number;
            }
            if (number > 0 && number < closestToZero) {
                closestToZero = number;
            }
        }
        double average = sum / listOfNumbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {closestToZero}");
        Console.WriteLine("The sorted list is: ");
        listOfNumbers.Sort();
        foreach (int number in listOfNumbers) {
            Console.WriteLine($"{number}");
        }
        
    }
}