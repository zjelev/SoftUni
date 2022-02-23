using System;

namespace _05._Invalid_Number
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool inRange = (n >= 100 && n <= 200) || n == 0;
            if (!inRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}