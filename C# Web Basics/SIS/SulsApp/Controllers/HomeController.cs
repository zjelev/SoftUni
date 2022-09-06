using SIS.Http;
using SIS.Http.Response;
using SIS.MvcFramework;

namespace SulsApp.Controllers
{
    class HomeController : Controller
    {
        public HttpResponse Index(HttpRequest request)
        {
            return this.View();
        }
    }
}