using System;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedete dolna granica: ");
            int lower = int.Parse(Console.ReadLine());

            Console.Write("Vavedete gorna granica: ");
            int upper = int.Parse(Console.ReadLine());

            PrintPrimes(lower, upper);

            Console.WriteLine();

            Console.Write("Input integer to check if it is prime: ");

            int toBeChecked = int.Parse(Console.ReadLine());

            CheckPrime(toBeChecked);

            Swap.SwapNumber(toBeChecked);
        }

        private static void CheckPrime(int toBeChecked)
        {
            for (int i = 2; i <= toBeChecked / 2; i++)
            {
                if (toBeChecked % i == 0)
                {
                    Console.WriteLine($"{toBeChecked} is not Prime");
                    break;
                }

                if (i == toBeChecked / 2)
                {
                    Console.WriteLine($"{toBeChecked} is Prime");
                }
            }
        }

        public static void PrintPrimes(int lower, int upper)
        {
            for (int i = lower; i <= upper; i++)
            {
                for (int j = 2; j <= i/2; j++)
                {
                    if (i%j == 0)
                    {
                        break;
                    }

                    if (j == i/2)
                    {
                        Console.Write(i + " ");
                    }
                }
            }  
        }
    }
}
