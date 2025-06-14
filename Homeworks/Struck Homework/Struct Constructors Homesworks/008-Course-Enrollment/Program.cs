using System;

namespace CourseEnrollment;

class Program
{
    static void Main(string[] args)
    {
        Course course = new Course("CS101", "Introduction to Computer Science", 3);
        Console.WriteLine($"Course Code: {course.Code}");
        Console.WriteLine($"Course Title: {course.Title}");
        Console.WriteLine($"Credits: {course.Credits}");
    }
}

struct Course
{
    public string Code { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }

    public Course(string code, string title, int credits)
    {
        Code = code;
        Title = title;
        Credits = credits;
    }
}