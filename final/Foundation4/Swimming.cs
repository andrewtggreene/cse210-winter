class Swimming: Activity{
    private int _numLaps;
    public Swimming(string date, int length, int laps):base(date, length){
        _numLaps = laps;
    }
    protected override double GetDistance(){
        return Math.Round(_numLaps * 50 / 1000 * 0.62,2);
    }
    protected override double GetPace(){
        return Math.Round(_length / GetDistance(), 2);
    }
    protected override double GetSpeed(){
        return Math.Round(60 / GetPace(),2);
    }
    protected override string GetTypeOfActivity(){
        return "Swimming";
    }
}