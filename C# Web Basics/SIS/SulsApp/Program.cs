using SIS.Http;
using SulsApp.Controllers;

namespace SulsApp
{
    public static class Program
    {
        private static async Task Main()
        {
            var db = new ApplicationDbContext();
            db.Database.EnsureCreated();

            var routeTable = new List<Route>();
            routeTable.Add(new Route(HttpMethodType.Get, "/", new HomeController().Index));

            var httpServer = new HttpServer(80, routeTable);
            await httpServer.StartAsync();
        }
    }
}