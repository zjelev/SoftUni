//https://judge.softuni.bg/Contests/Practice/Index/1538#8

using System;

namespace _05._Tennis_Ranklist
{
    class TennisRanklist
    {
        static void Main(string[] args)
        {
            byte tournaments = byte.Parse(Console.ReadLine());
            byte wins = 0;
            ushort initPts = ushort.Parse(Console.ReadLine());
            ushort points = 0;
            for (int i = 0; i < tournaments; i++)
            {
                string finished = Console.ReadLine();
                switch (finished)
                {
                    case "W":
                        points += 2000;
                        wins++;
                        break;
                    case "F":
                        points += 1200;
                        break;
                    case "SF":
                        points += 720;
                        break;
                    default:
                        break;
                }
            }
            string output = string.Format($"Final points: {initPts + points}\n"
                + $"Average points: {points / tournaments}\n" + $"{(double)wins / tournaments * 100:f2}%");
            Console.WriteLine(output);
        }
    }
}
