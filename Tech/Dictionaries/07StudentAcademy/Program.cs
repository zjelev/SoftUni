using System;
using System.Collections.Generic;
using System.Linq;

namespace _07StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(student))
                {
                    studentGrades[student] = new List<double>();
                }

                studentGrades[student].Add(grade);
            }

            Console.WriteLine(string.Join(Environment.NewLine, studentGrades
            .Where(x => x.Value.Average() >= 4.50)
            .OrderByDescending(x => x.Value.Average())
            .Select(x => $"{x.Key} -> {x.Value.Average():f2}")));
        }
    }
}
