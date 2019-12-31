//https://judge.softuni.bg/Contests/Practice/Index/1165#5

using System;

namespace _06._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            long sumPrime = 0;
            long sumComp = 0;
            
            while ((input = Console.ReadLine()) != "stop")
            {
                int n = int.Parse(input);
                if (n < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    for (int i = 2; i < n / 2 + 1; i++)
                    {
                        if (n % i == 0)
                        {
                            sumComp += n;
                            isPrime = false;
                            break;
                        }
                    }
                    if (n == 1)
                    {
                        sumComp++;
                    }
                    else if (isPrime)
                    {
                        sumPrime += n;
                    }
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumComp}");
        }
    }
}