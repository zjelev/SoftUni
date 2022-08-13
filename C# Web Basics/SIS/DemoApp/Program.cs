using SIS.Http;
using SIS.HTTP.Response;

namespace SIS
{
    class Program
    {
        private static async Task Main()
        {
            var routeTable = new List<Route>();
            routeTable.Add(new Route(HttpMethodType.Get, "/", Index));
            routeTable.Add(new Route(HttpMethodType.Get, "/users/login", Login));
            routeTable.Add(new Route(HttpMethodType.Post, "/users/login", DoLogin));
            routeTable.Add(new Route(HttpMethodType.Get, "/contact", Contact));
            routeTable.Add(new Route(HttpMethodType.Get, "/favicon.ico", FavIcon));
            var httpServer = new HttpServer(80, routeTable);
            await httpServer.StartAsync();
        }

        // /TODO w StringBuilder: /headers => html table list of all header

        private static HttpResponse FavIcon(HttpRequest arg)
        {
            var byteContent = File.ReadAllBytes("wwwroot/globe.ico");
            return new FileResponse(byteContent, "image/x-icon");
        }

        private static HttpResponse Contact(HttpRequest request)
        {
            return new HtmlResponse("<h1>contact</h1>");
        }

        public static HttpResponse Index(HttpRequest request)
        {
            // Sharing between two requests is done through eighter TempData or SessionData or Cache
            var username = request.SessionData.ContainsKey("Username") ? request.SessionData["Username"] : "Anonymous";
            return new HtmlResponse($"<h1>Home page. Hello, {username}</h1><img src= '/images/img.jpg' /><a href='users/login'>Go to login</a>");
            // TODO - foreach all files (name, size, date created) in a folder in td-tr table
        }

        public static HttpResponse Login(HttpRequest request)
        {
            request.SessionData["Username"] = "Pesho";
            return new HtmlResponse("<h1>login page</h1><a href='/'>Home</a>");
        }

        public static HttpResponse DoLogin(HttpRequest request)
        {
            return new HtmlResponse("<h1>login page form</h1>");
        }
    }
}