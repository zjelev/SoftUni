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
                    double result = Math.Round(sum / 1.79549, 2);
                    Console.WriteLine(result + " USD");
                }
                else if (eur.Equals(outputCurrency))
                {
                    double result = Math.Round(sum / 1.95583, 2);
                    Console.WriteLine(result + " EUR");
                }
                else if (gbp.Equals(outputCurrency))
                {
                    double result = Math.Round(sum / 2.53405, 2);
                    Console.WriteLine(result + " GBP");
                }
            }
            else if (usd.Equals(inputCurrency))
                double result = Math.Round(sum / 2.53405, 2);
                Console.WriteLine(result + " GBP");
        }
        }
    }
}