using Microsoft.AspNetCore.Mvc;
using MyFirstMvcApp.Services;

namespace MyFirstMvcApp.ViewComponents;

public class LatestUserViewComponent : ViewComponent
{
    private readonly IUsersService usersService;

    public LatestUserViewComponent(IUsersService usersService)
    {
        this.usersService = usersService;
    }

    public IViewComponentResult Invoke(string text = "Last user") =>
        this.View(new LatestUserViewComponentViewModel 
        { 
            Text = text,
            Username = usersService.LatestUserName() 
        });
    
}

public class LatestUserViewComponentViewModel
{
    public string Text { get; set; }
    public string Username { get; set; }
}

