using System;

namespace GeoLocation;

class Program
{
    static void Main(string[] args)
    {
        GeoLocation location = new GeoLocation(45.0, 90.0);
        Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}");

        GeoLocation invalidLocation = new GeoLocation(100.0, -200.0);
        Console.WriteLine($"Latitude: {invalidLocation.Latitude}, Longitude: {invalidLocation.Longitude}");
    }
}

struct GeoLocation
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public GeoLocation(double latitude, double longitude)
    {
        Latitude = latitude > 90 ? 90 : latitude < -90 ? -90 : latitude;
        Longitude = longitude > 180 ? 180 : longitude < -180 ? -180 : longitude;
    }
}