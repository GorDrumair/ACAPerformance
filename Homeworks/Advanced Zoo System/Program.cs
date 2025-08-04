using System;
using System.Collections;

namespace Program;

class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();

        Animal dog = new Dog("Dog", "Labrador");
        Animal bulldog = new Bulldog("Klaus");
        Animal cat = new Cat("Whiskers");
        Animal siamese = new Siamese("Master");
        Animal bird = new Bird("Tweetie");
        Animal parrot = new Parrot("Polly");

        zoo.Add(bulldog);
        zoo.Add(dog);
        zoo.Add(cat);
        zoo.Add(siamese);
        zoo.Add(bird);
        zoo.Add(parrot);

        Console.WriteLine("\nMake all animal sounds:");
        zoo.MakeAllSounds();
        Console.WriteLine("\nMove all animals:");
        zoo.MoveAllAnimals();
        Console.WriteLine("\nShow animal infos:");
        zoo.ShowAnimalInfos();
        Console.WriteLine("\nPlay with pets:");
        zoo.PlayWithPets();
        Console.WriteLine("\nLet birds fly:");
        zoo.LetBirdsFly();

        

        Console.WriteLine("\nShow specific animal info:");
        foreach (var animal in zoo)
        {
            if (animal == null) continue;
            if (animal is Bulldog a)
            {
                a.Info();
            }
            else if (animal is Dog b)
            {
                b.Info();
            }
            else if (animal is Siamese c)
            {
                c.Info();
            }
            else if (animal is Cat d)
            {
                d.Info();
            }
            else if (animal is Parrot e)
            {
                e.Info();
            }
            else if (animal is Bird f)
            {
                f.Info();
            }
        }

    }
}



interface IPet
{
    public void Play();
}

interface IFlyable
{
    public void Fly();
}






abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Animal()
    {

    }

    public abstract void MakeSound();
    public virtual void Move()
    {
        Console.WriteLine($"{Name} moves is a generic way.");
    }
    public void Info()
    {
        Console.WriteLine($"{Name} is a general animal.");
    }
}



class Zoo : IList<Animal>
{
    private Animal[] _animals = new Animal[8];
    private int _count;

    public Zoo()
    {
        _count = 0;
    }

    public Animal this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(Animal animal)
    {
        if (_count < _animals.Length)
        {
            _animals[_count] = animal;
            _count++;
        }
    }

    public void Clear()
    {
        Array.Clear(_animals, 0, _animals.Length);
    }

    public bool Contains(Animal animal)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_animals[i].Equals(animal))
            {
                return true;
            }
        }
        return false;
    }

    public void CopyTo(Animal[] array, int arrayIndex)
    {
        if (array != null && arrayIndex >= 0 && array.Length - arrayIndex >= _count)
        {
            Array.Copy(_animals, 0, array, arrayIndex, _count);
        }
    }

    public IEnumerator<Animal> GetEnumerator()
    {
        foreach (var animal in _animals)
        {
            yield return animal;
        }
    }

    public int IndexOf(Animal animal)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_animals[i].Equals(animal))
            {
                return i;
            }
        }
        return -1;
    }

    public void Insert(int index, Animal animal)
    {
        if (_count + 1 <= _animals.Length && index < _count && index >= 0)
        {
            _count++;

            for (int i = _count - 1; i > index; i--)
            {
                _animals[i] = _animals[i - 1];
            }
            _animals[index] = animal;
        }
    }

    public bool Remove(Animal animal)
    {
        int index = -1;
        for (int i = 0; i < _animals.Length; i++)
        {
            if (_animals[i].Equals(animal))
            {
                index = i;
            }
        }

        if (index < 0)
        {
            return false;
        }

        for (int i = index; i <= _count; i++)
        {
            _animals[i] = _animals[i + 1];
        }
        _count--;

        return true;
    }

    public void RemoveAt(int index)
    {
        if (index > 0 && index <= _count)
        {
            for (int i = index; i < _count; i++)
            {
                _animals[i] = _animals[i + 1];
            }
            _count--;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void MakeAllSounds()
    {
        foreach (var animal in _animals)
        {
            if (animal == null) continue;
            animal.MakeSound();
        }
    }

    public void MoveAllAnimals()
    {
        foreach (var animal in _animals)
        {
            if (animal == null) continue;
            animal.Move();
        }
    }

    public void ShowAnimalInfos()
    {
        foreach (var animal in _animals)
        {
            if (animal == null) continue;
            animal.Info();
        }
    }

    public void PlayWithPets()
    {
        foreach (var animal in _animals)
        {
            if (animal == null) continue;
            if (animal is IPet)
            {
                IPet pet = (IPet)animal;
                pet.Play();
            }
        }
    }

    public void LetBirdsFly()
    {
        foreach (var animal in _animals)
        {
            if (animal == null) continue;
            if (animal is IFlyable)
            {
                IFlyable bird = (IFlyable)animal;
                bird.Fly();
            }
        }
    }
}







class Dog : Animal, IPet
{
    public string Breed { get; set; }
    public Dog(string name, string breed)
    {
        Name = name;
        Breed = breed;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
    public new void Info()
    {
        Console.WriteLine($"{Name} is a Dog of bread {Breed}");
    }

    public void Play()
    {
        Console.WriteLine($"{Name} is playing happily.");
    }
}

class Bulldog : Dog
{
    public Bulldog(string name) : base(name, "Bulldog")
    {
        Name = name;
        Breed = "Bulldog";
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} wlaks slowly with heavy steps.");
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} grumbles and says: Woof!");
    }
    public new void Info()
    {
        Console.WriteLine($"{Name} is a tough Bulldog");
    }
}




class Cat : Animal
{
    public bool IsIndoor { get; set; }
    public Cat(string name)
    {
        Name = name;
        IsIndoor = true;
    }
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
    public new void Info()
    {
        Console.WriteLine($"{Name} is a {(IsIndoor ? "house" : "street")} cat.");
    }
}

class Siamese : Cat
{
    public Siamese(string name) : base(name)
    {
        Name = name;
        IsIndoor = true;
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} walks gracefully like a dancer.");
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} purrs softly.");
    }
    public new void Info()
    {
        Console.WriteLine($"{Name} is an elegant Siamense cat.");
    }
}





class Bird : Animal, IFlyable
{
    public Bird(string name)
    {
        Name = name;
        CanFly = true;
    }
    public bool CanFly { get; set; }
    public override void MakeSound()
    {
        Console.WriteLine("Tweet!");
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} {(CanFly ? "flies" : "walks")} around.");
    }
    public new void Info()
    {
        Console.WriteLine($"{Name} is a bird.");
    }

    public void Fly()
    {
        if (CanFly == true)
        {
            Console.WriteLine($"{Name} flaps and flies.");
        }
    }
}

class Parrot : Bird
{
    public Parrot(string name) : base(name)
    {
        Name = name;
        CanFly = true;
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} mimics: Hello!");
    }
    public new void Info()
    {
        Console.WriteLine($"{Name} is a talking Parrot.");
    }
}