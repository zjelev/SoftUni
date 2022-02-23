using System;

namespace _02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal t = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());
            decimal tilePrice = decimal.Parse(Console.ReadLine());
            decimal masterPrice = decimal.Parse(Console.ReadLine());
            decimal floorArea = a * b;
            decimal tileArea = t * h / 2m;
            decimal numberTiles = Math.Ceiling(floorArea / tileArea) + 5;
            decimal totalPrice = tilePrice * numberTiles + masterPrice;
            if (totalPrice > money)
            {
                Console.WriteLine("You'll need {0:f2} lv more", totalPrice - money);
            }
            else
            {
                Console.WriteLine("{0:f2} lv left", money - totalPrice);
            }
        }
    }
}