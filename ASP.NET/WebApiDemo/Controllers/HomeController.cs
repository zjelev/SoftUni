using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        return View();
    }
}