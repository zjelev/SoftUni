using System;

namespace Farm
{
    public class Animal
    {
        string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }
}