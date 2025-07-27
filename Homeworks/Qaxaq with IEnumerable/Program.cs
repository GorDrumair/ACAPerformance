using System;
using System.Collections;

namespace Program;

class Program
{
    static void Main()
    {
        Landmark[] landmarks = new Landmark[3]
        {
            new Landmark("Hamalir", "Hamalir's Address"),
            new Landmark("Hraparak", "Hraparak's Address"),
            new Landmark("Matenadaran", "Matenadaran's Address")
        };

        
    }
}
 
class City : IEnumerable
{
    public string Name { get; set; }
    public Landmark[] Landmarks { get; set; }

    public City(string name, Landmark[] landmarks)
    {
        Name = name;
        Landmarks = landmarks;
    }

    public CityEnumerator GetEnumerator()
    {
        return new CityEnumerator(Landmarks);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator)GetEnumerator();
    }
}

class CityEnumerator : IEnumerator
{
    public Landmark[] _landmarks { get; set; }
    private int _position = -1;

    public CityEnumerator(Landmark[] landmarks)
    {
        _landmarks = landmarks;
    }

    public bool MoveNext()
    {
        _position++;
        return (_position < _landmarks.Length);
    }

    public void Reset()
    {
        _position = -1;
    }

    public object Current
    {
        get { return _landmarks[_position]; }
    }
}


class Landmark
{
    public string Name { get; set; }
    public string Address { get; set; }

    public Landmark(string name, string address)
    {
        Name = name;
        Address = address;
    }
}