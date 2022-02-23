//https://judge.softuni.bg/Contests/Practice/Index/1381#3

using System;

namespace _04._Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            byte z = byte.Parse(Console.ReadLine());
            for (byte i = a; i <= z; i++)
            {
                for (byte j = a; j <= z; j++)
                {
                    for (byte k = a; k <= z; k++)
                    {
                        for (byte l = a; l < i; l++)
                        {
                            if ((j + k) % 2 == 0)
                            {
                                if ((i % 2 == 0 && l % 2 == 1) || (i % 2 == 1 && l % 2 == 0))
                                {
                                    Console.Write("" + i + j + k + l + " ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}