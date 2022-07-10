using System;

namespace Primes
{
    public class Swap
    {
        public static void SwapNumber(int number)
        {
            int lastDigit = number % 10;
            Console.WriteLine($"Last digit is {lastDigit}");
            int temp = number;
            int firstDigit;
            int numberOfDigits = 1;
            
            while (temp > 10)
            {
                temp = temp / 10;
                numberOfDigits++;
            }
            firstDigit = temp % 10;
            
            // Console.WriteLine($"First digit is: {firstDigit}");
            // Console.WriteLine($"Digits are {numberOfDigits}");

            int middleNumber = number - firstDigit * (int)Math.Pow(10, numberOfDigits-1) - lastDigit;
            //Console.WriteLine(middleNumber);

            int reversedFirstLast = lastDigit * (int)Math.Pow(10, numberOfDigits-1) + middleNumber + firstDigit;

            Console.WriteLine($"Reversed last and first digits: {reversedFirstLast}");
        }
    }
}