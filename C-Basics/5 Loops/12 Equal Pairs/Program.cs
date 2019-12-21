using System;

namespace _12_Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double a = 0, pair1 = 0, b = 0, pair2 = 0, diff = 0, maxDiff = double.MinValue;
            a = double.Parse(Console.ReadLine());
            pair1 = a + double.Parse(Console.ReadLine());
            if (n <= 1)
            {
                maxDiff = pair1;
                Console.WriteLine("Yes, value=" + maxDiff);
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    b = double.Parse(Console.ReadLine());
                    pair2 = b + double.Parse(Console.ReadLine());
                    diff = Math.Abs(pair1 - pair2);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                    pair1 = pair2;
                    //a = double.Parse(Console.ReadLine());
                    //pair1 = a + double.Parse(Console.ReadLine());
                }
                if (maxDiff == 0)
                {
                    Console.WriteLine("Yes, value=" + pair1);
                }
                else
                {
                    Console.WriteLine("No, maxdiff=" + maxDiff);
                }
            }
        }
    }
}