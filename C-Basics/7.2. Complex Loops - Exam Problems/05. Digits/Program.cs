using System;

namespace _05.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n<100 || n>999);
            int d1 = n / 100;
            int d2 = (n - d1 * 100) / 10;
            int d3 = n%10;
            //Console.WriteLine(d1 + " " + d2 + " " + d3);
            int col = d1 + d3;
            int row = d1 + d2;
            int num = 0;
            while (true)
            {
                while (n % 5 == 0)
                {
                    n -= d1;
                    Console.Write(n + " ");
                    num++;
                    if (num % col == 0)
                    {
                        Console.Write("\n");
                    }
                    if (num == row * col)
                    {
                        break;
                    }
                }
                while (n % 3 == 0)
                {
                    if (n % 5 == 0)
                    {
                        break;
                    }
                    n -= d2;
                    Console.Write(n + " ");
                    num++;
                    if (num % col == 0)
                    {
                        Console.Write("\n");
                    }
                    if (num == row * col)
                    {
                        break;
                    }
                }
                if (n % 5 != 0 && n % 3 != 0)
                {
                    n += d3;
                    Console.Write(n + " ");
                    num++;
                    if (num % col == 0)
                    {
                        Console.Write("\n");
                    }
                    if (num == row * col)
                    {
                        break;
                    }
                }
                if (num == row * col)
                {
                    break;
                }
            }
        }
    }
}