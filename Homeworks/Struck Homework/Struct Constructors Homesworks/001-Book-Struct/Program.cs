using System;

namespace BookStruct;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("1984", "George Orwell", 1949);
    }
}

struct Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearPublished { get; set; }

    public Book(string title, string author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
    }
}