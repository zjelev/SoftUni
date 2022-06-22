using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipesSystem.Models
{
    // [Table("Ingredienti", Schema = "dbo")]
    public class Ingredient
    {
        public Ingredient()
        {
            this.Recipes = new HashSet<RecipeIngredient>();
        }
        public int Id { get; set; }

        // [Column("Title", Order = 3, TypeName = "nvarchar(90)")]
        [Required]
        public string Name { get; set; }

        // public decimal Quantity { get; set; }

        // Has-A relation
        // public int RecipeId { get; set; } // not required, but good to have

        // public Recipe Recipe { get; set; }

        public ICollection<RecipeIngredient> Recipes { get; set; }

    }
}