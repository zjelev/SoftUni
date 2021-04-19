using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Dough
    {
        private const double BaseCaloriesPerGram = 2;
        private const double MinGrams = 1;
        private const double MaxGrams = 200;

        
        private readonly Dictionary<string, double> defaultFlourTypes 
            = new Dictionary<string, double>()
            {
                {"white", 1.5},
                {"wholegrain", 1.0}
            };
        private readonly Dictionary<string, double> defaultBakingTechnique 
            = new Dictionary<string, double>()
            {
                {"crispy", 0.9},
                {"chewy", 1.1},
                {"homemade", 1.0}
            };

        private string flourType;
        private string bakingTechnique;
        private double grams;

        public Dough(string flourType, string bakingTechnique, double grams)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Grams = grams;
        }
        
        public string FlourType
        {
            get { return flourType; }
            private set 
            {
                if (!defaultFlourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");;
                }
                flourType = value.ToLower(); 
            }
        }
        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set 
            {
                if (!defaultBakingTechnique.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value.ToLower(); 
            }
        }
        public double Grams 
        {
            get { return this.grams; }
            private set
            {
                if (value < MinGrams || value > MaxGrams)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                 grams = value;
            }
        }

        public double CaloriesPerGram
        {
            get => BaseCaloriesPerGram * 
                this.defaultFlourTypes[this.FlourType] * 
                this.defaultBakingTechnique[this.BakingTechnique];
        }

        public double Calories 
        { 
            get
            {
                return this.CaloriesPerGram * this.Grams; 
            }
        }
    }
}