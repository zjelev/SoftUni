using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
             
            var shops = new SortedDictionary<string, Dictionary<string, decimal>>();
            string input = string.Empty;
            
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (!shops.ContainsKey(tokens[0]))
                {
                    shops[tokens[0]] = new Dictionary<string, decimal>();
                }

                shops[tokens[0]].Add(tokens[1], decimal.Parse(tokens[2]));
            }

            foreach (var shop in shops)
            {
                System.Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    System.Console.WriteLine($"Product: {product.Key}, Price: {(double)product.Value}");
                }
            }
        }
    }
}