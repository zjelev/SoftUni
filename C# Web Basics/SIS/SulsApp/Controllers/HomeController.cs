using SIS.Http;
using SIS.MvcFramework;
using SulsApp.ViewModels;

namespace SulsApp.Controllers
{
    class HomeController : Controller
    {
        [HttpGet("/")]
        public HttpResponse Index()
        {

            var viewModel = new IndexViewModel
            {
                Message = this.Request?.Headers.FirstOrDefault(x => x.Name == "User-Agent")?.Value!,
                Year = DateTime.UtcNow.Year,
            };
            return this.View(viewModel);
        }
    }
}