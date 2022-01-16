namespace AdoNet
{
    public class Town
    {
        public Town(int id, string name, int countryCode)
        {
            Id = id;
            Name = name;
            CountryCode = countryCode;
        }

        public int Id { get; }
        public string Name { get; private set; }
        public int CountryCode { get; private set; }
    }
}