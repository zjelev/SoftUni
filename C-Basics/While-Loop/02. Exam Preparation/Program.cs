using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGradesLimit = int.Parse(Console.ReadLine());

            string task = "";
            string previousTask = "";
            int badGradesCount = 0;
            int gradesCount = 0;
            int gradesSum = 0;

            while (badGradesCount < badGradesLimit)
            {
                task = Console.ReadLine();
                
                if (task == "Enough")
                {
                    Console.WriteLine($"Average score: {gradesSum / (double)gradesCount}");
                    Console.WriteLine($"Number of problems: {gradesCount}");
                    Console.WriteLine($"Last problem: {previousTask}"); 
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                gradesCount++;

                if (grade <= 4)
                {
                    badGradesCount++;
                }

                gradesSum += grade;
                previousTask = task;
            }

            if (badGradesCount >= badGradesLimit)
            {
                Console.WriteLine($"You need a break, {badGradesLimit} poor grades.");
            }
        }
    }
}
