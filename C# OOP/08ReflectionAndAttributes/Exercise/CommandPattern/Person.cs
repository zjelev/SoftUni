using System.ComponentModel.DataAnnotations;

namespace CommandPattern
{
    class Person
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
    }
}