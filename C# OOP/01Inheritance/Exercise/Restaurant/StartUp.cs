using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Product beverage = new Beverage("tequila", (decimal)2.5, 250.5);
            beverage.Name = "whisky";

            Product coffee = new Coffee("espresso", 2.5);
            Product cake = new Cake("plodova pita");

            Console.WriteLine(beverage);
            Console.WriteLine(coffee);
            Console.WriteLine(cake);
        }
    }
}