using System;

namespace NewAndOverride;

class Program
{
    public static void Main()
    {
        Animal animal = new SuperDog();
        Animal animal1 = new Dog();
        Animal animal2 = new Animal();
        List<Animal> animals = new List<Animal>()
        {
            animal,
            animal1,
            animal2
        };

        // for (int i = 0; i < animals.Count; i++)
        // {
        //     // if (animals[i] is Dog)
        //     // {
        //     //     var d = animals[i] as Dog;
        //     // }
        //     if (animals[i] is Dog a)
        //     {
        //         a.SomeVoice();
        //     }
        // }

        foreach (var item in animals)
        {
            switch (item)
            {
                case SuperDog superDog:
                    superDog.SomeVoice();
                    break;
                case Dog dog:
                    dog.SomeVoice();
                    break;
                case Animal dog:
                    dog.SomeVoice();
                    break;



                    /// Tnayin 
            }
        }
    }
}

class Animal
{
    public virtual void SomeVoice()
    {
        Console.WriteLine("Animal's Voice");
    }
}

class Dog : Animal
{
    public new virtual void SomeVoice()
    {
        Console.WriteLine("Dog's Voice");
    }
}

class SuperDog : Dog
{
    public override void SomeVoice()
    {
        Console.WriteLine("SuperDog's Voice");
    }
}




class Cat : Animal
{
    public new void SomeVoice()
    {
        Console.WriteLine("Cat's Voice");
    }
}

class SuperCat : Cat
{
    public new void SomeVoice()
    {
        Console.WriteLine("SuperCat's Voice");
    }
}