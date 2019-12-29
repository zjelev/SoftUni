using System;

namespace _01._Basketball_Equipment
{
    class BasketballEquipment
    {
        static void Main(string[] args)
        {
            int fee = int.Parse(Console.ReadLine());
            decimal shoes = fee - fee * 0.4m;
            decimal suit = shoes - shoes * 0.2m;
            decimal ball = suit / 4;
            decimal accessories = ball / 5;
            decimal total = fee + shoes + suit + ball + accessories;
            Console.WriteLine(Math.Round(total, 2));
        }
    }
}