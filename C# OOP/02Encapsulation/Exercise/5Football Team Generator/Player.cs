using System;
using System.Collections.Generic;

namespace FootballTeam
{
    public class Player
    {
        private string name;
        private readonly Dictionary<string, int> stats 
            = new Dictionary<string, int>()
        {
            {"Endurance", 0},
            {"Sprint", 0}, 
            {"Dribble", 0},
            {"Passing", 0},
            {"Shooting", 0}
        };

        public Player(string name, int endurance, int sprint, 
            int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.SetStat("Endurance", endurance);
            this.SetStat("Sprint", sprint);
            this.SetStat("Dribble", dribble);
            this.SetStat("Passing", passing);
            this.SetStat("Shooting", shooting);
        }

        public string Name
        {
            get { return name; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value; 
            }
        }

        public void SetStat(string key, int value)
        {
            if (!(stats.ContainsKey(key) && value >= 0 && value <= 100))
            {
                throw new ArgumentException($"{key} should be between 0 and 100.");
            }
            stats[key] = value;
        }

        public int GetStat(string key)
        {
            int result = 0;

            if (stats.ContainsKey(key))
            {
                result = stats[key];
            }

            return result;
        }

        public double Skill()
        {
            double statsSum = 0;
            foreach (var kvp in stats)
            {
                statsSum += kvp.Value;
            }
            return statsSum / stats.Count;
        }
    }
}
