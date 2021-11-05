using System;
using System.ComponentModel.DataAnnotations;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public class Person
    {
        public Person(string fullName, int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }
        
        [MyRequired]
        // [Obsolete]
        public string FullName { get; set; }

        [MyRange(12, 90)]
        public int Age { get; set; }
    }
}