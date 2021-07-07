namespace WildFarm.Model
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight) : base(name, weight)
        {
        }

        public override string Ask()
        {
            return "ROAR!!!";
        }
    }
}
