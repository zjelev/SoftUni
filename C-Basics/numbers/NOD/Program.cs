using System;

namespace NOD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete dvete chisla: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxOD = 0;
            int max = Math.Max(a, b);
            for (int i = 2; i <= max; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Console.WriteLine("OD found: " + i);
                    if (i > maxOD)
                    {
                        maxOD = i;
                    }
                }
            }
            Console.WriteLine("NOD na " + a + " i " + b + " e " + maxOD);
        }
    }
}