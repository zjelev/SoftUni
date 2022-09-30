using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MmiErp.Services.Data;
using MmiErp.Web.ViewModels.Cars.InputModels;
using MmiErp.Web.ViewModels.Cars.ViewModel;

namespace MmiErp.Web.Controllers
{
    public class CarsController : BaseController
    {
        private readonly ICarService carService;

        public CarsController(ICarService carService)
        {
            this.carService = carService;
        }
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateCarInputModel inputModel)
        {
            await this.carService.AddAsync(inputModel.Make, inputModel.Model, inputModel.Price);
            
            return this.Redirect("/");
        }

        public async Task<IActionResult> All()
        {
            var allCars = await this.carService.GetAllCars<CarViewModel>();

            return this.View(allCars);
        }
    }
}
