using System;

namespace VotingEligibility;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Alice", 20);
        Console.WriteLine($"{person.Name} is eligible to vote: {person.IsEligibleToVote()}");

        person.Age = 17;
        Console.WriteLine($"{person.Name} is eligible to vote: {person.IsEligibleToVote()}");

        person.Name = "Bob";
        person.Age = 18;
        Console.WriteLine($"{person.Name} is eligible to vote: {person.IsEligibleToVote()}");
    }
}

struct Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public bool IsEligibleToVote()
    {
        return Age >= 18;
    }
}