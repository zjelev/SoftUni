﻿using System;

namespace _04_Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < lenght; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine(sum);
        }
    }
}
