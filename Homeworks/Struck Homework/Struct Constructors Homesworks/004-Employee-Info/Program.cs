using System;

namespace EmployeeInfo;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("John Doe", 30, 320000);
    }
}

struct Employee
{
    public string Name { get; }
    public int Age { get; }
    public decimal Salary { get; }

    public Employee(string name, int age, decimal salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
}


