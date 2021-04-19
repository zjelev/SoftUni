using System;
using System.Linq;
using MilitaryElite.Interfaces;

namespace MilitaryElite
{
    public class Mission: IMission
    {
        private readonly string[] states = new string[] { "inProgress", "Finished" };
        private string state;
        public Mission(string codename, string state)
        {
            this.CodeName = codename;
            this.State = state;
        }

        public string CodeName { get; private set; }
        public string State 
        { 
            get
            {
                return this.state;
            } 
            private set 
            {
                if (this.states.Contains(value))
                {
                    //throw new ArgumentException();
                    this.state = value;
                }
            } 
        }

        public void CompleteMission()
        {
            this.State = "Finished'";
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }

        
    }
}
