using System;

namespace _06._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n - row-1; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 0; i < row; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int row = n - 2; row >= 0; row--)
            {
                for (int col = n - row-1; col > 0; col--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = row; i > 0; i--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
