using System;

namespace TrafficLightSimulator;

class Program
{
    static void Main(string[] args)
    {
        Intersection intersection = new Intersection("Main St & 1st Ave", TrafficLight.Red);
        Console.WriteLine($"Intersection: {intersection.Name}, Current Light: {intersection.CurrentLight}");

        // Simulate changing the traffic light
        intersection.CurrentLight = TrafficLight.Yellow;
        Console.WriteLine($"Intersection: {intersection.Name}, Current Light: {intersection.CurrentLight}");

        // Simulate another change
        intersection.CurrentLight = TrafficLight.Green;
        Console.WriteLine($"Intersection: {intersection.Name}, Current Light: {intersection.CurrentLight}");
    }
}

struct Intersection
{
    public string Name { get; set; }
    public TrafficLight CurrentLight { get; set; }

    public Intersection(string name, TrafficLight light)
    {
        Name = name;
        CurrentLight = light;
    }
}

enum TrafficLight : int
{
    Red = 1,
    Yellow = 2,
    Green = 3
}