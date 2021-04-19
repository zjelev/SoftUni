using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private readonly List<IMission> missions;
        public IReadOnlyCollection<IMission> Missions 
        { 
            get => this.missions.AsReadOnly();
        }

        public Commando(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<IMission>();
        }

        public void AddMission(IMission mission)
        {
            this.missions.Add(mission);
        }

        public override string ToString()
        {
            // return base.ToString() + Environment.NewLine 
            // + $"Corps: {this.Corps}"
            // + $"Missions: {this.Missions}";
            // With above -> Process is terminating due to StackOverflowException.

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");
            sb.Append("  " + String.Join(Environment.NewLine + "  ", this.Missions));
            return sb.ToString().TrimEnd();
        }
    }
}
