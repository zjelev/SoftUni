using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double sumPerKm = 0;

            if (kmPerMonth <= 5000)
            {
                if (season == "Summer")
                {
                    sumPerKm = 0.9;
                }
                else if (season == "Winter")
                {
                    sumPerKm = 1.05;
                }
                else
                {
                    sumPerKm = 0.75;
                }
            }
            else if (kmPerMonth <= 10000)
            {
                if(season == "Summer")
                {
                    sumPerKm = 1.1;
                }
                else if (season == "Winter")
                {
                    sumPerKm = 1.25;
                }
                else
                {
                    sumPerKm = 0.95;
                }
            }
            else if (kmPerMonth <= 20000)
            {
                sumPerKm = 1.45;
            }

            double totalSum = 0.9 * (sumPerKm * kmPerMonth * 4);
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
