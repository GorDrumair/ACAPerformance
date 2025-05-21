using System;

namespace PracticeProgram;

class Program
{
    static void Main(string[] args)
    {
        int alarmDaysInWeek = 0;
        for (int i = 1; i <= 7; i++)
        {
            Console.Write($"Is turn on alarm in day {i}? (true/false): ");
            bool isTurnOnAlarm = bool.Parse(Console.ReadLine()!);
            if (isTurnOnAlarm)
            {
                alarmDaysInWeek = Convert.ToInt32(Math.Pow(2, i - 1) + alarmDaysInWeek);
            }
        }
        Console.WriteLine($"\n{alarmDaysInWeek}");
        Console.WriteLine(Convert.ToString(alarmDaysInWeek, 2));
    }
}