using System;

namespace _5_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cntP1 = 0, cntP2 = 0, cntP3 = 0;
            double p1, p2, p3;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum % 2 == 0)
                {
                    cntP1++;
                    if (currentNum % 4 == 0)
                    {
                        cntP3++;
                    }
                }
                if (currentNum % 3 == 0)
                {
                    cntP2++;
                }
            }
            p1 = cntP1 * 100.0 / n;
            p2 = cntP2 * 100.0 / n;
            p3 = cntP3 * 100.0 / n;
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);

        }
    }
}