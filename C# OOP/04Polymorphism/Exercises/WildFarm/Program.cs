namespace WildFarm
{
    using WildFarm.Core;
    using WildFarm.Model;
    class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            //engine.Run();
            IAnimal animal = new Owl("Toncho", 2.5);
            System.Console.WriteLine(animal);
            System.Console.WriteLine(animal.Ask());
            animal = new Cat("Ivan", 3);            
            System.Console.WriteLine(animal);
            System.Console.WriteLine(animal.Ask());
        }
    }
}
