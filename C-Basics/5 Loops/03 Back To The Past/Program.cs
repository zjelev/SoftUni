using System;

namespace _03_Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int toYear = int.Parse(Console.ReadLine());
            int spentEven = 0, spentOdd = 0;
            for (int i = 0; i <= (toYear-1800); i++)
            {
                if (i%2 == 0)
                {
                    spentEven += 12000;
                }
                else
                {
                    spentOdd += 12000 + 50 * (i + 18);
                }
            }
            Console.WriteLine(spentOdd+spentEven <= heritage ? $"Yes! He will live a carefree life and will have {heritage - spentEven - spentOdd:0.00} dollars left." 
                : $"He will need {spentEven+spentOdd-heritage:0.00} dollars to survive.");
        }
    }
}