namespace MmiErp.Data.Common.Models
{
    using System;

    public class Car : BaseDeletableModel<string>
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }
    }
}
