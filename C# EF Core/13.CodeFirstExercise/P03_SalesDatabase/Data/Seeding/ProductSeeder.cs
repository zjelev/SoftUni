using System;
using System.Collections.Generic;
using P03_SalesDatabase.Data.Models;

namespace P03_SalesDatabase.Data
{
    public class ProductSeeder : ISeeder
    {
        private Random random;
        private readonly SalesContext dbContext;

        public ProductSeeder(SalesContext context, Random random)
        {
            this.dbContext = context;
            this.random = random;
        }

        public void Seed()
        {
            ICollection<Product> products = new List<Product>();
            string[] names = new string[]
            {
                "CPU",
                "MB",
                "GPU",
                "RAM",
                "SSD",
                "HDD",
                "Cooler"
            };

            for (int i = 0; i < 50; i++)
            {
                int nameIndex = this.random.Next(names.Length);
                string currentPrName = names[nameIndex];
                double qty = this.random.Next(1000);
                decimal price = this.random.Next(5000) * 1.133m;

                Product product = new Product
                {
                    Name = currentPrName,
                    Price = price,
                    Quantity = qty
                };

                products.Add(product);
                Console.WriteLine($"Product (name: {product.Name}, price: {product.Price} added");
            }

            this.dbContext.Products.AddRange(products);
            this.dbContext.SaveChanges();
        }
    }
}