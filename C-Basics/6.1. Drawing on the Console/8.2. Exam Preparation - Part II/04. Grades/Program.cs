using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double fail = 0, average = 0, good = 0, top = 0;
            double numFail = 0, numAverage = 0, numGood = 0, numTop = 0;
            for (int i = 0; i < n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 2.0 && grade < 3.0)
                {
                    fail += grade;
                    numFail++;
                }
                if (grade >=3.0 && grade < 4.0)
                {
                    average += grade;
                    numAverage++;
                }
                if (grade >= 4.0 && grade < 5.0)
                {
                    good += grade;
                    numGood++;
                }
                if (grade >= 5.0)
                {
                    top += grade;
                    numTop++;
                }
            }
            Console.WriteLine("Top students: {0:f2}%", numTop / n * 100.0);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", numGood / n * 100.0);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", numAverage / n * 100.0);
            Console.WriteLine("Fail: {0:f2}", numFail / n * 100.0);
            Console.WriteLine("Average: {0:f2}", (fail+average+good+top) / n);
        }
    }
}