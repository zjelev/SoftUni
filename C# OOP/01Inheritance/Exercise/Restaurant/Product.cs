using System;

namespace Restaurant
{
    public class Product
    {
        public Product( string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{this.Name} costs {this.Price} leva";
        }
    }
}
