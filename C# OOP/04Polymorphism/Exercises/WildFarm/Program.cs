namespace WildFarm
{
    using WildFarm.Core;
    using WildFarm.Model;
    class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
