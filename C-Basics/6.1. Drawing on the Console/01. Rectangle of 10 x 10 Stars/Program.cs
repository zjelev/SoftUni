using System;

namespace _01._Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 1; i++)
            {
                Console.Write("+");
                for (int c = 0; c < n-2; c++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");
            }
            for (int i = 1; i < n-1; i++)
            {
                Console.Write("|");
                for (int c = 0; c < n - 2; c++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            for (int i = n-1; i < n; i++)
            {
                Console.Write("+");
                for (int c = 0; c < n - 2; c++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");
            }
        }
    }
}