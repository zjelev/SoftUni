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

            db.Recipes.Add(new Recipe 
            { 
                Name = "Musaka 4",
                Description = "Traditional BG/Tr meal",
                CookingTime = new TimeSpan(2, 3, 4) 
            });

            db.Recipes.Add(new Recipe 
            { 
                Name = "Musaka 4",
                Description = "Tr meal",
                CookingTime = new TimeSpan(2, 3, 4) 
            });

            db.Recipes.Select(x => new
            {
                Egn = EF.Property<string>(x, "Egn") // shadow property
            });

            db.SaveChanges();
        }
    }
}
