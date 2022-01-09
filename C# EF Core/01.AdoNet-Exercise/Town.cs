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

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryCode { get; set; }
    }
}