using System;

namespace _1_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] p = new int[20];
            int n = int.Parse(Console.ReadLine());
            int cntP1 = 0, cntP2 = 0, cntP3 = 0, cntP4 = 0, cntP5 = 0;
            double p1, p2, p3, p4, p5;
            for (int i=0; i<n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum < 200)
                {
                    cntP1++;
                }
                else if (currentNum >= 200 && currentNum < 400)
                {
                    cntP2++;
                }
                else if (currentNum >= 400 && currentNum < 600)
                {
                    cntP3++;
                }
                else if (currentNum >= 600 && currentNum < 800)
                {
                    cntP4++;
                }
                else
                {
                    cntP5++;
                }
            }
            p1 = cntP1 * 100.0 / n;
            p2 = cntP2 * 100.0 / n;
            p3 = cntP3 * 100.0 / n;
            p4 = cntP4 * 100.0 / n;
            p5 = cntP5 * 100.0 / n;
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}