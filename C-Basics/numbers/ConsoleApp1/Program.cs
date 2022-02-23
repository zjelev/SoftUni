using System;

namespace Zad_11_Salabashev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the start integer: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Input the end integer: ");
            int end = int.Parse(Console.ReadLine());
            Console.Write("We look for an integer with number of divisors exactly: ");
            int del = int.Parse(Console.ReadLine());
            int num = 0;
            for (int i = start; i <= end; i++)
            {
                for (int c = 1; c <= i; c++)
                {
                    if (i % c == 0)
                    {
                        //Console.WriteLine(i);
                        num++;
                    }
                }
                if (num==del)
                {
                    Console.WriteLine("Number with {0} divisors found: {1}", del, i);
                }
                num = 0;
            }
        }
    }
}
