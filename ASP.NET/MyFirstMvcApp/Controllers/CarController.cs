using Microsoft.AspNetCore.Mvc;
using MyFirstMvcApp.Models.Car;

namespace MyFirstMvcApp.Controllers;

public class CarController : Controller
{
    public IActionResult Create()
    {
        var model = new CreateInputModel();
        model.Description = "initial value";
        model.ReleaseDate = DateTime.Now;
        return this.View(model);
    }

    [HttpPost]
    public IActionResult Create([FromForm]CreateInputModel input)
    {
        if (!ModelState.IsValid)
            return this.View(input);
        
        return Json(input);
    }
}