using System;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1, num = 1;
            do
            {
                num = num * k;              
                k++;
            } while (k<=n);
            Console.WriteLine("n!= " + num);
        }
    }
}