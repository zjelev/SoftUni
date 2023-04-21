using Domain;
using Eventures.Data;
using Eventures.Filters;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EventuresDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), x => x.MigrationsAssembly("Eventures")));

// builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<EventuresDbContext>();

builder.Services.AddIdentity<EventuresUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;
    options.Password.RequiredUniqueChars = 0;
    // options.User.RequireUniqueEmail = true;
})
    .AddEntityFrameworkStores<EventuresDbContext>()
    .AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddControllersWithViews(options => options.Filters.Add(typeof(AdminActivityLoggerFilter)));
builder.Services.AddRazorPages();

builder.Services.AddScoped<RoleSeeder>();
builder.Services.AddScoped<UserSeeder>();

//builder.Logging.ClearProviders();
//builder.Logging.AddConsole(); //default anyway

var app = builder.Build();

using var scope = app.Services.CreateScope();
using var context = scope.ServiceProvider.GetRequiredService<EventuresDbContext>();

// dotnet ef migrations add Initial -o Data\Migrations
context.Database.Migrate();

//var seeder = new UserRoleSeeder(context);
//seeder.Seed();
var seeders = Assembly.GetCallingAssembly()
    .GetTypes()
    .Where(type => typeof(ISeeder).IsAssignableFrom(type))
    .Where(type => type.IsClass && !type.IsInterface)
    .Select(type => (ISeeder)scope.ServiceProvider.GetRequiredService(type))
    .ToList();

seeders.ForEach(seeder => seeder.Seed());

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
