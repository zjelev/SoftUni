//https://judge.softuni.bg/Contests/Practice/Index/509#0
using System;

namespace _01._On_Time_for_the_Exam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            byte examHour = byte.Parse(Console.ReadLine());
            byte examMin = byte.Parse(Console.ReadLine());
            byte arrivalHour = byte.Parse(Console.ReadLine());
            byte arrivalMin = byte.Parse(Console.ReadLine());
            int examTime = examHour * 60 + examMin;
            int arrivalTime = arrivalHour * 60 + arrivalMin;
            int diffMin = examTime - arrivalTime;
            string onTime = "Early";
            string result = string.Empty;
            if (diffMin < 0)
            {
                onTime = "Late";
            }
            else if (diffMin <= 30)
            {
                onTime = "On time";
            }
            if (diffMin >= 60)
            {
                result = string.Format("{0}:{1:00} hours before the start" , diffMin / 60, diffMin % 60);
            }
            else if (diffMin > 0)
            {
                result = string.Format("{0} minutes before the start", diffMin);
            }
            else if (diffMin <= -60)
            {
                result = string.Format("{0}:{1:00} hours after the start", -diffMin / 60, -diffMin % 60);
            }
            else if (diffMin < 0)
            {
                result = string.Format("{0} minutes after the start",  -diffMin);
            }
            Console.WriteLine(onTime);
            Console.WriteLine(result);
        }
    }
}