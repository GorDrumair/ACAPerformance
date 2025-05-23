using System;

namespace FallbackUsername;

class Program
{
    static void Main()
    {
        Console.Write("Enter preferred name: ");
        string? preferredName = Console.ReadLine();
        Console.Write("Enter nickname: ");
        string? nickname = Console.ReadLine();
        Console.Write("Enter username: ");
        string? username = Console.ReadLine();

        Console.WriteLine($"Prefered Name: {preferredName}");
        Console.WriteLine($"Nickname: {nickname}");
        Console.WriteLine($"Username: {username}");
    }
}