namespace WildFarm.Model
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, string thirdParameter) : base(name, weight, thirdParameter)
        {
        }

        public override string Ask()
        {
            return "Hoot Hoot";
        }
    }
}
