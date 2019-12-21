using System;

namespace _02.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal spent = budget * 0.7m;
            string season = Console.ReadLine();
            string destination = "Bulgaria";
            string accomodation = "Hotel";
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    spent = budget * 0.3m;
                    accomodation = "Camp";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spent = budget * 0.4m;
                    accomodation = "Camp";
                }
                else if (season == "winter")
                {
                    spent = budget * 0.8m;
                }
            }
            else
            {
                destination = "Europe";
                spent = budget * 0.9m;
            }
            Console.WriteLine("Somewhere in " + destination);
            Console.WriteLine("{0} - {1:0.00}", accomodation, spent);
        }
    }
}