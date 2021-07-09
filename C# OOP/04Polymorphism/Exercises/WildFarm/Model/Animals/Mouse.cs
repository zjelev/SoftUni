namespace WildFarm.Model
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string Ask()
        {
            return "Squeak";
        }
    }
}
