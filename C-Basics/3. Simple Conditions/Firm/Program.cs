using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectHours = int.Parse(Console.ReadLine());
            var availableDays = int.Parse(Console.ReadLine());
            var overtimeWorkers = int.Parse(Console.ReadLine());
            var workDays = availableDays * 0.9m;
            var overtime = overtimeWorkers * 2 * workDays;
            var workHours = Math.Floor(overtimeWorkers * workDays * 8 + overtime);
            //var workHours = Math.Floor(availableDays * 0.9m * 8 + overtimeWorkers * 2 * availableDays * 0.9m);
            if (workHours >= projectHours)
            {
                Console.WriteLine("Yes!{0} hours left.", workHours - projectHours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", projectHours - workHours);
            }
        }
    }
}