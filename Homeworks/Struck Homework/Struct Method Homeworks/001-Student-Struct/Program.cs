using System;

namespace StudentStruct;

class Program
{
    static void Main(string[] args)
    {
        Strudent student1 = new Strudent("Alice", 85.5);
        Strudent student2 = new Strudent("Bob", 92.0);

        student1.Print();
        student2.Print();
    }
}

struct Strudent
{
    public string Name { get; set; }
    public double Grade { get; set; }
    public Strudent(string name, double grade)
    {
        Name = name;
        Grade = grade;
    }
    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Grade: {Grade}");
    }
}