using System.ComponentModel.DataAnnotations;

namespace MyFirstMvcApp.Models
{
    public class IndexInputModel
    {
        //[Required]
        [MinLength(10)] 
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
