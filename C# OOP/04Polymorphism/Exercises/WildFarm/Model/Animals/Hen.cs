namespace WildFarm.Model
{
    public class Hen : Bird
    {
        public Hen(string name, double weight) : base(name, weight)
        {
        }

        public override string Ask()
        {
            return "Cluck";
        }
    }
}
