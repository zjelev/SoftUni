namespace ExplicitInterfaces
{
    interface IResident : IPerson
    {
        string Country { get; }

        new string GetName();
    }
}
