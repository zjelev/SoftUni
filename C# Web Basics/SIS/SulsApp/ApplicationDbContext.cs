using Microsoft.EntityFrameworkCore;
using SulsApp.Models;

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

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Problem> Problem { get; set; } = null!;
        public DbSet<Submission> Submissions { get; set; } = null!;

    }
}