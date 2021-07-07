using System;

namespace WildFarm.Core
{
    using WildFarm.Model;
    using WildFarm.Factory;
    using System.Collections.Generic;

    public class Engine : IEngine
    {
        //private readonly IWildFarmFactory wildFarmFactory;
        public void Run()
        {
            IWildFarmFactory wildFarmFactory = new WildFarmFactory();
            IAnimal animal;
            List<IAnimal> animals = new List<IAnimal>();
            IFood food;
            
            string inputAnimal;

            while ((inputAnimal = Console.ReadLine()) != "End")
            {
                string[] animalData = inputAnimal.Split();
                
                string animalType = animalData[0];
                string name = animalData[1];
                double weight = double.Parse(animalData[2]);
                
                string livingRegion;
                double wingSize;
                string breed;

                animal = wildFarmFactory.CreateAnimal(animalType, name, weight);

                if (animalType == nameof(Mouse) || animalType == nameof(Dog))
                {
                    livingRegion = animalData[3];
                    (animal as Mammal).LivingRegion = livingRegion;
                }
                else if (animalType == nameof(Owl) || animalType == nameof(Hen))
                {
                    wingSize = double.Parse(animalData[3]);
                    (animal as Bird).WingSize = wingSize;
                }
                else if (animalType == nameof(Cat) || animalType == nameof(Tiger))
                {
                    breed = animalData[4];
                    (animal as Feline).Breed = breed;
                }

                string[] foodData = Console.ReadLine().Split();

                string foodType = foodData[0];
                int quantity = int.Parse(foodData[1]);

                if (foodType == nameof(Fruit))
                {
                    food = new Fruit(quantity);
                }
                else if (foodType == nameof(Vegetable))
                {
                    food = new Vegetable(quantity);
                }
                else if (foodType == nameof(Meat))
                {
                    food = new Meat(quantity);
                }
                else if (foodType == nameof(Seeds))
                {
                    food = new Seeds(quantity);
                }

                Console.WriteLine(animal.Ask());

            }
        }
    }
}
