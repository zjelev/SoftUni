using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            int cols = (int)((width - 1) / 0.7);
            int rows = (int)(lenght / 1.2);
            int seats = rows * cols - 3;
            Console.WriteLine(seats);
        }
    }
}
