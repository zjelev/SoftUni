using System;

namespace _09_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1: Console.Write("Mon"); break;
                case 2: Console.Write("Tues"); break;
                case 3: Console.Write("Wednes"); break;
                case 4: Console.Write("Thurs"); break;
                case 5: Console.Write("Fri"); break;
                case 6: Console.Write("Satur"); break;
                case 7: Console.Write("Sun"); break;
                default: Console.WriteLine("Error!"); break;
            }
            if (day >= 1 && day <= 7)
            {
                Console.WriteLine("day");
            }
        }
    }
}