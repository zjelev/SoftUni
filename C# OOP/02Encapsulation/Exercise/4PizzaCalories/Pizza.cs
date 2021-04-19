using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;

        private readonly List<Topping> toppings;
       
        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }
        
        public string Name
        {
            get { return name; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException ("Pizza name should be between 1 and 15 symbols.");
                } 
                name = value; 
            }
        }

        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }
        
        public int ToppingsCount => this.toppings.Count;

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }
        private double Calories()
        {
            return this.Dough.Calories + this.toppings.Sum(t => t.Calories);
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.Calories():F2} Calories.";
        }
    }
}