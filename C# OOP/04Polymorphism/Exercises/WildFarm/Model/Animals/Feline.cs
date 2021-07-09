namespace WildFarm.Model
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public string Breed { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
