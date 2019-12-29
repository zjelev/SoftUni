using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = budget * 0.9;
            string location = "";
            string accomodation = "Hotel";

            if (season == "Summer")
            {
                location = "Alaska";
            }
            else if (season == "Winter")
            {
                location = "Morocco";
            }

            if (budget <= 1000)
            {
                accomodation = "Camp";
                if (season == "Summer")
                {
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    price = budget * 0.45;
                }
            }
            else if (budget <= 3000)
            {
                accomodation = "hut";
                if (season == "Summer")
                {
                    price = budget * 0.8;
                }
                else if (season == "Winter")
                {
                    price = budget * 0.6;
                }
            }

            Console.WriteLine($"{location} – {accomodation} – {price:f2}");
        }
    }
}
