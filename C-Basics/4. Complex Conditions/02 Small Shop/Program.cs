using System;

namespace _02_Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var prod = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var qty = decimal.Parse(Console.ReadLine());
            if (prod == "coffee")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(qty * 0.5m);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(qty * 0.4m);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(qty * 0.45m);
                }
            }
            else if (prod == "water")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(qty * 0.8m);
                }
                else if (town == "plovdiv" || town == "varna")
                {
                    Console.WriteLine(qty * 0.7m);
                }
            }
            else if (prod == "beer")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(qty * 1.2m);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(qty * 1.15m);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(qty * 1.1m);
                }
            }
            else if (prod == "sweets")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(qty * 1.45m);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(qty * 1.3m);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(qty * 1.35m);
                }
            }
            else if (prod == "peanuts")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(qty * 1.6m);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(qty * 1.5m);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(qty * 1.55m);
                }
            }
        }
    }
}