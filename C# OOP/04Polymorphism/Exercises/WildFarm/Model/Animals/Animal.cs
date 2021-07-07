namespace WildFarm.Model
{
    public abstract class Animal : IAnimal
    {
        private string name;
        private double weight;
        private int foodEaten;

        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name 
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public double Weight 
        {
            get { return this.weight; }
            private set { this.weight = value; }
        }
        public int FoodEaten => foodEaten;

        public abstract string Ask();
    }
}
