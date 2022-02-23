using System;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Inches = ");
            var inches = double.Parse(Console.ReadLine());
            Console.WriteLine("Centimeters = {0}", inches * 2.54);
        }
    }
}