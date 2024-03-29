using System;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        //-------------------- Properties ----------------------
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

                this.lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                age = value;
            }
        }
        public decimal Salary 
        { 
            get
            {
                return salary;
            } 
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
                salary = value;
            } 
        }

        //---------------------- Methods -----------------------
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                percentage /= 2;
            }
            this.Salary += this.Salary * percentage / 100;
        }
    }
}
