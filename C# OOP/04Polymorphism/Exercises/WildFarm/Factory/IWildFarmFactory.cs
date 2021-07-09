namespace WildFarm.Factory
{
    using WildFarm.Model;
    public interface IWildFarmFactory
    {
        IAnimal CreateAnimal(string type, string name, double weight, string thirdParameter);
        IFood CreateFood(string type, int quantity);
    }
}
