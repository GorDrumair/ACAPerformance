
using System;

namespace TestHomework;

class Program
{
    static void Main()
    {
        string firstWeek =
        "01111111" +            // 1
        "00000000" +            // 2
        "00000000" +            // 3
        "00000000" +            // 4
        "00000000" +            // 5
        "00000000" +            // 6
        "00000000";             // 7

        string secondWeek =
        "00000000" +            // 8
        "00000000" +            // 9
        "00000000" +            // 10
        "00000000" +            // 11
        "00000000" +            // 12
        "00000000" +            // 13
        "00000000";             // 14

        string thirdWeek =
        "00000000" +            // 15
        "00000000" +            // 16
        "00000000" +            // 17
        "00000000" +            // 18
        "00000000" +            // 19
        "00000000" +            // 20
        "00000000";             // 21

        string fourtWeek =
        "00000000" +            // 22
        "00000000" +            // 23
        "00000000" +            // 24
        "00000000" +            // 25
        "00000000" +            // 26
        "00000000" +            // 27
        "00000000";             // 28

        string fivthWeek =
        "00000000" +            // 29
        "00000000" +            // 30
        "00000000";             // 31

        string month = firstWeek + secondWeek + thirdWeek + fourtWeek + fivthWeek;

        int hourCounter = 0;
        int dayCounter = 1;
        string dayString = "";
        int lastDay = 0;
        int lastHour = 0;


        for (int i = 0; i < month.Length; i++)
        {
            if (hourCounter == 8)
            {
                dayCounter++;
                hourCounter = 0;
                dayString = "";
            }
            hourCounter++;
            dayString += month[i];
            if (month[i] == '1')
            {
                lastDay = dayCounter;
                lastHour = dayString.Length;
            }
        }

        Console.WriteLine($"Your next free time is {lastDay} this month in at {lastHour} o'clock.");
    }
}