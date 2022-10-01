using System.Runtime.CompilerServices;
using SIS.Http;
using SIS.Http.Response;

namespace SIS.MvcFramework
{
    public abstract class Controller
    {
        protected HttpResponse View<T>(T viewModel = null, [CallerMemberName]string viewName = null)
            where T : class
        {
            IViewEngine viewEngine = new ViewEngine();
            var typeName = this.GetType().Name;
            var controllerName = typeName.Substring(0, typeName.Length - 10); // Replace("Controller", string.Empty); // взема името на класа, в който се изпълнява кода в момента (ако в HomeController ще вземе него) 

            // other ways to do that:

            // Environment.StackTrace...

            // var st = new System.Diagnostics.StackTrace();
            // st.GetFrames().Skip()...

            // not recommended (slow):
            // try
            // {
            //     throw new Exception();
            // }
            // catch (Exception ex)
            // {
            //     ex.StackTrace
            // }

            var html = File.ReadAllText("Views/" + controllerName + "/" + viewName + ".html");
            html = viewEngine.GetHtml(html, viewModel);

            var layout = File.ReadAllText("Views/Shared/_Layout.html");
            var bodyWithLayout = layout.Replace("@RenderBody()", html);
            bodyWithLayout = viewEngine.GetHtml(bodyWithLayout, null);

            return new HtmlResponse(bodyWithLayout);
        }
        protected HttpResponse View([CallerMemberName] string viewName = null)
        {
            return this.View<object>(null, viewName);
        }
    }
}