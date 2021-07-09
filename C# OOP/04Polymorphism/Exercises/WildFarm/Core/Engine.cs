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
                
                // string livingRegion;
                // double wingSize;
                string breed;

                animal = wildFarmFactory.CreateAnimal(animalType, name, weight, animalData[3]);

                // if (animal is Bird)
                // {
                //     wingSize = double.Parse(animalData[3]);
                //     (animal as Bird).WingSize = wingSize;
                // }
                // else if (animal is Mammal)
                // {
                //     livingRegion = animalData[3];
                //     (animal as Mammal).LivingRegion = livingRegion;
                    if (animal is Feline)
                    {
                        breed = animalData[4];
                        (animal as Feline).Breed = breed;
                    }
                // }

                Console.WriteLine(animal.Ask());

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
                else
                {
                    food = new Seeds(quantity);
                }

                if (((animal is Tiger || animal is Dog || animal is Owl) && (food is Fruit || food is Vegetable || food is Seeds))
                    || (animal is Mouse && (food is Seeds || food is Meat))
                    || (animal is Cat && (food is Seeds || food is Fruit)))
                {
                    Console.WriteLine($"{animalType} does not eat {foodType}!");
                }
                else
                {
                    animal.FoodEaten += quantity;
                    if (animal is Hen)
                    {
                        animal.Weight += quantity * 0.35;
                    }
                    else if (animal is Owl)
                    {
                        animal.Weight += quantity * 0.25;
                    }
                    else if (animal is Mouse)
                    {
                        animal.Weight += quantity * 0.1;
                    }
                    else if (animal is Cat)
                    {
                        animal.Weight += quantity * 0.3;
                    }
                    else if (animal is Dog)
                    {
                        animal.Weight += quantity * 0.4;
                    }
                    else
                    {
                        animal.Weight += quantity;
                    }
                }
                animals.Add(animal);
            }
            
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
        }
    }
}
