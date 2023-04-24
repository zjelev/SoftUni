using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers;

public class ValuesController : ApiController
{
    // GET: api/<ValuesController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<ValuesController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ValuesController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ValuesController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ValuesController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }

    [HttpGet("GetCar/{year:int}")]
    public ActionResult<Car> GetCar(int year)
    {
        if (year > DateTime.UtcNow.Year)
            return BadRequest();

        return new Car() { Colour = Colour.Red, Model = "Audi A7", Year = year };
    }
}
