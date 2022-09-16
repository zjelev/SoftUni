namespace MmiErp.Data.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car : BaseDeletableModel<string>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}
