using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                                
                Pizza pizza = new Pizza(input.Split(" ")[1]);

                input = Console.ReadLine();

                string[] doughData = input.Split(" ");
                Dough dough = new Dough(doughData[1], doughData[2], double.Parse(doughData[3]));
                pizza.Dough = dough;

                while ((input = Console.ReadLine()) != "END")
                {
                    string[] toppingData = input.Split(" ");
                    Topping topping = new Topping(toppingData[1], double.Parse(toppingData[2]));
                    pizza.AddTopping(topping);
                }

                Console.WriteLine(pizza);
            }
            catch (ArgumentException e)
            {
                Console.Write(e.Message);
            }
        }
    }
}
