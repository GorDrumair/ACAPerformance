using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace CSharpCourseImplementation;

class Program
{
    static void Main(string[] args)
    {

        Teacher Garik = new Teacher("Garik", "Nikoyan");
        
    }
}


abstract class Company
{
    public string Name { get; set; }

    public abstract void SingContract();
}

abstract class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
}

abstract class Contract
{
    public string Name { get; set; }
    public ContractType ContractType { get; set; }

}



class ArmenianCodeAcademy : Company
{
    public string Name { get; set; }
    public override void SingContract(Person person, ContractType contractType)
    {
        Console.WriteLine($"Person:");
    }
}





class Teacher : Person
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Teacher(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public void Teach()
    {

    }

    public void GetPaid()
    {

    }

}

class Student : Person
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Student(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public void PayForCourse()
    {

    }

    public void Learn()
    {

    }
}


enum ContractType
{
    None = 0,
    Company2Teacher = 1,
    Company2Student = 2
}

// class Course
// {
//     public string Name { get; }
//     public int PaymentPerMonth { get; }

//     public List<Student> Students;

//     public Course(string name, int paymentPerMonth, List<Student> students)
//     {
//         Name = name;
//         PaymentPerMonth = paymentPerMonth;
//         Students = students;
//     }
// }

// enum CourseMonths
// {
//     May,
//     June,
//     Jule,
//     August,
//     September,
//     October,
// }