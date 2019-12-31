//https://judge.softuni.bg/Contests/Practice/Index/1596#2

using System;

namespace _03._OscarsWeek
{
    class OscarsWeek
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string hall = Console.ReadLine();
            byte tickets = byte.Parse(Console.ReadLine());
            decimal price = 0;
            if (movie == "A Star Is Born")
            {
                if (hall == "normal")
                {
                    price = 7.5m;
                }
                else if (hall == "luxury")
                {
                    price = 10.5m;
                }
                else
                {
                    price = 13.50m;
                }
            }
            else if (movie == "Bohemian Rhapsody")
            {
                if (hall == "normal")
                {
                    price = 7.35m;
                }
                else if (hall == "luxury")
                {
                    price = 9.45m;
                }
                else
                {
                    price = 12.75m;
                }
            }
            else if (movie == "Green Book")
            {
                if (hall == "normal")
                {
                    price = 8.15m;
                }
                else if (hall == "luxury")
                {
                    price = 10.25m;
                }
                else
                {
                    price = 13.25m;
                }
            }
            else if (movie == "The Favourite")
            {
                if (hall == "normal")
                {
                    price = 8.75m;
                }
                else if (hall == "luxury")
                {
                    price = 11.55m;
                }
                else
                {
                    price = 13.95m;
                }
            }
            string output = string.Format($"{movie} -> {price * tickets:f2} lv.");
            Console.WriteLine(output);
        }
    }
}