using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int gradePercent = int.Parse(gradeString);
        string letterGrade;
        string plusMinus = "";
        if (gradePercent >= 90) {
            letterGrade = "A";
            if (gradePercent < 93) {
                plusMinus = "-";
            }
        } else if (gradePercent >= 80) {
            letterGrade = "B";
            if (gradePercent >= 87) {
                plusMinus = "+";
            } else if (gradePercent < 83) {
                plusMinus = "-";
            }
        } else if (gradePercent >= 70) {
            letterGrade = "C";
            if (gradePercent >= 77) {
                plusMinus = "+";
            } else if (gradePercent < 73) {
                plusMinus = "-";
            }
        } else if (gradePercent >= 60) {
            letterGrade = "D";
            if (gradePercent >= 67) {
                plusMinus = "+";
            } else if (gradePercent < 63) {
                plusMinus = "-";
            }
        } else {
            letterGrade = "F";
        }
        Console.WriteLine($"Your grade is a {letterGrade}{plusMinus}");
        if (gradePercent >= 70) {
            Console.WriteLine("Congratulations! You have passed the class!");
        } else {
            Console.WriteLine("Bummer! Try Harder Next Time, You Failed.");
        }
    }
}