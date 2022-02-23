using System;

namespace _11.Nth_Digit
{
    class Program
    {
        static int FindNthDigit(int number, int index)
        {
            int i = 1;
            while (number != 0)
            {
                if (i == index)
                {
                    return number % 10;
                }
                number = number / 10;
                i++;
            }
            return 0;
        }
        
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number, index));
        }
    }
}