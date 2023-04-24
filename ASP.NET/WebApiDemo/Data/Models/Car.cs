using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Data.Models;

public class Car
{
    public int Id { get; set; }

    [Required]
    [MinLength(3)]
    public string Model { get; set; }

    [Range(1900, 2100)]
    public int Year { get; set; }
    public Colour Colour { get; set; }
}

public enum Colour
{
    Black = 1,
    Red = 2,
    Blue = 3
}