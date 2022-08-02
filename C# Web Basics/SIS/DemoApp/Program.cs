// Actions
// / => IndexPage()
// /favicon.ico => favicon.ico
// GET /Contact => response ShowContactForm(request) 
// POST /Contact => response FillContactForm(request) 

using System.Text;
using SIS.Http;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var httpServer = new HttpServer(80);
        await httpServer.StartAsync();
    }

    public HttpResponse Index(HttpRequest request)
    {
        var content = "<h1>home page</h1>";
        byte[] stringContent = Encoding.UTF8.GetBytes(content.ToString());
        var response = new HttpResponse(HttpReponseCode.Ok, stringContent);
        return response;
    }

    public HttpResponse Login(HttpRequest request)
    {
        var content = "<h1>login page</h1>";
        byte[] stringContent = Encoding.UTF8.GetBytes(content.ToString());
        var response = new HttpResponse(HttpReponseCode.Ok, stringContent);
        return response;
    }

        public HttpResponse DoLogin(HttpRequest request)
    {
        var content = "<h1>login page</h1>";
        byte[] stringContent = Encoding.UTF8.GetBytes(content.ToString());
        var response = new HttpResponse(HttpReponseCode.Ok, stringContent);
        return response;
    }
}