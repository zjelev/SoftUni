using System;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int btc = int.Parse(Console.ReadLine());
            double yan = double.Parse(Console.ReadLine());
            double comm = double.Parse(Console.ReadLine());
            double eur = (btc * 1168 / 1.95 + yan * 0.15 * 1.76 / 1.95);
            Console.WriteLine(eur - comm / 100 * eur);
        }
    }
}
