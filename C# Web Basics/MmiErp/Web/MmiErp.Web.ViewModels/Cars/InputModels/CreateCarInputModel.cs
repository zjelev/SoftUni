using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmiErp.Web.ViewModels.Cars.InputModels
{
    public class CreateCarInputModel
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}
