class Cycling: Activity{
    private double _speed;
    public Cycling(string date, int length, double speed):base(date, length){
        _speed = speed;
    }
    protected override double GetDistance(){
        return Math.Round(_speed * _length / 60 ,2);
    }
    protected override double GetPace(){
        return Math.Round(_length / GetDistance(),2);
    }
    protected override double GetSpeed(){
        return Math.Round(_speed,2);
    }
    protected override string GetTypeOfActivity(){
        return "Cycling";
    }    
}