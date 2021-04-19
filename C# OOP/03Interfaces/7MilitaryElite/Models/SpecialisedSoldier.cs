using System;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        protected SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps 
        {
            get => this.corps; 

            set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException();
                }
                this.corps = value;
            }
        }

        public override string ToString() => $"{base.ToString()}" + Environment.NewLine + $"Corps: {this.Corps}";
    }
}