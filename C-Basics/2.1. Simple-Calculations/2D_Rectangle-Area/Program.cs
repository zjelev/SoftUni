using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input coordinates x and y of one peak :");
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input coordinates x and y of the opposite peak :");
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var width = Math.Max(x1, x2) - Math.Min(x1, x2);
            var height = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine("Area is " + width * height);
            Console.WriteLine("Perimeter is " + 2 * (width + height));
        }
    }
}