using System;

namespace _05._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int roomsOnFloor = int.Parse(Console.ReadLine());

            for (int i = floors; i > 0; i--)
            {
                for (int j = 0; j < roomsOnFloor; j++)
                {
                    if (i==floors)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 != 0)
                    {
                        Console.Write($"A{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"O{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
