namespace WildFarm.Model
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight) : base(name, weight)
        {
        }

        public override string Ask()
        {
            return "Woof!";
        }
    }
}
