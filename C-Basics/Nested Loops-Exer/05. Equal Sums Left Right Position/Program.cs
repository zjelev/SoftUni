//https://judge.softuni.bg/Contests/Practice/Index/1165#4

using System;

namespace _05._Equal_Sums_Left_Right_Position
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
                int rightSum = 0;
                
                for (int j = 0; j < 2; j++)
                {
                    int rightDigit = currentNum % 10;
                    rightSum += rightDigit;
                    currentNum /= 10;
                }
                int middleDigit = currentNum % 10;
                int leftSum = 0;
                while (currentNum > 0)
                {
                    currentNum /= 10;
                    int leftDigit = currentNum % 10;
                    leftSum += leftDigit;
                }
                if (leftSum == rightSum)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    if (Math.Min(leftSum, rightSum) + middleDigit == Math.Max(leftSum, rightSum))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}