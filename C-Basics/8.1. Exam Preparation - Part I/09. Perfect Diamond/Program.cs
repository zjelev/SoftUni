using System;

namespace _09.Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - i - 1));
                Console.Write("*");
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
            //down
            for (int i = n; i > 1; i--)
            {
                Console.Write(new string(' ', n - i + 1));
                Console.Write("*");
                for (int j = i-2; j > 0; j--)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}