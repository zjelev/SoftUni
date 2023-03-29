using Microsoft.AspNetCore.Mvc;
using MyFirstMvcApp.Models.Car;

namespace MyFirstMvcApp.Controllers;

public class CarController : Controller
{
    public IActionResult Create()
    {
        // TODO: default values
        return this.View();
    }

    [HttpPost]
    public IActionResult Create(CreateInputModel input)
    {
        if (ModelState.IsValid)
        {
            return Json(input);
        }
        else
        {
            return this.View(input);
        }
    }
}