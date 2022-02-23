using System;

namespace _06._Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char sector = char.Parse(Console.ReadLine());
            byte row = byte.Parse(Console.ReadLine());
            int place = int.Parse(Console.ReadLine());
            int n = 0;
            for (char c = 'A'; c <= sector; c++)
            {
                for (byte r = 1; r <= row; r++)
                {
                    if (r % 2 == 0)
                    {
                        place += 2;
                    }
                    for (char p = 'a'; p < place + 97; p++)
                    {
                        Console.WriteLine($"{c}{r}{p}");
                        n++;
                    }
                    if (r % 2 == 0)
                    {
                        place -= 2;
                    }
                }
                row++;
            }
            Console.WriteLine(n);
        }
    }
}
