namespace MyFirstMvcApp.Models.Car;

public class BrandAndModel
{
    public string Brand { get; set; }
    public string Model { get; set; }
}

public class CreateInputModel
{
    public CarType Type { get; set; }
    public BrandAndModel Car { get; set; }
    public string Description { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public byte[] Image { get; set; }
}

public enum CarType
{
    Sedan = 1,
    SUV = 2,
    Cabrio = 3,
    Combi = 4
}