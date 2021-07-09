namespace WildFarm.Model
{
    public abstract class Animal : IAnimal
    {
        private string name;
        private double weight;
        private int foodEaten;

        public Animal(string name, double weight, string thirdParameter)
        {
            this.Name = name;
            this.Weight = weight;
            //this.FoodEaten = 0;
        }

        public string Name 
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public double Weight 
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public int FoodEaten
        {
            get { return this.foodEaten; }
            set { this.foodEaten = value; }
        }

        public abstract string Ask();
    }
}
