using System;

namespace ZooProperites;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>()
        {
            new Animal("Lion", "male", 5),
            new Animal("Elephant", "female", 10)
        };
        Zoo zoo = new Zoo("City Zoo", 2004,animals);

        Console.WriteLine($"Zoo Name: {zoo.ZooName}");
        Console.WriteLine($"Made Year: {zoo.MadeYear}");

        // Console.WriteLine("Animals in the Zoo:");
    }
}

struct Zoo
{
    private string _zooName;
    private int _madeYear;
    private List<Animal> _animals;

    public string ZooName { get { return _zooName; } }
    public int MadeYear { get { return _madeYear; } }
    public  List<Animal> Animals { get { return _animals; } }


    public Zoo(string zooName, int madeYear, List<Animal> animals )
    {
        _zooName = zooName;
        _madeYear = madeYear;
        _animals = animals;
    }
}

struct Animal
{
    // private string _name;
    // private string _gender;
    // private int _age;

    public string Name { get; }

    public string FullName { get; }

    public string Gender { get; }
    public int Age { get; }

    public Animal(string name, string gender, int age)
    {
        Name = name;
        Gender = gender;
        Age = age;
    }
}