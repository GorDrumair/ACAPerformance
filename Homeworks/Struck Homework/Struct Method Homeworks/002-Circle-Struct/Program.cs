using System;

namespace CircleStruct;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5.0);

        Console.WriteLine($"Circle with radius {circle.Radius}");
        Console.WriteLine($"Area: {Math.Round(circle.GetArea(), 2)}");
        Console.WriteLine($"Circumference: {Math.Round(circle.GetCircumference(), 2)}");
    }
}

struct Circle
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * Radius;
    }
}