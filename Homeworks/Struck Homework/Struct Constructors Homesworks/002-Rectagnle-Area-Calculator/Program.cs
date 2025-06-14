using System;

namespace RectagnleAreaCalculator;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5.0, 3.0);
        
        Console.WriteLine($"Length: {rectangle.Length}");
        Console.WriteLine($"Width: {rectangle.Width}");
        Console.WriteLine($"Area: {rectangle.Area()}");
    }
}

struct Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double Area()
    {
        return Length * Width;
    }
}