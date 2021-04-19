using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeam
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }
       
        public void AddPlayer(string name, int endurance, 
            int sprint, int dribble, int passing, int shooting)
        {
            Player player = new Player(name, endurance, sprint, dribble, passing, shooting);
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.Any(x => x.Name == playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }
            this.players.RemoveAt(players.FindIndex(x => x.Name == playerName));
            //this.players.Remove(this.players.First(p => p.Name == playerName));
        }

        private int Rating
        {
            get
            {
                double sumRatings = 0;

                foreach (var player in players)
                {
                    sumRatings += player.Skill();
                }
                
                if (this.players.Count > 0)
                {
                    return (int)Math.Round(sumRatings / players.Count);
                }
                else
                {
                    return 0;
                }
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}