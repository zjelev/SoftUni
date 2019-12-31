using System;

namespace _05._Fan_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int boughtSum = 0;

            for (int i = 0; i < n; i++)
            {
                string itemBought = Console.ReadLine();

                switch (itemBought)
                {
                    case "hoodie":
                        boughtSum += 30;
                        break;
                    case "keychain":
                        boughtSum += 4;
                        break;
                    case "T-shirt":
                        boughtSum += 20;
                        break;
                    case "flag":
                        boughtSum += 15;
                        break;
                    case "sticker":
                        boughtSum += 1;
                        break;
                    default:
                        break;
                }
            }

            int diff = Math.Abs(budget - boughtSum);

            if (budget >= boughtSum)
            {
                Console.WriteLine($"You bought {n} items and left with {diff} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {diff} more lv.");
            }
        }
    }
}
