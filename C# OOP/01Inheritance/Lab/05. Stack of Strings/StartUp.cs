using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // RandomList rnd = new RandomList(
            //     new string[] {"One", "Two", "Three", "Pesho", "Gosho", "Stamat"} );

            // Console.WriteLine(rnd.ToString());
            // Console.WriteLine(rnd.RandomString());
            // Console.WriteLine(rnd.Count);

            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty());
            stack.AddRange(new string[] {"1", "2", "3"});
            Console.WriteLine(stack.IsEmpty());
        }
    }
}