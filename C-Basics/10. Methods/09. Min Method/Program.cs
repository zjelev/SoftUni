using System;

namespace _09.Min_Method
{
    class Program
    {
        static int GetMin(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int min = GetMin(GetMin(a, b), c);
            Console.WriteLine(min);
        }
    }
}
