namespace WildFarm.Model
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string Ask()
        {
            return "Meow";
        }
    }
}
