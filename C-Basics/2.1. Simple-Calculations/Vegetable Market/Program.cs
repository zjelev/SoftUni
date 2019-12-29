using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegprc = double.Parse(Console.ReadLine());
            double fruprc = double.Parse(Console.ReadLine());
            var vegkg = int.Parse(Console.ReadLine());
            var frukg = int.Parse(Console.ReadLine());
            Console.WriteLine((vegprc * vegkg + fruprc * frukg) / 1.94);
        }
    }
}
