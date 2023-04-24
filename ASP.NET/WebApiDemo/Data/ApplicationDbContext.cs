using Microsoft.EntityFrameworkCore;
using WebApiDemo.Data.Models;

namespace WebApiDemo.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=Cars;User Id=AspNet;Password=.;Encrypt=False;MultipleActiveResultSets=true");
    }
}
