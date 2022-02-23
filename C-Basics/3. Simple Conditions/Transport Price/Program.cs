using System;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = "day", n = "night";
            double priceTaxi;
            int km = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            if (t.Equals(d))
                priceTaxi = 0.79;
            else
                priceTaxi = 0.9;
            if (km < 20)
                Console.WriteLine(0.7 + priceTaxi * km);
            else if (km < 100)
            {
                Console.WriteLine(km * 0.09);
            }
            else if (km >= 100)
            {
                Console.WriteLine(km * 0.06);
            }
        }
    }
}