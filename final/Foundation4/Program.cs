using System;

class Program
{
    static void Main(string[] args)
    {
        Swimming swimming = new Swimming("26 March 2022", 30, 50);

        Cycling cycling = new Cycling("27 March 2024", 30, 12.33);

        Running running = new Running("28 March 2024", 30, 3);

        List<Activity> _listOfActivities = new List<Activity>{swimming, cycling, running};
        foreach (Activity activity in _listOfActivities){
            Console.WriteLine(activity.GetSummary());
        }
    }
}