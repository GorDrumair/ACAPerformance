using System;

namespace AlarmClockSnooze;

class Program
{
    static void Main(string[] args)
    {
        string? alarmSnooze;
        do
        {
            Console.WriteLine("Snoozing for 5 more minutes...");
            System.Threading.Thread.Sleep(5000);

            Console.Write("Do you want to snooze the alarm? (Y/N): ");
            alarmSnooze = Console.ReadLine().ToUpper();
        }
        while (alarmSnooze == "Y");
    }
}