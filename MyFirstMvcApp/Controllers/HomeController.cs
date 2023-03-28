using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MyFirstMvcApp.Models;
using MyFirstMvcApp.Services;

namespace MyFirstMvcApp.Controllers;

public class HomeController : Controller
{
    private readonly IUsersService usersService;
    private readonly IConfiguration configuration;
    private readonly ICounterService counterService;

    public HomeController(IUsersService usersService, 
        IConfiguration configuration,
        ICounterService counterService)  // Dependency injection
    { 
        this.usersService = usersService;
        this.configuration = configuration;
        this.counterService = counterService;
    }

    public IActionResult Index()
    {
        //throw new Exception();
        this.HttpContext.Items = new Dictionary<object, object>() { [111]="some value" };
        // this.HttpContext.Response.Headers.Add("Content-Type", "application/json");
        // this.HttpContext.User.Identity.AuthenticationType;
                    // this.User.Identity.AuthenticationType;
        
        var usernames = this.usersService.GetUsernames();
        var viewModel = new IndexViewModel { Usernames = usernames };
        //this.configuration["Greetings"];
        return View(viewModel);
    }

    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
        => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

    public IActionResult BlogArticle(int year, int month, int day, string slug)
        => Json(new { year, month, day, slug });

    [HttpGet("Blog/{username}")]
    [HttpGet("User/{username?}")]
    [HttpGet("MyProfile")]
    public IActionResult MyCustomActionName(string username = "test") => Content(username);

    public IActionResult Errors(string code) =>
        this.Content(code);
}