//https://judge.softuni.bg/Contests/Practice/Index/519#0

using System;

namespace _01._Passion_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string input = "";
            while (input != "mall.Enter")
            {
                input = Console.ReadLine();
            }
            int numPurchases = 0;
            while ((input = Console.ReadLine()) != "mall.Exit")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '*')
                    {
                        money += 10;
                    }
                    else
                    {
                        decimal purchase = input[i];
                        if (input[i] >= 'A' && input[i] <= 'Z')
                        {
                            purchase *= 0.5m;
                        }
                        else if (input[i] >= 'a' && input[i] <= 'z')
                        {
                            purchase *= 0.3m;
                        }
                        else if (input[i] == '%')
                        {
                            purchase = money / 2m;
                        }
                        if (money >= purchase && money > 0)
                        {
                            money -= purchase;
                            numPurchases++;
                        }
                    }
                }
            }
            if (numPurchases > 0)
            {
                Console.WriteLine($"{numPurchases} purchases. Money left: {money:f2} lv.");
            }
            else
            {
                Console.WriteLine($"No purchases. Money left: {money:f2} lv.");
            }
        }
    }
}