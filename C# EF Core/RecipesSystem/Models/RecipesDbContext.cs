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
            //optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)   
        {
            modelBuilder.ApplyConfiguration(new RecipeConfigurations());
            
            modelBuilder.Entity<Recipe>() 
                .HasMany(x => x.Ingredients)
                .WithOne(x => x.Recipe)
                .HasForeignKey(x => x.RecipeId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<Ingredient>()
                .HasMany(x=> x.Recipes)
                .WithOne(x => x.Ingredient)
                .HasForeignKey(x => x.IngredientId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(x => new { x.RecipeId, x.IngredientId });
        }
    }
}