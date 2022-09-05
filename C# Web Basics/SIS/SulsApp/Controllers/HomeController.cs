using SIS.Http;

namespace SulsApp.Controllers
{
    class HomeController
    {
        public HttpResponse Index(HttpRequestException request)
        {
            return new HtmlResponse("<h1>Hello</h1>");
        }
    }
}