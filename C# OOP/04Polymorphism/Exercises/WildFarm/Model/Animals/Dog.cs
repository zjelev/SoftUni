namespace WildFarm.Model
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string Ask()
        {
            return "Woof!";
        }
    }
}
