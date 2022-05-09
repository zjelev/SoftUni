using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            var elements = new SortedSet<string>();

            for (int i = 0; i < lines; i++)
            {
                var line = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < line.Length; j++)
                {
                    elements.Add(line[j]);
                }
            }

            foreach (var element in elements)
            {
                Console.Write($"{element} ");
            }
        }
    }
}