//https://judge.softuni.bg/Contests/Practice/Index/1382#3

using System;

namespace _04._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            decimal sumTotal = 0;
            for (int i = 1; i <= days; i++)
            {
                decimal sum = 0;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 == 1)
                    {
                        sum += 2.5m;
                    }
                    else if (i % 2 == 1 && j % 2 == 0)
                    {
                        sum += 1.25m;
                    }
                    else
                    {
                        sum += 1;
                    }
                }
                Console.WriteLine($"Day: {i} - {sum:f2} leva");
                sumTotal += sum;
            }
            Console.WriteLine($"Total: {sumTotal:f2} leva");
        }
    }
}
