using System;

namespace TemperatureRecorder;

class Program
{
    static void Main(string[] args)
    {
        TemperatureRecord record = new TemperatureRecord("New York", 22.5, DateTime.Now);
    }
}

struct TemperatureRecord
{
    public string City { get; set; }
    public double Celsius { get; set; }
    public DateTime Date { get; set; }

    public TemperatureRecord(string city, double celsius, DateTime date)
    {
        City = city;
        Celsius = celsius;
        Date = date;
    }
}