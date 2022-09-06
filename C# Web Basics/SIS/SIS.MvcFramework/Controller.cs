using System.Runtime.CompilerServices;
using SIS.Http;
using SIS.Http.Response;

namespace SIS.MvcFramework
{
    public abstract class Controller
    {
        protected HttpResponse View([CallerMemberName] string viewName = null)
        {
            var layout = File.ReadAllText("Views/Shared/_Layout.html");
            var controllerName = this.GetType().Name.Replace("Controller", string.Empty); // взема името на класа, в който се изпълнява кода в момента (ако в HomeController ще вземе него) 
            
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
            var bodyWithLayout = layout.Replace("@RenderBody()", html);
            return new HtmlResponse(bodyWithLayout);
        }
    }
}