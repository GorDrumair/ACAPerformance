using System;
using System.Dynamic;

namespace Calculator;

class Program
{
    public static void Main()
    {
        DataStore<int> dataStore = new DataStore<int>();
        dataStore.AddOrUpdate(0, 2);
        dataStore.AddOrUpdate(1, 3);
        dataStore.AddOrUpdate(2, 4);

        DataStore<string> dataStore1 = new DataStore<string>();
        dataStore1.AddOrUpdate(0, "A");
        dataStore1.AddOrUpdate(1, "B");
        dataStore1.AddOrUpdate(2, "C");
    }
}

public class DataStore<T>
{
    private T[] _data = new T[10];

    public void AddOrUpdate(int index, T items)
    {
        _data[index] = items;
    }


    public T LoopMethod()
    {
        
    }
}