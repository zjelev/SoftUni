using System;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private int age;
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }   
    }
}
