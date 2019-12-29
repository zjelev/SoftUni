using System;

namespace Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v, p1, p2;
            double h, fill;
            v = int.Parse(Console.ReadLine());
            p1 = int.Parse(Console.ReadLine());
            p2 = int.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());
            fill = h * (p1 + p2);
            if (fill <= v)
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(fill / v * 100), Math.Truncate(p1*h/fill*100), Math.Truncate(p2*h/fill*100));
            else
                Console.WriteLine("For {0} hours the pool overflows with {1} litres.", /*(fill - v) / (p1 + p2)*/h, fill - v);
        }
    }
}