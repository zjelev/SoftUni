using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipesSystem.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set;  }

        [Required]
        [MaxLength(100)]
        [MinLength(10)] // does not affect DB, as [Range]
        public string Name { get; set;  }

        public string Description { get; set; }

        [MaxLength(80)]
        [NotMapped]
        public string Test { get; set; }

        public TimeSpan? CookingTime { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }

    }
}