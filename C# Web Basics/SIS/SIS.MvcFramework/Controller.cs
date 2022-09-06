using SIS.Http;
using SIS.Http.Response;

namespace SIS.MvcFramework
{
    public abstract class Controller
    {
        protected HttpResponse View(string viewPath)
        {
            var layout = File.ReadAllText("Views/Shared/_Layout.html");
            var className = this.GetType();
            var html = File.ReadAllText("Views/" + viewPath);
            var bodyWithLayout = layout.Replace("@RenderBody()", html);
            return new HtmlResponse(bodyWithLayout);
        }
    }
}