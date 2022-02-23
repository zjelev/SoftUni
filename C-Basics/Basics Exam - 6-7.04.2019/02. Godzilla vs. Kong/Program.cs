//https://judge.softuni.bg/Contests/Practice/Index/1596#1

using System;

namespace _02.Godzilla_vs.Kong
{
    class GodzillaVsKong
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            decimal clothing = decimal.Parse(Console.ReadLine());
            decimal decor = budget * 0.1m;
            decimal totalClothing = statists * clothing;
            if (statists > 150)
            {
                totalClothing = totalClothing * 0.9m;
            }
            if (totalClothing + decor > budget)
            {
                Console.WriteLine("Not enough money!" +
                    "\nWingard needs " + 
                    $"{totalClothing + decor - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!" + 
                    "\nWingard starts filming with " + 
                    $"{budget - totalClothing - decor:f2} leva left.");
            }
        }
    }
}