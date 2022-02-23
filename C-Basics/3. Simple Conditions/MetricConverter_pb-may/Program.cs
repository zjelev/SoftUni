using System;

namespace MetricConverter_pb_may
{
    class Program
    {
        static void Main(string[] args)
        {
            double numToConvert = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            //double toMeters = 1;

            if (input == "cm")
            {
                numToConvert = 0.01;
            }
            else if (input == "mm")
            {
                numToConvert = 0.001;
            }

            //double result = numToConvert * toMeters;

            if (output == "cm")
            {
                numToConvert *= 100;
            }
            else if (output == "mm")
            {
                numToConvert *= 1000;
            }

            Console.WriteLine($"{numToConvert:f3}");
        }
    }
}
