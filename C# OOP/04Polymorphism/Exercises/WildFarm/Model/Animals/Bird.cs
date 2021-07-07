using System;

namespace WildFarm.Model
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight) : base(name, weight)
        {
        }

        public double WingSize { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
