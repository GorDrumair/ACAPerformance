using System;

namespace DayScheduleSystem;

class Program
{
    static void Main(string[] args)
    {
        DaySchedule mondaySchedule = new DaySchedule(WeekDays.Monday, "Complete project.");
        DaySchedule tuesdaySchedule = new DaySchedule(WeekDays.Tuesday, "Meet with Friends.");
        DaySchedule fridaySchedule = new DaySchedule(WeekDays.Friday, "Drink, Smoke, Chill.");

        mondaySchedule.DisplaySchedule(WeekDays.Monday);
        tuesdaySchedule.DisplaySchedule(WeekDays.Tuesday);
        fridaySchedule.DisplaySchedule(WeekDays.Friday);
    }
}

struct DaySchedule
{
    public WeekDays Day { get; set; }
    public string Tasks { get; set; }

    public DaySchedule(WeekDays day, string tasks)
    {
        Day = day;
        Tasks = tasks;
    }

    public void DisplaySchedule(WeekDays day)
    {
        Console.WriteLine($"Schedule for {day}: {Tasks}");
    }
}

enum WeekDays : int
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}