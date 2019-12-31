//https://judge.softuni.bg/Contests/Practice/Index/1165#6

using System;

namespace _07._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string title = "";
            decimal gradeSumTotal = 0;
            int numStudentsGrades = 0;
            while ((title = Console.ReadLine()) != "Finish")
            {
                decimal gradeSum = 0;
                for (int i = 0; i < n; i++)
                {
                    decimal grade = decimal.Parse(Console.ReadLine());
                    gradeSum += grade;
                    numStudentsGrades++;
                }
                Console.WriteLine($"{title} - {gradeSum / n :f2}.");
                gradeSumTotal += gradeSum;
                
            }
            Console.WriteLine($"Student's final assessment is {gradeSumTotal / numStudentsGrades:f2}.");
        }
    }
}