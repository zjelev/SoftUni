using System;

namespace _01._Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int colSize = n / 2;
            int midSize = 2 * n - 2 * colSize - 4;
            //top
            Console.Write('/');
            for (int i = 0; i < n/2; i++)
            {
                Console.Write('^');
            }
            Console.Write('\\');
            Console.Write(new string('_', midSize));
            Console.Write('/');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('^');
            }
            Console.WriteLine('\\');
            //middle
            for (int i = 0; i < n - 3; i++)
            {
                Console.Write('|');
                for (int c = 0; c < 2*n-2; c++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('|');
            }
            //last middle line
            Console.Write('|');
            for (int c = 0; c <= n/2; c++)
            {
                Console.Write(' ');
            }
            Console.Write(new string('_', midSize));
            for (int c = 0; c <= n / 2; c++)
            {
                Console.Write(' ');
            }
            Console.WriteLine('|');
            //bottom
            Console.Write('\\');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('_');
            }
            Console.Write('/');
            Console.Write(new string(' ', midSize));
            Console.Write('\\');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('_');
            }
            Console.WriteLine('/');
        }
    }
}