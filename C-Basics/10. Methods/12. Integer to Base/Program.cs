using System;

namespace _12.Integer_to_Base
{
    class Program
    {
        static string IntegerToBase(int number, int toBase)
        {
            string result = "";
            int remainder = 0;
            while (number != 0)
            {
                remainder = number % toBase;
                result = remainder + result;
                number = number / toBase;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(number, toBase));
        }
    }
}
