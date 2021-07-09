namespace WildFarm.Model
{
    public class Hen : Bird
    {
        private const double IncreaseRate = 0.35;

        public Hen(string name, double weight, string thirdParameter) : base(name, weight, thirdParameter)
        {
        }

        public override string Ask()
        {
            return "Cluck";
        }
    }
}
