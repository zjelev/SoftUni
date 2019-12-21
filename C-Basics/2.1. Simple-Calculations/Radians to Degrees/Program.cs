using System;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var answer = Math.Round((rad * 180 / Math.PI), 0);
            Console.WriteLine(answer);
        }
    }
}
