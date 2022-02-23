using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string carClass = "Luxury class";
            string carType = "Jeep";
            double price = budget * 0.9;

            if (budget <= 100)
            {
                carClass = "Economy class";

                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.35;
                }
                else
                {
                    price = budget * 0.65;
                }
            }
            else if (budget <= 500)
            {
                carClass = "Compact class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.45;
                }
                else
                {
                    price = budget * 0.8;
                }
            }

            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {price:f2}");
        }
    }
}
