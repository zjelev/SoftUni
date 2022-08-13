using System.Text;
using SIS.Http;
using SIS.HTTP.Response;

namespace SIS
{
    class Program
    {
        private static async Task Main(string[] args)
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
            return new HtmlResponse($"<h1>home page. Hello, {request.SessionData["Username"]}</h1>");
        }

        public static HttpResponse Login(HttpRequest request)
        {
            request.SessionData["Username"] = "Pesho";
            return new HtmlResponse("<h1>login page</h1>");
        }

        public static HttpResponse DoLogin(HttpRequest request)
        {
            return new HtmlResponse("<h1>login page form</h1>");
        }
    }
}