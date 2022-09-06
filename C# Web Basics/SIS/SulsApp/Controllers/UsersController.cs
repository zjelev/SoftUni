using SIS.Http;
using SIS.Http.Response;
using SIS.MvcFramework;

namespace SulsApp.Controllers
{
    class UsersController : Controller
    {
        public HttpResponse Login(HttpRequest request)
        {
            return this.View("Users/Login.html");
        }

        public HttpResponse Register(HttpRequest request)
        {
            return this.View("Users/Register.html");
        }
    }
}