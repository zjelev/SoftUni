using System;

namespace _1000_Days_after_birth
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Format = "dd-MM-yyyy";
            DateTime date1 = DateTime.ParseExact(Console.ReadLine(), Format, System.Globalization.CultureInfo.InvariantCulture);
            DateTime answer = date1.AddDays(1000);
            Console.WriteLine("{0:dd-MM-yyyy}", answer);
        }
    }
}
