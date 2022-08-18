using Microsoft.EntityFrameworkCore;

namespace SulsApp
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SulsApp;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Tweet> Tweets { get; set; } = null!;

    }
}