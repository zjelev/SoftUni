using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}