﻿using System;

namespace _01.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int k = c; k <= d; k++)
                    {
                        for (int l = c; l <= d; l++)
                        {
                            if (i + l == j + k)
                            {
                                if (k != l || i != j)
                                {
                                    Console.WriteLine($"{i}{j}");
                                    Console.WriteLine($"{k}{l}");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
