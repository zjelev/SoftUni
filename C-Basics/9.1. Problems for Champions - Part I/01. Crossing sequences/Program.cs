using System;

namespace _01.Crossing_sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tribonacci
            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());
            int t3 = int.Parse(Console.ReadLine());
            int trib = t1 + t2 + t3;
            //Spiral
            int spiral = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int num = 0;
            int i = 0;
            //Check
            if (t1 > 1000000 || spiral > 1000000)
            {
                Console.WriteLine("No");
            }
            // Match
            while (t1 <= 1000000 && spiral <= 1000000)
            {
                if (t1 == spiral)
                {
                    Console.WriteLine(t1);
                    break;
                }
                else if (t1 < spiral)
                {
                    t1 = t2;
                    t2 = t3;
                    t3 = trib;
                    trib = t1 + t2 + t3;
                }
                else
                {
                    spiral = spiral + num * step;
                    if (i % 2 == 0)
                    {
                        num++;
                    }
                    i++;
                }
            }
        }
    }
}