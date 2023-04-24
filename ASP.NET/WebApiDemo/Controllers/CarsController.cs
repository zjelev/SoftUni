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

    [HttpGet("{id}")]
    public ActionResult<Car> Get(int id)
    {
        return dbContext.Cars.FirstOrDefault(x => x.Id == id);
    }

    [HttpPost]
    public async Task<ActionResult<Car>> Post(Car car)
    {
        await dbContext.Cars.AddAsync(car);
        await dbContext.SaveChangesAsync();
        return CreatedAtAction("Get", new { car.Id });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Car car, int id)
    {
        var dbCar = dbContext.Cars.FirstOrDefault(x => x.Id == id);
        dbCar.Colour = car.Colour;
        dbCar.Model = car.Model;
        dbCar.Year = car.Year;
        await dbContext.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Car>> Delete(int id)
    {
        var car = dbContext.Cars.FirstOrDefault(x => x.Id == id);
        if (car == null)
        {
            return NotFound();
        }

        dbContext.Cars.Remove(car);
        await dbContext.SaveChangesAsync();
        return car;
    }
}
