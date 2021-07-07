namespace WildFarm.Model
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight) : base(name, weight)
        {
        }

        public override string Ask()
        {
            return "Squeak";
        }
    }
}
