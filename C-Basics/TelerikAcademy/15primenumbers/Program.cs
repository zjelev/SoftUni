using System;

namespace _15primenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = n; i >= 2; i--)
            {
                bool isPrime = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0 && i > 2)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
