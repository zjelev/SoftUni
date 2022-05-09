using System;

namespace _08Generics
{
    class Program7
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string fullName = $"{firstLine[0]} {firstLine[1]}";
            string address = $"{firstLine[2]}";
            string town = $"{firstLine[3]} {firstLine[4]}";
            var firstTuple = new MyTuple<string, string, string>(fullName, address, town);
            Console.WriteLine(firstTuple);

            string[] secondLine = Console.ReadLine().Split();
            var secondTuple = new MyTuple<string, int>(secondLine[0],
                        int.Parse(secondLine[1]));
            Console.WriteLine(secondTuple);

            string[] thirdLine = Console.ReadLine().Split();
            var thirdTuple = new MyTuple<int, double>(int.Parse(thirdLine[0]),
                        double.Parse(thirdLine[1]));
            Console.WriteLine(thirdTuple);
        }
    }
}