using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //test with the Square sub class
        Square square1 = new Square("blue", 4.56);
        Console.WriteLine(square1.GetColor());
        Console.WriteLine(square1.GetArea());

        //test with the Rectangle sub class
        Rectangle rectangle1 = new Rectangle("purple", 2.89, 3.87);
        Console.WriteLine(rectangle1.GetColor());
        Console.WriteLine(rectangle1.GetArea());

        //test with the Circle sub class
        Circle circle1 = new Circle("red", 4.35);
        Console.WriteLine(circle1.GetColor());
        Console.WriteLine(circle1.GetArea());

        List <Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);
        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetArea());
        }
    }
}