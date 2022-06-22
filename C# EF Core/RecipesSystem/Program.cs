using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RecipesSystem.Models;

namespace RecipesSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new RecipesDbContext();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            // db.Database.Migrate(); // dotnet ef database update

            // db.Recipes.Select(x => new
            // {
            //     Egn = EF.Property<string>(x, "Egn") // shadow property
            // });

            var recipe = new Recipe
            {
                Name = "Musaka",
                Description = "Traditional BG/Tr meal",
                CookingTime = new TimeSpan(2, 3, 4),
                Ingredients =
                {
                    new RecipeIngredient
                    {
                        Ingredient = new Ingredient { Name = "Potato" },
                        Quantity = 2000,
                    },
                        new RecipeIngredient
                    {
                        Ingredient = new Ingredient { Name = "Meat" },
                        Quantity = 1000,
                    }
                }
            };
            // 5  new objects in DB - thanks to graph analyser (part of change tracker)

            db.Recipes.Add(recipe);

            db.SaveChanges();
        }
    }
}
