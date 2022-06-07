using System;
using Microsoft.EntityFrameworkCore;
using RecipesSystem.Models;

namespace RecipesSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new RecipesDbContext();
            // db.Database.EnsureDeleted();
            // db.Database.EnsureCreated();
            db.Database.Migrate(); // dotnet ef database update

            db.Recipes.Add(new Recipe { Name = "Musaka" });
            db.SaveChanges();
        }
    }
}
