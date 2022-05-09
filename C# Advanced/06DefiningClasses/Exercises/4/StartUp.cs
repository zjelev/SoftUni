using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person member = new Person(input[0], int.Parse(input[1]));
                people.Add(member);
            }

            people = people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }
}
