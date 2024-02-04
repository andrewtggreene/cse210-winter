public class Fraction {
    private int _top;
    private int _bottom;
    public  Fraction (){
        _top = 1;
        _bottom = 1;
    }
    public Fraction (int WholeNumber){
        _top = WholeNumber;
        _bottom = 1;
    }
    public Fraction (int top, int bottom){
        _top = top;
        _bottom = bottom;
    }
    public int getTop (){
        return _top;
    }
    public int getBottom (){
        return _bottom;
    }
    public void setTop (int top){
        _top = top;
    }
    public void setBottom (int bottom){
        _bottom = bottom;
    }
    public string getFractionString () {
        string fracString = _top + "/" + _bottom;
        return fracString;
    }
    public double getFractionDecimal (){
        double newDecimal = ((double)_top / (double)_bottom);
        return newDecimal;
    }
}