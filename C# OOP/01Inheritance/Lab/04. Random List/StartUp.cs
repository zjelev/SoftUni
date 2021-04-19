using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList rnd = new RandomList(
                new string[] {"One", "Two", "Three", "Pesho", "Gosho", "Stamat"} );

            Console.WriteLine(rnd.ToString());
            Console.WriteLine(rnd.RandomString());
            Console.WriteLine(rnd.Count);
        }
    }
}