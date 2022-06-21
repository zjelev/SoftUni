using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipesSystem.Models;

namespace RecipesSystem.EntityConfiguraions
{
    public class RecipeConfigurations : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            // builder.HasKey("Id", "Name"); // params
            // builder.HasKey(new[] { "Id", "Name" }); // without params
            builder.HasKey(x => new { x.Id, x.Name }); // recommended
            builder.HasIndex(x => x.Name);

            builder.Ignore(x => x.Test);
            
            builder.Property(x => x.Name)
                .HasColumnName("Title")
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired();

            builder.Property<string>("Egn").HasColumnType("nvarchar(10)");
        }
    }
}
