//https://judge.softuni.bg/Contests/Practice/Index/1538#11

using System;

namespace _06._Basketball_Tournament
{
    class BasketballTournament
    {
        static void Main(string[] args)
        {
            string tournament = "";
            byte totalMatches = 0;
            byte wins = 0;
            while (true)
            {
                tournament = Console.ReadLine();
                if (tournament == "End of tournaments")
                {
                    break;
                }
                byte matches = byte.Parse(Console.ReadLine());
                totalMatches += matches;
                byte scoreDesy = 0;
                byte scoreOther = 0;
                for (int i = 1; i <= matches; i++)
                {
                    scoreDesy = byte.Parse(Console.ReadLine());
                    scoreOther = byte.Parse(Console.ReadLine());
                    if (scoreDesy > scoreOther)
                    {
                        wins++;
                        Console.WriteLine($"Game {i} of tournament {tournament}: " +
                            $"win with {scoreDesy - scoreOther} points.");
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {tournament}: " +
                            $"lost with {scoreOther - scoreDesy} points.");
                    }
                }
            }
            Console.WriteLine($"{(double)wins / totalMatches * 100:f2}% matches win");
            Console.WriteLine($"{(double)(totalMatches - wins) / totalMatches * 100:f2}% matches lost");
        }
    }
}