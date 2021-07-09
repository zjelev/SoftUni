namespace WildFarm.Model
{
    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; set; }
        int FoodEaten { get; set; }

        string Ask();
    }
}
