using System;

namespace Animals
{
    public abstract class Mammal : IAnimal
    {
        public virtual void Suckle()
        {
            Console.WriteLine("I suck!");
        }
        public void Breathe()
        {
            Console.WriteLine("I'm breathing");
        }
        public abstract void Eat();
    }
}
