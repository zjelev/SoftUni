﻿using System;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                Console.Write("Enter even number: ");
                n = int.Parse(Console.ReadLine());
                if (n%2==0)
                {
                    break;
                }
                Console.WriteLine("The number is not even.");
            }
            Console.WriteLine("Even number entered: " + n);
        }
    }
}