// dotnet ef database update

using System.Text;
using SIS.Http;
using SIS.Http.Response;

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
            var db = new ApplicationDbContext();
            var tweets = db.Tweets.Select(x => new
            {
                x.CreatedOn,
                x.Creator,
                x.Content
            }).ToList();
            StringBuilder html = new StringBuilder();
            html.Append("<table><tr><th>Date</th><th>Creator</th><th>Conteny</th></tr>");
            foreach (var tweet in tweets)
            {
                html.Append($"<tr><td>{tweet.CreatedOn}</td><td>{tweet.Creator}</td><td>{tweet.Content}</td></tr>");
            }
            html.Append("</table>");
            html.Append($"<form action='/Tweets/Create' method='post'><input name='creator' /><br /><textarea name='tweetName'></textarea><input type='submit' /></form>");

            return new HtmlResponse(html.ToString());

            // TODO - foreach all files (name, size, date created) in a folder in td-tr table
        }

        private static HttpResponse CreateTweet(HttpRequest request)
        {
            var db = new ApplicationDbContext();
            db.Tweets.Add(new Tweet
            {
                CreatedOn = DateTime.UtcNow,
                Creator = request.FormData["creator"],
                Content = request.FormData["tweetName"]
            });
            db.SaveChanges();

            return new RedirectResponse("/");
        }
    }
}
