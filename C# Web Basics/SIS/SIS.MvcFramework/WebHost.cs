using SIS.Http;
using SIS.Http.Response;

namespace SIS.MvcFramework
{
    public class WebHost
    {
        public static async Task StartAsync(IMvcApplication application)
        {
            var routeTable = new List<Route>();
            application.ConfigureServices();
            application.Configure(routeTable);
            AutoRegisterRoutes(routeTable, application);

            foreach (var route in routeTable)
            {
                Console.WriteLine(route);
            }

            var httpServer = new HttpServer(80, routeTable);
            await httpServer.StartAsync();
        }

        public static void AutoRegisterRoutes(List<Route> routeTable, IMvcApplication application)
        {
            var staticFiles = Directory.GetFiles("wwwroot", "*", SearchOption.AllDirectories);
            foreach (var staticFile in staticFiles)
            {
                var path = staticFile.Replace("wwwroot", string.Empty).Replace("\\", "/");
                routeTable.Add(new Route(HttpMethodType.Get, path, (request) =>
                {
                    var fileInfo = new FileInfo(staticFile);
                    var contentType = fileInfo.Extension switch
                    {
                        ".css" => "text",
                        ".html" => "text/html",
                        ".js" => "text/javascript",
                        ".ico" => "image/vnd.microsoft.icon",
                        ".jpg" => "image/jpeg",
                        ".jpeg" => "image/jpeg",
                        ".png" => "image/png",
                        ".gif" => "image/gif",
                        _ => "text/plain"
                    };
                return new FileResponse(File.ReadAllBytes(staticFile), contentType);
                }));
            }
        }
    }
}