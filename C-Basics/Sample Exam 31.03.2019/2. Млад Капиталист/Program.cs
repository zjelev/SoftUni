//https://judge.softuni.bg/Contests/Practice/Index/947#1

using System;

namespace _2._Млад_Капиталист
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal parentsMoney = decimal.Parse(Console.ReadLine());
            decimal children = Math.Ceiling(int.Parse(Console.ReadLine()) * 0.85m);
            decimal guestMoney = decimal.Parse(Console.ReadLine());
            decimal scooterPrice = decimal.Parse(Console.ReadLine());

            decimal money = parentsMoney - 4.5m * children  +
                guestMoney * Math.Floor(0.8m * children);

            decimal delivery = scooterPrice * 0.05m;

            if (money >= (scooterPrice + delivery) )
            {
                Console.WriteLine($"Asparuh will be driving a fast 49cc Scooter soon." +
                    $"\nMoney left: {money - scooterPrice - delivery:f2} BGN");
            }
            else
            {
                Console.WriteLine($"If only Asparuh had {scooterPrice + delivery - money:f2} BGN more..." +
                    $"\nGuess he will be walking for now.");
            }
        }
    }
}