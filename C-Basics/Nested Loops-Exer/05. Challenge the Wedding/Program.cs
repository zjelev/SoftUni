//https://judge.softuni.bg/Contests/Practice/Index/1381#4

using System;

namespace _05._Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            byte men = byte.Parse(Console.ReadLine());
            byte women = byte.Parse(Console.ReadLine());
            byte tables = byte.Parse(Console.ReadLine());
            for (int m = 1; m <= men; m++)
            {
                if (tables == 0)
                {
                    break;
                }
                for (int w = 1; w <= women; w++)
                {
                    tables--;
                    Console.Write($"({m} <-> {w}) ");
                    if (tables == 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}