using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            /*
            double[] input = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

            Dictionary<double, int> counter = new Dictionary<double, int>();
            foreach (var number in input)
            {
                if (counter.ContainsKey(number))
                {
                    counter[number]++;
                }
                else
                {
                    counter[number] = 1;
                }
            }

            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
            */
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
             
            int numberOfRecords = int.Parse(Console.ReadLine());
            var grades = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (grades.ContainsKey(tokens[0]))
                {
                    grades[tokens[0]].Add(decimal.Parse(tokens[1]));
                }
                else
                {
                    grades.Add(tokens[0], new List<decimal>() { decimal.Parse(tokens[1])});
                }
                
            }
             foreach (var item in grades)
             {
                Console.WriteLine($"{item.Key} -> {string.Join(' ', item.Value.Select(x => x.ToString("F2")))} (avg: {item.Value.Average():f2})");
             }
             
             //grades["Peter"] = new List<int>();
             //grades["Peter"].Add(5);
        }
    }
}
