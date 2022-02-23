//https://judge.softuni.bg/Contests/Practice/Index/1382#5

using System;

namespace _06._Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin1 = int.Parse(Console.ReadLine());
            int begin2 = int.Parse(Console.ReadLine());
            int end1 = int.Parse(Console.ReadLine()) + begin1;
            int end2 = int.Parse(Console.ReadLine()) + begin2;

            bool pair1IsPrime = false;
            bool pair2IsPrime = false;


            for (int i = begin1; i <= end1 ; i++)
            {
                for (int k = 2; k <= i / 2 + 1; k++)
                {
                    pair1IsPrime = true;
                    if (i % k == 0)
                    {
                        pair1IsPrime = false;
                        break;
                    }
                }
                for (int j = begin2; j <= end2; j++)
                {
                    for (int l = 2; l <=  j / 2 + 1; l++)
                    {
                        pair2IsPrime = true;
                        if (j % l == 0)
                        {
                            pair2IsPrime = false;
                            break;
                        }
                    }
                    if (pair1IsPrime && pair2IsPrime)
                    {
                        Console.WriteLine("" + i + j);
                    }
                }
            }
        }
    }
}
