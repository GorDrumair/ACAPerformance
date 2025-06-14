using System;

namespace UserProfile;

class Program
{
    static void Main(string[] args)
    {
        UserProfile user = new UserProfile("John", "JonhDeMark@gmail.com");
        Console.WriteLine($"Username: {user.Username}");
        Console.WriteLine($"Email: {user.Email}");
        Console.WriteLine($"Created At: {user.CreatedAt}");
    }
}

struct UserProfile
{
    public string Username { get; }
    public string Email { get; }
    public DateTime CreatedAt { get; }

    public UserProfile(string username, string email)
    {
        Username = username;
        Email = email;
        CreatedAt = DateTime.Now;
    }
}