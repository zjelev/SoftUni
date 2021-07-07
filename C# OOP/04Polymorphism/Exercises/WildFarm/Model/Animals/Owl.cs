namespace WildFarm.Model
{
    public class Owl : Bird
    {
        public Owl(string name, double weight) : base(name, weight)
        {
        }

        public override string Ask()
        {
            return "Hoot Hoot";
        }
    }
}
