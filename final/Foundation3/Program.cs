using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("532 S 2nd E", "Rexburg", "ID", "US");
        Event event1 = new Event("Intro to Mathematics", 
        "A short 30 minute event to welcome you to the Math Department", 
        "3/25/2024", "12:00 PM", address1);
        event1.DisplayShortDescription();

        Console.WriteLine();

        Address address2 = new Address("488 S 2nd E", "Rexburg", "ID", "US");
        Lecture lecture = new Lecture("Lecture on Spectral Theory", 
        "Join us as we hear from Roger Horn on the new advancements in Spectral Theory", 
        "3/30/2024", "11:30 AM", address2, 50, "Roger Horn");
        lecture.DisplayLectureInfo();

        Console.WriteLine();

        Address address3 = new Address("48 S 2nd E", "Rexburg", "ID", "US");
        Reception reception = new Reception("Graduation Reception", 
        "Come celebrate all of the 2024 Winter Graduates!", 
        "4/6/2024", "3:00 PM", address3, "atggreene@byui.edu");
        reception.DisplayReceptionInfo();

        Console.WriteLine();

        Address address4 = new Address("750 S 2nd E", "Rexburg", "ID", "US");
        OutdoorEvent outdoorEvent = new OutdoorEvent("Ultimate Frisbee Championship", 
        "Watch as Undefeated Team A seek to cap off an impressive season against the surging Team C!", 
        "4/7/2024", "5:00 PM", address4, "Sunny With a Temperature hovering around 72 degress!");
        outdoorEvent.DisplayOutdoorInfo();
    }
}