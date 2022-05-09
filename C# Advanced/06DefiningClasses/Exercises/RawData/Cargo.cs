namespace RawData
{
    public class Cargo
    {
    //-------------- Constructors --------------
    public Cargo(int weight, string type)
    {
        this.Weight = weight;
        this.Type = type;
    }
    //--------------- Properties ---------------
    public int Weight { get; set;}
    
    public string Type { get; set; }
    }
}