//https://judge.softuni.bg/Contests/Practice/Index/1165#8

using System;

namespace _09._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte l = byte.Parse(Console.ReadLine());
            for (byte i = 1; i < n; i++)
            {
                for (byte j = 1; j < n; j++)
                {
                    for (char c = 'a';  c < 97 + l ; c++)
                    {
                        for (char d = 'a'; d < 97 + l; d++)
                        {
                            for (byte k = Math.Max(i, j); k < n; k++)
                            {
                                Console.Write("" + i + j + c + d + (k+1) + " ");
                            }
                        }
                    }
                }
            }
        }
    }
}