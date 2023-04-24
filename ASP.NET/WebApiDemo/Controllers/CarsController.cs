using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Data;
using WebApiDemo.Data.Models;

namespace WebApiDemo.Controllers;

public class CarsController : ApiController
{
    private readonly ApplicationDbContext dbContext;

    public CarsController(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Car>> Get()
    {
        return dbContext.Cars.ToList();
    }

    [HttpPost]
    public async Task<ActionResult<Car>> Post(Car car)
    {
        await dbContext.Cars.AddAsync(car);
        await dbContext.SaveChangesAsync();
        return car;
    }
}
