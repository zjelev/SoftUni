using System;

namespace _01._Christmas_Sweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double baklavaPrice = double.Parse(Console.ReadLine());
            double muffinPrice = double.Parse(Console.ReadLine());
            double shtolenKg = double.Parse(Console.ReadLine());
            double sweetsKg = double.Parse(Console.ReadLine());
            double biscuitsKg = double.Parse(Console.ReadLine());

            double shtolenPrice = baklavaPrice * 1.6;
            double sweetsPrice = muffinPrice * 1.8;
            double biscuitsPrice = 7.5;

            double totalSum = shtolenKg * shtolenPrice + sweetsKg * sweetsPrice + biscuitsKg * biscuitsPrice;

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
