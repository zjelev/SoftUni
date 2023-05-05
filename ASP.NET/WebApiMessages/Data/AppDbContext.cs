using Microsoft.EntityFrameworkCore;

namespace WebApiMessages.Data;

public class AppDbContext : DbContext
{
    public DbSet<Message> Messages { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
