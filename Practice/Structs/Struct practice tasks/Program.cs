using System;
using System.ComponentModel.DataAnnotations;

namespace StructPracticeTasks;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student("Kevin", "Clein", "AT053625", 62.0),
            new Student("George", "Boosh", "AN985214", 15.3),
            new Student("Emily", "Rosse", "AM966653", 100.0)
        };

        University university = new University("Armenian Scinence University", students);


        List<Student> PassedList = university.GetPassedStudentsList();
        List<Student> UnpassedList = university.GetUnPassedStudentsList();

        Console.WriteLine("Passed Students");
        for (int i = 0; i < PassedList.Count; i++)
        {
            Console.WriteLine($"Name: {PassedList[i].Name}, Surname: {PassedList[i].Surname}, Grade: {PassedList[i].ExamGrade}");
        }


        Console.WriteLine("Unpassed Students");
        for (int i = 0; i < UnpassedList.Count; i++)
        {
            Console.WriteLine($"Name: {UnpassedList[i].Name}, Surname: {UnpassedList[i].Surname}, Grade: {UnpassedList[i].ExamGrade}");
        }
    }
}

class University
{
    public string Name { get; }
    public DateTime CreatedAt { get; }
    public List<Student> Students { get; set; }

    private const double minGradeNumber = 0.0;
    private const double maxGradeNumber = 100.0;
    private const double passGradeNumber = 35.0;

    public University(string name, List<Student> students)
    {
        Name = name;
        CreatedAt = DateTime.Now;
        Students = students;
    }

    public void PrintStudentsList()
    {
        for (int i = 0; i < Students.Count; i++)
        {
            Console.WriteLine($"Name: {Students[i].Name}, Surname: {Students[i].Surname}");
        }
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void RemoveStudent(string passportNumber)
    {
        for (int i = 0; i < Students.Count; i++)
        {
            if (Students[i].PassportNumber == passportNumber)
            {
                Students.Remove(Students[i]);
                break;
            }
        }
    }

    public List<Student> GetPassedStudentsList()
    {
        List<Student> returnStudentsList = new List<Student>();

        for (int i = 0; i < Students.Count; i++)
        {
            if (Students[i].ExamGrade >= passGradeNumber && Students[i].ExamGrade <= maxGradeNumber)
            {
                returnStudentsList.Add(Students[i]);
            }
        }

        return returnStudentsList;
    }

    public List<Student> GetUnPassedStudentsList()
    {
        List<Student> returnStudentsList = new List<Student>();

        for (int i = 0; i < Students.Count; i++)
        {
            if (Students[i].ExamGrade <= passGradeNumber && Students[i].ExamGrade >= minGradeNumber)
            {
                returnStudentsList.Add(Students[i]);
            }
        }

        return returnStudentsList;
    }
}

class Student
{
    public string Name { get; }
    public string Surname { get; }
    public string PassportNumber { get; }
    public double ExamGrade { get; set; }

    public Student(string name, string surname, string passportNumber, double examGrade)
    {
        Name = name;
        Surname = surname;
        PassportNumber = passportNumber;
        ExamGrade = examGrade;
    }
}