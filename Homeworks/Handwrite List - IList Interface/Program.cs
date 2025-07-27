using System;
using System.Collections;

namespace HandwriteList;

class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>();
        Dog dog = new Dog("Dog");
        Cat cat = new Cat("Cat");
        Dog dog1 = new Dog("Dog1");
        animals.Add(dog);
        animals.Add(cat);
        animals.Add(dog1);

        foreach (var i in animals)
        {
            Console.WriteLine(i);
        }
    }
}

class Zoo<T> : IEnumerable<T>
{
    private MyList<T> _animals;
    public IEnumerator<T> GetEnumerator()
    {
        return _animals.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
 
    
}

class Animal
{
    // public string Name { get; set; }

    // public Animal(string name)
    // {
    //     Name = name;
    // }
}

class Dog : Animal
{
    public string Name { get; }

    public Dog(string name)
    {
        Name = name;
    }
}
class Cat : Animal
{
    public string Name { get; }

    public Cat(string name)
    {
        Name = name;
    }
}








class MyList<T> : IList<T>
{
    private T[] _items = new T[8];
    private int _count;

    public MyList()
    {
        _count = 0;
    }


    public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int Count { get { return _count; }}

    public bool IsReadOnly { get { return false; }}

    public int Add(T item)
    {
        if (_count < _items.Length)
        {
            _items[_count] = item;
            _count++;

            return (_count - 1);
        } 
        return -1;
    }

    public void Clear()
    {
        Array.Clear(_items, 0, _items.Length);
    }

    public bool Contains(T item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_items[i].Equals(item))
            {
                return true;
            }
        }
        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        if (array != null && arrayIndex >= 0 && array.Length - arrayIndex >= _count)
        {
            Array.Copy(_items, 0, array, arrayIndex, _count);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in _items)
        {
            yield return item;
        }
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_items[i].Equals(item))
            {
                return i;
            }
        }
        return -1;
    }

    public void Insert(int index, T item)
    {
        if (_count + 1 <= _items.Length && index < _count && index >= 0)
        {
            _count++;

            for (int i = _count - 1; i > index; i--)
            {
                _items[i] = _items[i - 1];
            }
            _items[index] = item;
        }
    }

    public bool Remove(T item)
    {
        int index = -1;
        for (int i = 0; i < _items.Length; i++)
        {
            if (_items[i].Equals(item))
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
            _items[i] = _items[i + 1];
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
                _items[i] = _items[i + 1];
            }
            _count--;
        }
    }

    void ICollection<T>.Add(T item)
    {
        if (_count < _items.Length)
        {
            _items[_count] = item;
            _count++;
        } 
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

