using System;

namespace _02._Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beers = int.Parse(Console.ReadLine());
            int chips = int.Parse(Console.ReadLine());

            double totalBeerPrice = beers * 1.20;
            double chipsPrice = totalBeerPrice * 0.45;
            double totalChipsPrice = Math.Ceiling(chips * chipsPrice);

            double totalSum = totalBeerPrice + totalChipsPrice;

            double diff = Math.Abs(totalSum - budget);

            if (totalSum <= budget)
            {
                Console.WriteLine($"{name} bought a snack and has {diff:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {diff:f2} more leva!");
            }

        }
    }
}
