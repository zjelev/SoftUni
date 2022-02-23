using System;

namespace _06_Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int microbus = 0, truck = 0, train = 0, total = 0;
            double p1, p2, p3, avgsum; 
            for (int i = 0; i < num; i++)
            {
                int weight = int.Parse(Console.ReadLine());
                if (weight <= 3)
                {
                    microbus += weight;
                }
                else if (weight <= 11)
                {
                    truck += weight;
                }
                else
                {
                    train += weight;
                }
            }
            total = microbus+truck+train;
            avgsum = (microbus * 200.0 + truck * 175.0 + train * 120.0) / total;
            p1 = microbus *  100.0 / total;
            p2 = truck * 100.0 / total;
            p3 = train * 100.0 / total;
            Console.WriteLine("{0:f2}", avgsum);
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}