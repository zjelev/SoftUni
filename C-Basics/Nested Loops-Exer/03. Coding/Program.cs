using System;

namespace _03.Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                int currentDigit = n % 10;
                n /= 10;
                
                for (int i = 0; i < currentDigit; i++)
                {
                    Console.Write((char)(currentDigit + 33));
                }
                if (currentDigit == 0)
                {
                    Console.WriteLine("ZERO");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            
        }
    }
}
