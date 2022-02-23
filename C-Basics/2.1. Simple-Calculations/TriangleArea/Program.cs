using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = Math.Round(side*height/2, 2);
            Console.WriteLine("Triangle area = " + area);
        }
    }
}
