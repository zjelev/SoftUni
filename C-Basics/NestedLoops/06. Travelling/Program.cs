using System;

namespace _06._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double minBudget = double.Parse(Console.ReadLine());
                double savedSum = 0;

                while (savedSum < minBudget)
                {
                    savedSum += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");
            }
  
        }
    }
}
