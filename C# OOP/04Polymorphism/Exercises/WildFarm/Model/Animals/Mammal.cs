namespace WildFarm.Model
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight) : base(name, weight)
        {
        }

        public string LivingRegion { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
