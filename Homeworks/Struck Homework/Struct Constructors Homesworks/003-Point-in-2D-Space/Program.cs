using System;

namespace PointIn2DSpcae;

class Program
{
    static void Main(string[] args)
    {
        Point2D point = new Point2D(3.5, 4.2);
        point.Print();
    }
}

struct Point2D
{
    public double X { get; set; }
    public double Y { get; set; }
    
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void Print()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }
}