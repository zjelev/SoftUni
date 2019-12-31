using System;

namespace _01._Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            bool hasOdd = false;
            bool hasEven = false;

            for (int i = 1; i <= n; i++)
            {
                double current = double.Parse(Console.ReadLine());

                if(i%2 == 0)
                {
                    hasEven = true;
                    if (current < evenMin)
                    {
                        evenMin = current;
                    }

                    if (current > evenMax)
                    {
                        evenMax = current;
                    }

                    evenSum += current;
                }
                else
                {
                    hasOdd = true;
                    if (current < oddMin)
                    {
                        oddMin = current;
                    }

                    if (current > oddMax)
                    {
                        oddMax = current;
                    }

                    oddSum += current;
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (hasOdd)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (hasEven)
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
