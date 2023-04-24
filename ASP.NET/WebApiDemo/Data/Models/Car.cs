namespace WebApiDemo.Data.Models;

public class Car
{
    public int Id { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public Colour Colour { get; set; }
}

public enum Colour
{
    Black = 1,
    Red = 2,
    Blue = 3
}