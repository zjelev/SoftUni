using System;

namespace _05._Hotel_Room
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            byte nights = byte.Parse(Console.ReadLine());
            decimal priceApartment = 0;
            decimal priceStudio = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50m;
                    priceApartment = 65m;
                    if (nights > 14)
                    {
                        priceStudio *= 0.7m;
                    }
                    else if (nights > 7)
                    {
                        priceStudio *= 0.95m;
                    }
                    break;
                case "June":
                case "September":
                    priceStudio = 75.2m;
                    priceApartment = 68.7m;
                    if (nights > 14)
                    {
                        priceStudio *= 0.8m;
                    }
                    break;
                case "July":
                case "August":
                    priceStudio = 76m;
                    priceApartment = 77m;
                    break;
                default:
                    break;
            }

            if (nights > 14)  
            {
                priceApartment *= 0.9m;
            }
           
            string outputApt = string.Format("Apartment: {0:f2} lv.", decimal.Round(priceApartment * nights, 2));
            string outputStd = string.Format("Studio: {0:f2} lv.", decimal.Round(priceStudio * nights, 2));
            Console.WriteLine(outputApt);
            Console.WriteLine(outputStd);
        }
    }
}