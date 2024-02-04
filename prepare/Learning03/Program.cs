using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac5 = new Fraction(5);
        Fraction frac1 = new Fraction();
        Fraction frac34 = new Fraction(3,4);
        Fraction frac13 = new Fraction(2,2);

        Console.WriteLine(frac5.getFractionString());
        Console.WriteLine(frac1.getFractionString());
        Console.WriteLine(frac34.getFractionString());
        Console.WriteLine(frac13.getFractionString());

        frac13.setBottom(3);
        frac13.setTop(1);
        Console.WriteLine(frac13.getFractionString());

        Console.WriteLine(frac5.getFractionDecimal());
        Console.WriteLine(frac1.getFractionDecimal());
        Console.WriteLine(frac34.getFractionDecimal());
        Console.WriteLine(frac13.getFractionDecimal());
        Console.WriteLine(frac5.getTop());
        Console.WriteLine(frac5.getBottom());
    }
}