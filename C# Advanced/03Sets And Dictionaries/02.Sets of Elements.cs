using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var first = new HashSet<string>();

            for (int i = 0; i < int.Parse(input[0]); i++)
            {
                first.Add(Console.ReadLine());
            }

            var second = new HashSet<string>();

            for (int i = 0; i < int.Parse(input[1]); i++)
            {
                second.Add(Console.ReadLine());
            }

            first.IntersectWith(second);

            foreach (var item in first)
            {
                Console.Write($"{item} ");
            }
        }
    }
}