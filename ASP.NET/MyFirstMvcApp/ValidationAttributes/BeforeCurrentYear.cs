using System.ComponentModel.DataAnnotations;

namespace MyFirstMvcApp.ValidationAttributes;

public class BeforeCurrentYearAttribute : ValidationAttribute
{
    private readonly int afterYear;

    public BeforeCurrentYearAttribute(int afterYear)
    {
        this.afterYear = afterYear;
    }
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (!(value is int))
            return new ValidationResult("Invalid " + validationContext.DisplayName);

        if ((int)value > DateTime.UtcNow.Year)
            return new ValidationResult(validationContext.DisplayName + " is after " + DateTime.UtcNow.Year);

        if ((int)value < afterYear)
            return new ValidationResult(validationContext.DisplayName + " is before " + afterYear);

        return ValidationResult.Success;
    }
}
