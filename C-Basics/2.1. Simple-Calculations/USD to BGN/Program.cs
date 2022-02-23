using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input sum: ");
            double sum = double.Parse(Console.ReadLine());
            //Console.Write("Input currency: ");
            //string currency = Console.ReadLine();
            double bgn = Math.Round((sum * 1.79549), 2);
            Console.WriteLine(bgn + " BGN");
        }
    }
}