using SIS.Http;
using SIS.HTTP.Response;

namespace DemoApp
{
    class Program
    {
        private static async Task Main()
        {
            var db = new ApplicationDbContext();
            db.Database.EnsureCreated();

            var routeTable = new List<Route>();
            routeTable.Add(new Route(HttpMethodType.Get, "/", Index));
            routeTable.Add(new Route(HttpMethodType.Post, "/Tweets/Create", CreateTweet));
            routeTable.Add(new Route(HttpMethodType.Get, "/favicon.ico", FavIcon));
            
            var httpServer = new HttpServer(80, routeTable);
            await httpServer.StartAsync();
        }

        //TODO w StringBuilder: /headers => html table list of all header

        private static HttpResponse FavIcon(HttpRequest arg)
        {
            var byteContent = File.ReadAllBytes("wwwroot/globe.ico");
            return new FileResponse(byteContent, "image/x-icon");
        }

        public static HttpResponse Index(HttpRequest request)
        {
            // Sharing between two requests is done through eighter TempData or SessionData or Cache
            var username = request.SessionData.ContainsKey("Username") ? request.SessionData["Username"] : "Anonymous";
            return new HtmlResponse($"<form action='/Tweets/Create' method='post'><textarea name='tweetName'></textarea><input type='submit' /></form>");
            // TODO - foreach all files (name, size, date created) in a folder in td-tr table
        }

        private static HttpResponse CreateTweet(HttpRequest request)
        {
            return new HtmlResponse("");
        }
    }
}