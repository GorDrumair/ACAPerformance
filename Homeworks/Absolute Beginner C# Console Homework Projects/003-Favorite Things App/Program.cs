using System;

namespace FavoriteThingsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favorite Things App\n");

            Console.Write("Enter your favorite color: ");
            string? color = Console.ReadLine();

            Console.Write("Enter your favorite food: ");
            string? food = Console.ReadLine();

            Console.Write("Enter your favorite movie: ");
            string? movie = Console.ReadLine();

            Console.WriteLine($"\nYour favorite color is {color}, your favorite food is {food}, and your favorite movie is {movie}.\n");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}