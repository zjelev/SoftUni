//https://judge.softuni.bg/Contests/Practice/Index/1596#2

using System;

namespace Scholarship
{
    class OscarsWeekInCinema
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double gradeScholarship = Math.Floor(averageGrade * 25);
            double socialScholarship = Math.Floor(minSalary * 0.35);

            if (averageGrade < 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (averageGrade < 5.5)
            {
                if (income < minSalary)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            else
            {
                if (income >= minSalary)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {gradeScholarship} BGN");
                }
                else
                {
                    if (gradeScholarship <= socialScholarship)
                    {
                        Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {gradeScholarship} BGN");
                    }
                }

            } 
        }
    }
}
