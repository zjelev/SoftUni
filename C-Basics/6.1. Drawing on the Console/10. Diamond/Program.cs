using System;

namespace _10._Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRight = (n - 1) / 2;
            for (int i = 0; i < (n-1)/2+1; i++)
            {
                Console.Write(new string('-', leftRight));
                int mid = n - 2 * leftRight - 2;
                if (mid<0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight--;
            }
            leftRight = 0;
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                leftRight++;
                Console.Write(new string('-', leftRight));
                int mid = n - 2 * leftRight - 2;
                if (mid < 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', leftRight));
            }
        }
    }
}