using System.ComponentModel.DataAnnotations;

namespace RecipesSystem.Models
{
    public class Recipe
    {
        public int Id { get; set;  }

        [Required]
        [MaxLength(100)]

        public string Name { get; set;  }

    }
}