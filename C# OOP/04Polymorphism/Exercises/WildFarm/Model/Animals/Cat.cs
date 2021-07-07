namespace WildFarm.Model
{
    public class Cat : Feline
    {
        public Cat(string name, double weight) : base(name, weight)
        {
        }

        public override string Ask()
        {
            return "Meow";
        }
    }
}
