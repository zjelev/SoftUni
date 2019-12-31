using System;

namespace _01._Stadium_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectorsNum = int.Parse(Console.ReadLine());
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double totalIncome = stadiumCapacity * ticketPrice;
            double sectorIncome = totalIncome / sectorsNum;

            double charityMoney = (totalIncome - 0.75 * sectorIncome) / 8;

            Console.WriteLine($"Total income - {totalIncome:f2} BGN");
            Console.WriteLine($"Money for charity - {charityMoney:f2} BGN");
        }
    }
}
