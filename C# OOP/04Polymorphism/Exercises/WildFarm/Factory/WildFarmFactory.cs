using WildFarm.Model;

namespace WildFarm.Factory
{
    public class WildFarmFactory : IWildFarmFactory
    {
        public IAnimal CreateAnimal(string type, string name, double weight, string thirdParameter)
        {
            IAnimal animal = null;

            if (type == nameof(Owl))
            {
                animal = new Owl(name, weight, thirdParameter);
            }
            else if (type == nameof(Hen))
            {
                animal = new Hen(name, weight, thirdParameter);
            }
            else if (type == nameof(Mouse))
            {
                animal = new Mouse(name, weight, thirdParameter);
            }
            else if (type == nameof(Dog))
            {
                animal = new Dog(name, weight, thirdParameter);
            }
            else if (type == nameof(Cat))
            {
                animal = new Cat(name, weight, thirdParameter);
            }
            else if (type == nameof(Tiger))
            {
                animal = new Tiger(name, weight, thirdParameter);
            }
            else
            {
                throw new System.ArgumentException();
            }

            return animal;
        }

        public IFood CreateFood(string type, int quantity)
        {
            IFood food = null;

            if (type == nameof(Vegetable))
            {
                food = new Vegetable(quantity);
            }
            else if (type == nameof(Fruit))
            {
                food = new Fruit(quantity);
            }
            else if (type == nameof(Meat))
            {
                food = new Meat(quantity);
            }
            else if (type == nameof(Seeds))
            {
                food = new Seeds(quantity);
            }

            return food;
        }
    }
}
