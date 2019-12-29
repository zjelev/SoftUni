using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hriz = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.ToLower(char.Parse(Console.ReadLine()));
            decimal priceHriz = 0;
            decimal priceRoses = 0;
            decimal priceTulips = 0;
            if (season == "Spring" || season == "Summer")
            {
                priceHriz = 2m;
                priceRoses = 4.1m;
                priceTulips = 2.5m;
            }
            if (season == "Autumn" || season == "Winter")
            {
                priceHriz = 3.75m;
                priceRoses = 4.5m;
                priceTulips = 4.15m;
            }
            if (holiday == 'y')
            {
                priceHriz = priceHriz + priceHriz * 0.15m;
                priceRoses = priceRoses + priceRoses * 0.15m;
                priceTulips = priceTulips + priceTulips * 0.15m;
            }
            decimal priceBuket = hriz * priceHriz + roses * priceRoses + tulips * priceTulips;
            if (tulips > 7 && season == "Spring")
            {
                priceBuket = priceBuket - priceBuket * 0.05m;
            }
            if (roses >= 10 && season == "Winter")
            {
                priceBuket = priceBuket - priceBuket * 0.1m;
            }
            if (hriz+roses+tulips > 20)
            {
                priceBuket = priceBuket - priceBuket * 0.2m;
            }
            Console.WriteLine("{0:f2}", priceBuket + 2m);
        }
    }
}