using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] peopleWithMoney = Console.ReadLine().Split(';');

            for (int i = 0; i < peopleWithMoney.Length; i++)
            {
                string[] personWithMoney = peopleWithMoney[i].Split('=');
                try
                {
                    Person person = new Person(personWithMoney[0], decimal.Parse(personWithMoney[1]));
                    people.Add(person);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            List<Product> products = new List<Product>();
            string[] productsWithCost = Console.ReadLine().Split(';');

            foreach (var item in productsWithCost)
            {
                string[] productWithCost = item.Split('=');
                try
                {
                    Product product = new Product(productWithCost[0], decimal.Parse(productWithCost[1]));
                    products.Add(product);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] order = input.Split(' ');
                    
                try
                {
                    Console.WriteLine(people
                        .FirstOrDefault(p => p.Name == order[0])
                        .Buy(products
                        .FirstOrDefault(p => p.Name == order[1])));
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
