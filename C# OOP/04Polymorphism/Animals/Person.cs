using System;

namespace Animals
{
    public class Person : Mammal, IAnimal
    {
        public string Name { get; set; }

        public void Speak() 
        {
            Console.WriteLine("I'm speaking");
        }
        public override void Eat()
        {
            Console.WriteLine("I'm eating");
        }
    }
}
