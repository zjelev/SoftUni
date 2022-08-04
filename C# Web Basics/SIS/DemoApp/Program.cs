using System.Text;
using SIS.Http;

class Program
{
    private static async Task Main(string[] args)
    {
        var routeTable = new List<Route>();
        routeTable.Add(new Route(HttpMethodType.Get, "/", Index));
        routeTable.Add(new Route(HttpMethodType.Get, "/users/login", Login));
        routeTable.Add(new Route(HttpMethodType.Post, "/users/login", DoLogin));
        routeTable.Add(new Route(HttpMethodType.Post, "/contact", Contact));
        routeTable.Add(new Route(HttpMethodType.Post, "/favicon.ico", FavIcon));
        var httpServer = new HttpServer(80, routeTable);
        await httpServer.StartAsync();
    }

    private static HttpResponse FavIcon(HttpRequest arg)
    {
        throw new NotImplementedException();
    }

    private static HttpResponse Contact(HttpRequest request)
    {
        var content = "<h1>contact</h1>";
        byte[] stringContent = Encoding.UTF8.GetBytes(content.ToString());
        var response = new HttpResponse(HttpReponseCode.Ok, stringContent);
        response.Headers.Add(new Header("Content-Type", "text/html"));
        return response;
    }

    public static HttpResponse Index(HttpRequest request)
    {
        var content = "<h1>home page</h1>";
        byte[] stringContent = Encoding.UTF8.GetBytes(content.ToString());
        var response = new HttpResponse(HttpReponseCode.Ok, stringContent);
        response.Headers.Add(new Header("Content-Type", "text/html"));
        return response;
    }

    public static HttpResponse Login(HttpRequest request)
    {
        var content = "<h1>login page</h1>";
        byte[] stringContent = Encoding.UTF8.GetBytes(content.ToString());
        var response = new HttpResponse(HttpReponseCode.Ok, stringContent);
        response.Headers.Add(new Header("Content-Type", "text/html"));
        return response;
    }

    public static HttpResponse DoLogin(HttpRequest request)
    {
        var content = "<h1>login page</h1>";
        byte[] stringContent = Encoding.UTF8.GetBytes(content.ToString());
        var response = new HttpResponse(HttpReponseCode.Ok, stringContent);
        response.Headers.Add(new Header("Content-Type", "text/html"));
        return response;
    }
}