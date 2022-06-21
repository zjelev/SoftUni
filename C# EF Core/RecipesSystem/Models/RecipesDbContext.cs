using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RecipesSystem.EntityConfiguraions;

namespace RecipesSystem.Models
{
    public class RecipesDbContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Recipes;Integrated Security=true");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)   
        {
            modelBuilder.ApplyConfiguration(new RecipeConfigurations());
        }
    }
}