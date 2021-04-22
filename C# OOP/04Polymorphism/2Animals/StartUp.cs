using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // IAnimal animal = new Person();
            // Mammal mammal = new Person();
            // Person person = new Person();
            
            // ((Person)animal).Name = "Pesho";

            Animal cat = new Cat("Pesho", "Whiskas");
            Animal dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
