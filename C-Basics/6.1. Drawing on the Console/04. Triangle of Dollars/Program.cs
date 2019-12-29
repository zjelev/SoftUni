using System;

namespace _04._Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("$");
                for (int k = 1; k < i; k++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}