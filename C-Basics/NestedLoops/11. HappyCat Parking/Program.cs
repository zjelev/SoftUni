using System;

namespace _11._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDays = int.Parse(Console.ReadLine());
            int hoursPerDay = int.Parse(Console.ReadLine());

            double totalSum = 0;

            for (int day = 1; day <= totalDays; day++)
            {
                double sum = 0;
                for (int hour = 1; hour <= hoursPerDay; hour++)
                {
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        sum += 2.5;
                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        sum += 1.25;
                    }
                    else
                    {
                        sum += 1.0;
                    }
                }
                Console.WriteLine($"Day: {day} - {sum:f2} leva");
                totalSum += sum;
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
