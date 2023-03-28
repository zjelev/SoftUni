using System.ComponentModel.DataAnnotations;

namespace MyFirstMvcApp.Models;

public class IndexViewModel
{
    [DataType(DataType.MultilineText), Display(Name = "Niki")]
    public int Input123 { get; set; }
    public IEnumerable<string>? Usernames { get; set; }
}
