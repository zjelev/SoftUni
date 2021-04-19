using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private readonly List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }
        
        public string Name 
        { 
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Money 
        { 
            get => this.money; 
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public List<Product> Bag => this.bag;

        public string Buy(Product product)
        {
            if (product.Cost > this.Money)
            {
                return $"{this.Name} can't afford {product}";
            }
            this.Bag.Add(product);
            this.Money -= product.Cost;
            return $"{this.Name} bought {product.Name}";
        }

        public override string ToString()
        {
            if (Bag.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            else
            {
                return $"{this.Name} - {String.Join(", ", this.Bag.Select(p => p.Name))}";
            }
        }
    }
}
