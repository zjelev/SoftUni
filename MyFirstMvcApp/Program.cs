using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing.Template;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography.X509Certificates;
using MyFirstMvcApp.Data;
using MyFirstMvcApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("SQLServerConnection") ?? throw new InvalidOperationException("Connection string not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IUsersService, UsersService>(); // DI
builder.Services.AddSingleton<ICounterService, CounterService>();

var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//    app.UseMigrationsEndPoint();
//else
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.UseStatusCodePagesWithRedirects("/Home/Errors?code={0}");
// app.UseStatusCodePagesWithReExecute

app.UseHttpsRedirection();
app.UseStaticFiles(); //terminal middleware

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "BlogArticle",
    pattern: "{controller=Home}/{action=BlogArticle}/{year}/{month}/{day}/{slug}"); //������ ������� ��������

//app.UseMvc(routes =>
//{
//    routes.MapRoute(
//        template: "Blog/{year}/{month}/{day}/{slug},
//        name: "BlogArticle",
//        constraints: new { year = @"\d{4}", month = @"\d{1,2}", day = @"\d{1,2" },
//        defaults: new { controller = "Home", action = "BlogArticle" }
//        );
//});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
