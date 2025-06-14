using System;

namespace RectagnleComparison;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle(5, 10);
        Rectangle rect2 = new Rectangle(7, 7);

        Console.WriteLine($"Rectangle 1 is square: {rect1.IsSquare()}");
        Console.WriteLine($"Rectangle 2 is square: {rect2.IsSquare()}");

        if (rect1.IsLargerThan(rect2))
        {
            Console.WriteLine("Rectangle 1 is larger than Rectangle 2.");
        }
        else if (rect2.IsLargerThan(rect1))
        {
            Console.WriteLine("Rectangle 2 is larger than Rectangle 1.");
        }
        else
        {
            Console.WriteLine("Both rectangles are of equal size.");
        }
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

    public bool IsSquare()
    {
        return Length == Width ? true : false;
    }

    public bool IsLargerThan(Rectangle other)
    {
        return (Length * Width) > (other.Length * other.Width);
    }
}

    