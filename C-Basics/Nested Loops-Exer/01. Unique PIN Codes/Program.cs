//https://judge.softuni.bg/Contests/Practice/Index/1381#0

using System;

namespace _01.Unique_PIN_Codes
{
    class Program
    {
        static void NestedLoop(int i, int m, int n)
        {
        for (int j = 2; j <= m; j++)
                {
                    for (int k = 2; k <= n; k++)
                    {
                        if (j % k == 0 && j > 2)
                        {
                        return; 
                        }
                        else if (k % 2 == 0)
                        {
                            Console.WriteLine("" + i + " " + j + " " + k);
                        }
                    }
                }
        }

        static void Main(string[] args)
        {
            byte l = byte.Parse(Console.ReadLine());
            byte m = byte.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());

            for (int i = 2; i <= l; i += 2)
            {
                NestedLoop(i, m, n);
            }
        }
    }
}