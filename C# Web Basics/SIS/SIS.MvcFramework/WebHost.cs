using System.Reflection;
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
            AutoRegisterStaticFilesRoutes(routeTable);
            AutoRegisterActionRoutes(routeTable, application);

            foreach (var route in routeTable)
            {
                Console.WriteLine(route);
            }

            var httpServer = new HttpServer(80, routeTable);
            await httpServer.StartAsync();
        }

        private static void AutoRegisterActionRoutes(List<Route> routeTable, IMvcApplication application)
        {
            //Assembly.GetEntryAssembly().GetTypes()
            var types = application.GetType().Assembly.GetTypes()
            .Where(type => type.IsSubclassOf(typeof(Controller)) && !type.IsAbstract);
            foreach (var type in types)
            {
                Console.WriteLine(type.FullName);
                var methods = type.GetMethods()
                    .Where(x => !x.IsSpecialName 
                    && !x.IsConstructor
                    && x.IsPublic
                    && x.DeclaringType == type);
                foreach (var method in methods)
                {
                    string url = "/" + type.Name.Replace("Controller", string.Empty) + "/" + method.Name;

                    var attribute = method.GetCustomAttributes()
                        .FirstOrDefault(x => x.GetType()
                        .IsSubclassOf(typeof(HttpMethodAttribute)))
                        as HttpMethodAttribute;
                    var httpActionType = HttpMethodType.Get;
                    if (attribute != null)
                    {
                        httpActionType = attribute.Type;
                        if (attribute.Url != null)
                        {
                            url = attribute.Url;
                        }
                    }
                    
                    routeTable.Add(new Route(httpActionType, url, (request) =>
                    {
                        var controller = Activator.CreateInstance(type) as Controller;
                        controller.Request = request;
                        var response = method.Invoke(controller, new object[] { }) as HttpResponse;
                        return response;
                    }));
                    Console.WriteLine(url);
                }
            }
        }

        public static void AutoRegisterStaticFilesRoutes(List<Route> routeTable)
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
                        ".ico" => "image/x-icon",
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