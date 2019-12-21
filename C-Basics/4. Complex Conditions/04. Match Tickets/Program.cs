//https://judge.softuni.bg/Contests/Practice/Index/509#3
using System;

namespace _04._Match_Tickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string cat = Console.ReadLine();
            byte group = byte.Parse(Console.ReadLine());

            decimal transport = budget / 4;

            if (group < 4)
            {
                transport = budget * 0.75m;
            }
            else if (group < 10)
            {
                transport = budget * 0.6m;
            }
            else if (group < 25)
            {
                transport = budget / 2;
            }
            else if (group < 50)
            {
                transport = budget * 0.4m;
            }
            
            decimal priceOfTickets = 0;
            if (cat == "VIP")
            {
                priceOfTickets = group * 499.99m;
            }
            else if (cat == "Normal")
            {
                priceOfTickets = group * 249.99m;
            }

            string output = string.Empty;

            if (priceOfTickets > budget - transport)
            {
                output = string.Format("Not enough money! You need {0:f2} leva.",
                    priceOfTickets - budget + transport);
            }
            else
            {
                output = string.Format("Yes! You have {0:} leva left.", 
                    budget - transport - priceOfTickets);
            }
            Console.WriteLine(output);
        }
    }
}
