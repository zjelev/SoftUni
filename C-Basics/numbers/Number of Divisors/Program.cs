using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Divisors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number which we will look divisors for: ");
            int n = int.Parse(Console.ReadLine()), num = 0;
            for (int c = 1; c <= n; c++)
            {
                if (n % c == 0)
                {
                    Console.WriteLine("Divisor found: " + c);
                    num++;
                }
            }
            Console.WriteLine("Number of divisors: " + num);
        }
    }
}
