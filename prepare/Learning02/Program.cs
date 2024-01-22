using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job1._company = "Applebees";
        
        Console.WriteLine(job1._jobTitle);
        Console.WriteLine(job1._company);
        Console.WriteLine(job1._startYear);
        Console.WriteLine(job1._endYear);
        
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Janitor";
        job2._company = "BYUI";
        job2._startYear = 2023;
        job2._endYear = 2024;
        
        Console.WriteLine(job2._jobTitle);
        Console.WriteLine(job2._company);
        Console.WriteLine(job2._startYear);
        Console.WriteLine(job2._endYear);
        
        job2.Display();
        
        Resume myResume = new Resume();
        myResume._name = "Andrew Greene";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        Console.WriteLine(myResume._jobs[0]._jobTitle);
        
        myResume.Display();
    }
}