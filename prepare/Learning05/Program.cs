using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(20 ,"Green");
        Console.WriteLine(square.GetArea());
        Console.WriteLine(square.GetColor());
        Rectangle rectangle = new Rectangle(20,30, "Red");
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(rectangle.GetColor());
        Circle circle = new Circle(7, "Yellow");
        Console.WriteLine(circle.GetArea());
        Console.WriteLine(circle.GetColor());
        List<Shape> shapes = new List<Shape>{};
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach (Shape shape in shapes){
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}