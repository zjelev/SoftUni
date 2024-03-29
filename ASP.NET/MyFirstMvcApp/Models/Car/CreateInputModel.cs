﻿using Microsoft.AspNetCore.Mvc;
using MyFirstMvcApp.ModelBinders;
using MyFirstMvcApp.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace MyFirstMvcApp.Models.Car;

public class BrandAndModel : IValidatableObject
{
    [Required(ErrorMessage = "Въведете марка")]
    [MinLength(2)]
    public string Brand { get; set; }

    [Required]
    public string Model { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (this.Brand == "Audi" && !this.Model.StartsWith("Q") && !this.Model.StartsWith("A"))
            yield return new ValidationResult("Invalid Audi model");

        if (this.Brand == "BMW" && !this.Model.StartsWith("M") && !this.Model.StartsWith("3"))
            yield return new ValidationResult("Invalid BMW model");
    }
}

public class CreateInputModel
{
    [Range(1, int.MaxValue, ErrorMessage = "Please select valid type")]
    public CarType Type { get; set; }

    [Required]
    public BrandAndModel Car { get; set; }

    [Display(Name = "Long description")] // presentation only attr, not connected to validation 1:35
    [DataType(DataType.MultilineText)]
    [MinLength(10)]
    public string Description { get; set; }

    [DataType(DataType.Date)]
    // TODO: custom validator to current year
    //[Range(1900, 2100)]
    [BeforeCurrentYear(1900)]
    // [ModelBinder(typeof(DatetimeToYearModelBinder))] // Added globally
    public int Year { get; set; }

    [DataType(DataType.Currency)]
    [Range(0, double.MaxValue)]
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