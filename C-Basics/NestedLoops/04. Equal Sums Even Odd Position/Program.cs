using System;

namespace _04._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                int currentNum = i;
                int evenDigitsSum = 0;
                int oddDigitsSum = 0;
                while (currentNum > 0)
                {
                    int currentDigit = currentNum % 10;
                    evenDigitsSum += currentDigit;
                    currentNum /= 10;
                    currentDigit = currentNum % 10;
                    oddDigitsSum += currentDigit;
                    currentNum /= 10;
                }

                if (evenDigitsSum == oddDigitsSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
