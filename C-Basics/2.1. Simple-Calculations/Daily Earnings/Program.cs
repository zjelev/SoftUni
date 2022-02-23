using System;

namespace Daily_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double earn = double.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((days * earn * rate * 14.5 * 0.75 / 365), 2));
        }
    }
}
