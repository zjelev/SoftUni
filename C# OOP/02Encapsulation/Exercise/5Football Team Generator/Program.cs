using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeam
{
    class Program
    {
        static void Main(string[] args)
        {  
            List<Team> teams = new List<Team>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] token = input.Split(";");
                    switch (token[0])
                    {
                        case "Team":
                            if (!teams.Any(x => x.Name == token[1]))
                            {
                                Team team = new Team(token[1]);
                                teams.Add(team);
                            }
                            break;
                        case "Add":
                            if (!teams.Exists(x => x.Name == token[1]))
                            {
                                throw new ArgumentException($"Team {token[1]} does not exist.");
                            }
                            teams.FirstOrDefault(x => x.Name == token[1])
                                .AddPlayer(token[2], int.Parse(token[3]),
                                int.Parse(token[4]), int.Parse(token[5]), 
                                int.Parse(token[6]), int.Parse(token[7]));
                            break;
                        case "Remove":
                            if (!teams.Exists(x => x.Name == token[1]))
                            {
                                throw new ArgumentException($"Team {token[1]} does not exist.");
                            }
                            teams.FirstOrDefault(x => x.Name == token[1])
                                .RemovePlayer(token[2]);
                            break;
                        case "Rating":
                            if (!teams.Exists(x => x.Name == token[1]))
                            {
                                throw new ArgumentException($"Team {token[1]} does not exist.");
                            }
                            Console.WriteLine(teams.FirstOrDefault(x => x.Name == token[1]));
                            break;
                        default:
                            break;
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}