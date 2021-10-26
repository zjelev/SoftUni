namespace Stealer
{
    public interface IPerson
    {
        // private string name; 
        // private string egn;
        // public Person(string name, string egn)
        // {
        //     this.Name = name;
        //     this.Egn = egn;
        // }
        
        public string Name { get; set; }

        public string Egn { get; set; }

    }
}