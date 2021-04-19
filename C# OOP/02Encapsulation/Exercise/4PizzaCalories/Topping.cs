using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Topping
    {
        private const double BaseCaloriesPerGram = 2;
        private const double MinGrams = 1;
        private const double MaxGrams = 50;
        private readonly Dictionary<string, double> DefaultTypes 
            = new Dictionary<string, double>
            {
                {"meat", 1.2},
                {"veggies", 0.8},
                {"cheese", 1.1},
                {"sauce", 0.9},
            };

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
        public string Type
        {
            get => type;
            set 
            { 
                if (!this.DefaultTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value.ToLower(); 
            }
        }
        
        public double Weight
        {
            get { return weight; }
            private set 
            { 
                if (value < MinGrams || value > MaxGrams)
                {
                    string t = Char.ToUpper(this.type[0]) + this.type.Substring(1);
                    throw new ArgumentException($"{t} weight should be in the range [{MinGrams}..{MaxGrams}].");
                }
                weight = value; 
            }
        }

        public double CaloriesPerGram
        {
            get
            {
                return BaseCaloriesPerGram 
                    * this.DefaultTypes[this.Type];
            }
        }
        public double Calories 
        { 
            get
            {
                return this.CaloriesPerGram * this.Weight; 
            }
        }
    }
}