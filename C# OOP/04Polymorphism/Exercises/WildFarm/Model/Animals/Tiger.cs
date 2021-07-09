namespace WildFarm.Model
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string Ask()
        {
            return "ROAR!!!";
        }
    }
}
