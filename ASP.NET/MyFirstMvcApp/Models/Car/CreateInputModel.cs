using Microsoft.AspNetCore.Mvc;
using MyFirstMvcApp.ModelBinders;
using System.ComponentModel.DataAnnotations;

namespace MyFirstMvcApp.Models.Car;

public class BrandAndModel
{
    public string Brand { get; set; }
    public string Model { get; set; }
}

public class CreateInputModel
{
    public CarType Type { get; set; }

    public BrandAndModel? Car { get; set; }

    //[MinLength(10)]
    [Display(Name = "Long description")] // presentation only attr, not connected to validation 1:35
    [DataType(DataType.MultilineText)]
    public string Description { get; set; }

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [DataType(DataType.Date)]
    // [ModelBinder(typeof(DatetimeToYearModelBinder))] // Added globally
    public int Year { get; set; }

    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    public byte[]? Image { get; set; }
}

public enum CarType
{
    Sedan = 1,
    SUV = 2,
    Cabrio = 3,
    Combi = 4
}