//https://judge.softuni.bg/Contests/Practice/Index/1103#4

using System;

namespace _05._Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int numStations = int.Parse(Console.ReadLine());
            int stationNumber = 0;
            for (int i = 1; i <= numStations; i++)
            {
                people -= int.Parse(Console.ReadLine());
                people += int.Parse(Console.ReadLine());
                stationNumber++;
                if (stationNumber % 2 == 1)
                {
                    people += 2;
                }
                else
                {
                    people -= 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {people}");
        }
    }
}
