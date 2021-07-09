using System;

namespace WildFarm.Model
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, string thirdParameter) : base(name, weight, thirdParameter)
        {
            this.WingSize = double.Parse(thirdParameter);
        }

        public double WingSize { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
