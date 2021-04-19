namespace MilitaryElite.Interfaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
        string Corps 
        { 
            get;
            // {
            //     return "ICorps"; // C# 8.0 or greater
            // } 
        }
    }
}
