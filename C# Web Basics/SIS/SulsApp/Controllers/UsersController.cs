using SIS.Http;
using SIS.Http.Response;
using SIS.MvcFramework;

namespace SulsApp.Controllers
{
    class UsersController : Controller
    {
        public HttpResponse Login(HttpRequest request)
        {
            return this.View();
        }

        public HttpResponse Register(HttpRequest request)
        {
            return this.View();
        }
    }
}