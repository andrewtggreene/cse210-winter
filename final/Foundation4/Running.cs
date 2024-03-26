class Running: Activity{
    private double _distance;
    public Running(string date, int length, double distance):base(date, length){
        _distance = distance;
    }
    protected override double GetDistance(){
        return Math.Round(_distance,2);
    }
    protected override double GetPace(){
        return Math.Round(_length / _distance,2);
    }
    protected override double GetSpeed(){
        return Math.Round(_distance / _length * 60,2);
    }
    protected override string GetTypeOfActivity(){
        return "Running";
    }
}