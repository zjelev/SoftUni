using SIS.Http;
using SIS.MvcFramework;
using SulsApp.ViewModels;

namespace SulsApp.Controllers
{
    class HomeController : Controller
    {
        [HttpGet("/")]
        public HttpResponse Index(HttpRequest request)
        {
            var viewModel = new IndexViewModel
            {
                Message = "Welcome to SULS Platform!",
                Year = DateTime.UtcNow.Year,
            };
            return this.View(viewModel);
        }
    }
}