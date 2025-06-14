using System;

namespace TemperatureConvension;

class Program
{
    static void Main(string[] args)
    {
        TemperatureConvension tempConv = new TemperatureConvension(25.0);
        Console.WriteLine($"Celsius: {tempConv.Celsius}");
        Console.WriteLine($"Fahrenheit: {tempConv.ToFahrenheit()}");
        Console.WriteLine($"Kelvin: {tempConv.ToKelvin()}");
    }
}

struct TemperatureConvension
{
    public double Celsius;

    public TemperatureConvension(double celsius)
    {
        Celsius = celsius;
    }

    public double ToFahrenheit()
    {
        return (Celsius * 9 / 5) + 32;
    }
    public double ToKelvin()
    {
        return Celsius + 273.15;
    }
}