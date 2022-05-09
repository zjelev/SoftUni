using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncProg
{
    class Program
    {
        static void Main(string[] args)
        {
            //4
            /* 
            Predicate<string> isFirstLetterCapital =
                str => str[0] == str.ToUpper()[0];

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => isFirstLetterCapital(x))
                .ToList()
                .ForEach(x => Console.WriteLine(x));
            
            //5
            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => 
                {
                    decimal num = decimal.Parse(x);
                    return num * 1.2M;
                })
                .ToList()
                .ForEach(x => Console.WriteLine($"{x:f2}"));
            //6
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> peopleAge = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                
                if (!peopleAge.ContainsKey(input[0]))
                {
                    peopleAge.Add(input[0], int.Parse(input[1]));
                }
              
                peopleAge[input[0]] = int.Parse(input[1]);
            }

            Func<int, bool> tester = CreateTester(condition, age);

            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);

            PrintFilteredStudent(peopleAge, tester, printer);
        */
        PrintLine(5);

        Action<int> print = i => Console.WriteLine(i);

        print(5);
        }
        static void PrintLine(int n)
            {
                Console.WriteLine(n);
            }

        public static Func<int, bool> CreateTester(string condition, int age)
            {
                switch(condition)
                {
                    case "younger": return x => x < age;
                    case "older": return x => x >= age;
                    default: return null;
                }
            }

        public static Action<KeyValuePair<string, int>> CreatePrinter(string format) 
        {
            switch (format)
            {
                case "name": return person => Console.WriteLine($"{person.Key}");
                case "age": return person => Console.WriteLine($"{person.Value}");
                default: return null;
            }   
        }
    }
}
