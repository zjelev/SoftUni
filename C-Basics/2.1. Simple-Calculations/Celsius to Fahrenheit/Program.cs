using System;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input degrees Celsius: ");
            double celsius = Math.Round(double.Parse(Console.ReadLine()), 2);
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine(fahrenheit);
        }
    }
}
