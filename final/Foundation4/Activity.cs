abstract class Activity{
    protected string _date;
    protected int _length;
    public Activity(string date, int length){
        _date = date;
        _length = length;
    }
    public string GetSummary(){
        return $"{_date} {GetTypeOfActivity()} ({_length} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
    protected abstract string GetTypeOfActivity();
    protected abstract double GetDistance();
    protected abstract double GetSpeed();
    protected abstract double GetPace();
}