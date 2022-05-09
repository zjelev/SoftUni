using System;

namespace DefiningClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            double res = DateModifier
                .DayDiff(
                    Console.ReadLine()
                    ,Console.ReadLine()
                );
            Console.WriteLine(res);
        }
    }
}