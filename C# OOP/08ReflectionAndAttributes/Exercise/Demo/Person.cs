using System;

namespace Demo
{
    public class Person
    {
        private string name;
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name 
        { 
            get => this.name; 
            set
            {
                // if(string.IsNullOrWhiteSpace(value))
                // {
                //     throw new ArgumentException("Name can not be empy.");
                // }

                this.name = value; // + "sth else";
            }
        }
    }
}