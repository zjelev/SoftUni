//https://judge.softuni.bg/Contests/Practice/Index/1103#0

using System;

namespace _01._Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal food = decimal.Parse(Console.ReadLine());
            decimal souvenirs = decimal.Parse(Console.ReadLine());
            decimal hotel = decimal.Parse(Console.ReadLine());

            decimal moneyNeeded = 420 / 100m * 7 * 1.85m + (food + souvenirs) * 3 + hotel * (0.9m + 0.85m + 0.8m);
            Console.WriteLine($"Money needed: {moneyNeeded:f2}");
        }
    }
}
