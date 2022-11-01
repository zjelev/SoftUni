using System.Reflection;
using SIS.Http;
using SIS.Http.Logging;
using SIS.Http.Response;

namespace SIS.MvcFramework
{
    public class WebHost
    {
        public static async Task StartAsync(IMvcApplication application)
        {
            IList<Route> routeTable = new List<Route>();
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.Add<ILogger, ConsoleLogger>();

            application.ConfigureServices(serviceCollection);
            application.Configure(routeTable);
            AutoRegisterStaticFilesRoutes(routeTable);
            AutoRegisterActionRoutes(routeTable, application, serviceCollection);
            
            var logger = serviceCollection.CreateInstance<ILogger>();
            logger.Log("Registered routes:");
            foreach (var route in routeTable)
            {
                logger.Log(route.ToString());
            }

            logger.Log(string.Empty);
            logger.Log("Requests:");
            var httpServer = new HttpServer(80, routeTable, logger);
            await httpServer.StartAsync();
        }

        // /{controller}/{action}

        private static void AutoRegisterActionRoutes(IList<Route> routeTable, IMvcApplication application, IServiceCollection serviceCollection)
        {
            //Assembly.GetEntryAssembly().GetTypes()
            var controllers = application.GetType().Assembly.GetTypes()
                .Where(type => type.IsSubclassOf(typeof(Controller)) && !type.IsAbstract);
            foreach (var controller in controllers)
            {
                // Console.WriteLine(controller.FullName);
                var actions = controller.GetMethods()
                    .Where(x => !x.IsSpecialName
                    && !x.IsConstructor
                    && x.IsPublic
                    && x.DeclaringType == controller);
                foreach (var action in actions)
                {
                    string url = "/" + controller.Name.Replace("Controller", string.Empty) + "/" + action.Name;

                    var attribute = action.GetCustomAttributes()
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

                    routeTable.Add(new Route(httpActionType, url, (request) => InvokeAction(request, serviceCollection, controller, action)));
                }
            }
        }

        private static HttpResponse InvokeAction(HttpRequest request, IServiceCollection serviceCollection,
                Type controllerType, MethodInfo actionMethod)
        {
            var controller = serviceCollection.CreateInstance(controllerType) as Controller;
            controller.Request = request;

            var actionsParameterValues = new List<object>();
            var actionsParameters = actionMethod.GetParameters();
            foreach (var parameter in actionsParameters)
            {
                var parameterName = parameter.Name.ToLower();
                object value = null;

                if (request.QueryData.Any(x => x.Key.ToLower() == parameterName))
                {
                    value = request.FormData.FirstOrDefault(x => x.Key.ToLower() == parameterName).Value;
                }
                else if (request.FormData.Any(x => x.Key.ToLower() == parameterName))
                {
                    value = request.FormData.FirstOrDefault(x => x.Key.ToLower() == parameterName).Value;
                }

                actionsParameterValues.Add(value);
            }
            var response = actionMethod.Invoke(controller, new object[] { }) as HttpResponse;
            return response;
        }


        public static void AutoRegisterStaticFilesRoutes(IList<Route> routeTable)
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