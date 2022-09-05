using SIS.Http;
using SIS.Http.Response;

namespace SulsApp.Controllers
{
    class HomeController
    {
        public HttpResponse Index(HttpRequest request)
        {
            return new HtmlResponse("<h1>Hello</h1>");
        }
    }
}