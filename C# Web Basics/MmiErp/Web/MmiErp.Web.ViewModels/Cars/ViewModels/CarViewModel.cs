using MmiErp.Data.Common.Models;
using MmiErp.Services.Mapping;
using System;

namespace MmiErp.Web.ViewModels.Cars.ViewModel
{
    public class CarViewModel : IMapFrom<Car>
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}