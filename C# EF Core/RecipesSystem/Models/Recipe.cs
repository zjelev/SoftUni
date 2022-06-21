using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipesSystem.Models
{
    public class Recipe
    {
        public int Id { get; set;  }

        [Required]
        [MaxLength(100)]

        public string Name { get; set;  }

        public string Description { get; set; }

        public string Test { get; set; }

        public TimeSpan CookingTime { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }

    }
}