using Microsoft.Build.Framework;

namespace MyFirstMvcApp.Controllers;

public class FormInputModel
{
    [Required]
    public string Search { get; set; }
}
