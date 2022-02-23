using System;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());
            //int col = (int)((n) / w);
            //int rows = (int)((n) / l);
            //double tilearea = w * l;
            double numbertiles = ((n * n - m * o) / (w * l));
            Console.WriteLine(numbertiles);
            Console.WriteLine(numbertiles * 0.2);
        }
    }
}
