namespace AdoNet
{
    public class Minion
    {
        public int Id { get; }

        public string Name { get; private set; }

        public int Age { get; set; }

        public int TownId { get; set; }
    }
}