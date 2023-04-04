using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Panda.Domain;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PandaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), x => x.MigrationsAssembly("PandaApp")));

builder.Services.AddIdentity<PandaUser, PandaUserRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;
    options.Password.RequiredUniqueChars = 0;
    // options.User.RequireUniqueEmail = true;
})
    .AddEntityFrameworkStores<PandaDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddMvc();

var app = builder.Build();


using var scope = app.Services.CreateScope();
using var context = scope.ServiceProvider.GetRequiredService<PandaDbContext>();

// dotnet ef migrations add Initial -o Migrations
context. Database.Migrate();

if (!context.Roles.Any())
{
    context.Roles.Add(new PandaUserRole { Name = "Admin", NormalizedName = "ADMIN" });
    context.Roles.Add(new PandaUserRole { Name = "User", NormalizedName = "USER" });
}

if (!context.PackageStatus.Any())
{
    context.PackageStatus.Add(new PackageStatus { Id = Guid.NewGuid().ToString(), Name = "Pending" });
    context.PackageStatus.Add(new PackageStatus { Id = Guid.NewGuid().ToString(), Name = "Shipped" });
    context.PackageStatus.Add(new PackageStatus { Id = Guid.NewGuid().ToString(), Name = "Delivered" });
    context.PackageStatus.Add(new PackageStatus { Id = Guid.NewGuid().ToString(), Name = "Acquired" });
}

context.SaveChanges();


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseDeveloperExceptionPage();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
