//https://judge.softuni.bg/Contests/Practice/Index/1381#6

using System;

namespace _07._Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            char A = (char)35;
            char B = (char)64;

            for (int x = 1; x <= a && max > 0; x++)
            {
                for (int y = 1; y <= b && max > 0; y++)
                {
                    Console.Write("" + A + B + x + y + B + A + "|");
                    A++;
                    B++;
                    max--;
                    if (A == (char)56)
                    {
                        A = (char)35;
                    }
                    if (B == (char)97)
                    {
                        B = (char)64;
                    }
                }
            }
        }
    }
}