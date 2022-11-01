using SIS.Http;
using SIS.Http.Logging;
using SIS.MvcFramework;
using SulsApp.ViewModels;

namespace SulsApp.Controllers
{
    class HomeController : Controller
    {
        private readonly ILogger logger;

        public HomeController(ILogger logger)
        {
            this.logger = logger;
        }
        [HttpGet("/")]
        public HttpResponse Index()
        {
            this.logger.Log("Hello from Index");
            var viewModel = new IndexViewModel
            {
                Message = this.Request?.Headers.FirstOrDefault(x => x.Name == "User-Agent")?.Value!,
                Year = DateTime.UtcNow.Year,
            };
            return this.View(viewModel);
        }
    }
}