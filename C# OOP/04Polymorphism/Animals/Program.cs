using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Person();
            Mammal mammal = new Person();
            Person person = new Person();
            
            ((Person)animal).Name = "Pesho";
        }
    }
}
