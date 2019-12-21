using System;

namespace _05_Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0, evenSum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    oddSum = oddSum + int.Parse(Console.ReadLine());
                }
                else
                {
                    evenSum = evenSum + int.Parse(Console.ReadLine());
                }
            }
            if (oddSum == evenSum)
            {
                Console.Write("Yes"+"\n"+ "sum = " + evenSum);
            }
            else
            {
                Console.Write("No" + "\n" + "diff = " + Math.Abs(evenSum - oddSum));
            }
        }
    }
}