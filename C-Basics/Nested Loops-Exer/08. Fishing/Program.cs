//https://judge.softuni.bg/Contests/Practice/Index/1165#7

using System;

namespace _08._Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string fish = "";
            byte i = 0;
            decimal moneySum = 0;
            while ((fish = Console.ReadLine()) != "Stop")
            {
                float kg = float.Parse(Console.ReadLine());
                i++;

                decimal money = 0;
                for (int j = 0; j < fish.Length; j++)
                {
                    money += fish[j];
                }
                money = money / (decimal)kg;

                if (i % 3 == 0)
                {
                    moneySum += money;
                }
                else
                {
                    moneySum -= money;
                }

                if (i == n)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    break;
                }
            }
            if (moneySum >= 0)
            {
                Console.WriteLine($"Lyubo's profit from {i} fishes is {moneySum:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {(0-moneySum):f2} leva today.");
            }
        }
    }
}
