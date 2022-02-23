//https://judge.softuni.bg/Contests/Practice/Index/1165#3

using System;

namespace _04._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            for (int i = a; i <= z; i++)
            {
                int currentNum = i;
                int oddDigitSum = 0;
                int evenDigitSum = 0;
                while (currentNum > 0)
                {
                    int evenDigit = currentNum % 10;
                    evenDigitSum += evenDigit;
                    currentNum /= 10;
                    int oddDigit = currentNum % 10;
                    oddDigitSum += oddDigit;
                    currentNum /= 10;
                }
                if (evenDigitSum == oddDigitSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}