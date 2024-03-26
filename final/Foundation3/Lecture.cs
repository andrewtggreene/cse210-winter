class Lecture: Event{
    private int _capacity;
    private string _speakerName;
    public Lecture(string title, string description, string date, string time, 
    Address address, int capacity, string speakerName):
    base(title, description, date, time, address){
        _capacity = capacity;
        _speakerName = speakerName;
    }
    public void DisplayLectureInfo(){
        DisplayShortDescription();
        Console.WriteLine($"Capacity: {_capacity} people\nSpeaker: {_speakerName}");
    }
}