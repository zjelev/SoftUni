using System;

namespace _2_Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            decimal laundry = decimal.Parse(Console.ReadLine());
            int toy = int.Parse(Console.ReadLine());
            int savedMoney = 0;
            int moneyForBday = 0;
            int toyNum = 0;
            for (int i = 0; i < age; i++)
            {
                if (i%2==0)
                {
                    toyNum++;
                }
                else
                {
                    moneyForBday += 10;
                    savedMoney += moneyForBday - 1;
                }
            }
            savedMoney += toy * toyNum;
            Console.WriteLine(savedMoney >= laundry ? $"Yes! {savedMoney - laundry:0.00}" : $"No! {laundry - savedMoney:0.00}");
            /*if (savedMoney >= laundry)
            {
                Console.WriteLine("Yes! " + (savedMoney - laundry));
            }
            else
            {
                Console.WriteLine("No! " + (laundry - savedMoney));
            }*/
        }
    }
}