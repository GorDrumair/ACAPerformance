using System;
using System.Text;

namespace WorkShiftSheduler;

class Program
{
    static void Main()
    {
        StringBuilder stringBuilder = new StringBuilder();

        Console.WriteLine("Factory Shift Scheduler");

        Console.Write("Enter you name: ");
        string? emplyeeName = Console.ReadLine();
        Console.Write("Enter yor dey of week: ");
        int daysOfWeek = Convert.ToInt32(Console.ReadLine());
        Console.Write("Your shift stats at: ");
        int shiftStarts = Convert.ToInt32(Console.ReadLine());
        Console.Write("Your shift ends at: ");
        int shiftEnds = Convert.ToInt32(Console.ReadLine());

        stringBuilder.Append($"Emplyee: {emplyeeName}\n");

        if (daysOfWeek <= 7 && daysOfWeek > 0)
        {
            stringBuilder.Append($"Days of week: {daysOfWeek}\n");
            if (shiftEnds - shiftStarts <= 12)
            {
                if (shiftStarts >= 8 || shiftEnds <= 16)
                {
                    stringBuilder.Append($"Shift: Morning\nShift Time: {shiftEnds - shiftStarts}");
                }
                else if (shiftStarts >= 16 || shiftEnds <= 24)
                {
                    stringBuilder.Append($"Shift: Afternoon\nShift Time: {shiftEnds - shiftStarts}");
                }
                else if (shiftStarts >= 0 || shiftEnds <= 8)
                {
                    stringBuilder.Append($"Shift: Night\nShift Time: {shiftEnds - shiftStarts}");
                }
            }
            else
            {
                Console.WriteLine("Emplyee shift is longer then 12 hours.");
            }
        }
        else
        {
            Console.WriteLine("Days of week is out of range.");
        }

        Console.WriteLine(stringBuilder);
    }
}