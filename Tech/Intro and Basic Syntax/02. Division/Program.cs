﻿using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (a % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (a % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (a % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 32");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
