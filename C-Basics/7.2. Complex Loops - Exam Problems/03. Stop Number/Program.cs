using System;

namespace _03.Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            var m = 0;
            var s = 0;
            do
            {
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 || n >= 10000);
            do
            {
                m = int.Parse(Console.ReadLine());
            }
            while (m <= n || m > 10000);
            do
            {
                s = int.Parse(Console.ReadLine());
            } while (s < n || s > m);
            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == s)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}