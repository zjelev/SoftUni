using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double prod = double.Parse(Console.ReadLine());
            int needed = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double rekolta = area * prod * 0.4 / 2.5;
            if (rekolta < needed)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(needed - rekolta));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(rekolta));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(rekolta - needed), Math.Ceiling((rekolta - needed)/workers));
            }
         }
    }
}
