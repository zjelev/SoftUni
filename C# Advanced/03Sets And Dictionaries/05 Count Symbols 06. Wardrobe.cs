//05 Count symbols
using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

           var symbolCount = new SortedDictionary<char, int>();

           char[] token = input.ToCharArray();

            for (int i = 0; i < token.Length; i++)
            {
                if (!symbolCount.ContainsKey(token[i]))
                {
                    symbolCount.Add(token[i], 1);
                }
                else
                {
                    symbolCount[token[i]]++;
                }
            }

            foreach (var symbol in symbolCount)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}

//06. Wardrobe
using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
           int lines = int.Parse(Console.ReadLine());

           var wardrobe = new Dictionary<string, Dictionary<string, int>>();

           for (int i = 0; i < lines; i++)
           {
                string input = Console.ReadLine();
                string[] color = input.Split(" -> ");
                string[] clothes = color[1].Split(",");
                
                if (!wardrobe.ContainsKey(color[0]))
                {
                        wardrobe.Add(color[0], new Dictionary<string, int>());  
                }
                foreach (var cloth in clothes)
                {
                    if (!wardrobe[color[0]].ContainsKey(cloth))
                    {
                        wardrobe[color[0]].Add(cloth, 1);
                    }
                    else
                    {
                        wardrobe[color[0]][cloth]++;
                    }
                } 
           }

           string[] colorCloth = Console.ReadLine().Split(" ");

           foreach (var color in wardrobe)
           {
               Console.WriteLine($"{color.Key} clothes:");

               foreach (var cloth in color.Value)
               {
                   Console.Write($"* {cloth.Key} - {cloth.Value}");
                   if ((color.Key == colorCloth[0]) && (cloth.Key == colorCloth[1]))
                   {
                       Console.Write(" (found!) ");
                   }
                   Console.WriteLine();
               }
           }
           /*
           foreach ((string color, Dictionary<string, int> clothes) in wardrobe)
           {
               Console.WriteLine($"{color} clothes:");

               foreach ((string cloth, int count) in clothes)
               {
                   Console.Write($"* {cloth} - {count}");
                   if ((color == colorCloth[0]) && (cloth == colorCloth[1]))
                   {
                       Console.Write(" (found!) ");
                   }
                   Console.WriteLine();
               }
           }
           */
        }
    }
}