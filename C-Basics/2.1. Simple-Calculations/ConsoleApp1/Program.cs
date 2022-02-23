using System;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string bgn = "BGN";
            string usd = "USD";
            string eur = "EUR";
            string gbp = "GBP";
            Console.Write("Input sum: ");
            double sum = double.Parse(Console.ReadLine());
            Console.Write("Input currency: ");
            string inputCurrency = Console.ReadLine();
            Console.Write("Output currency: ");
            string outputCurrency = Console.ReadLine();
            if (bgn.Equals(inputCurrency))
            {
                if (usd.Equals(outputCurrency))
                {
                    Console.WriteLine(Math.Round(sum / 1.79549, 2) + " USD");
                }
                else if (eur.Equals(outputCurrency))
                {
                    Console.WriteLine(Math.Round(sum / 1.95583, 2) + " EUR");
                }
                else //if (gbp.Equals(outputCurrency))
                {
                    Console.WriteLine(Math.Round(sum / 2.53405, 2) + " GBP");
                }
            }
            else if (usd.Equals(inputCurrency))
            {
                if (bgn.Equals(outputCurrency))
                {
                    Console.WriteLine(Math.Round(sum * 1.79549, 2) + " BGN");
                }
                else if (eur.Equals(outputCurrency))
                {
                    Console.WriteLine(Math.Round(sum * 1.79549 / 1.95583, 2) + " EUR");
                }
                else //if (gbp.Equals(outputCurrency))
                {
                    Console.WriteLine(Math.Round(sum * 1.79549 / 2.53405, 2) + " GBP");
                }
            }
            else if (eur.Equals(inputCurrency))
            {
                if (bgn.Equals(outputCurrency))
                {
                    Console.WriteLine(Math.Round(sum * 1.95583, 2) + " BGN");
                }
                else if (usd.Equals(outputCurrency))
                {
                    Console.WriteLine(Math.Round(sum / 1.79549 * 1.95583, 2) + " USD");
                }
                else //if (gbp.Equals(outputCurrency))
                {
                    Console.WriteLine(Math.Round(sum * 1.95583 / 2.53405, 2) + " GBP");
                }
            }
            else //(gbp.Equals(inputCurrency))
            {
                if (bgn.Equals(outputCurrency))
                {
                    Console.WriteLine(Math.Round(sum * 2.53405, 2) + " BGN");
                }
                else if (usd.Equals(outputCurrency))
                {
                    Console.WriteLine(Math.Round(sum / 1.79549 * 2.53405, 2) + " USD");
                }
                else //if (eur.Equals(outputCurrency))
                {
                    Console.WriteLine(Math.Round(sum / 1.95583 * 2.53405, 2) + " EUR");
                }
            }
        }
    }
}