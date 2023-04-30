using WebApiDemo.Data;
using WebApiDemo.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>();

var app = builder.Build();

//using var scope = app.Services.CreateScope();
//var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
var dbContext = new ApplicationDbContext();
dbContext.Database.EnsureCreated();
if (!dbContext.Cars.Any())
{
    dbContext.Cars.Add(new Car { Colour = Colour.Black, Model = "Audi A7", Year = 2012 });
    dbContext.Cars.Add(new Car { Colour = Colour.Red, Model = "BMW 316", Year = 2011 });
    dbContext.Cars.Add(new Car { Colour = Colour.Blue, Model = "Peugeot 307", Year = 2008 });
    dbContext.Cars.Add(new Car { Colour = Colour.Black, Model = "Opel Zafira", Year = 1999 });
}
    dbContext.SaveChanges();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
