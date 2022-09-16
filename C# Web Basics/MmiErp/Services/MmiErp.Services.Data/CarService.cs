namespace MmiErp.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MmiErp.Data.Common.Models;
    using MmiErp.Data.Common.Repositories;

    public class CarService : ICarService
    {
        private readonly IDeletableEntityRepository<Car> carRepository;

        public CarService(IDeletableEntityRepository<Car> carRepository)
        {
            this.carRepository = carRepository;
        }
        public async Task AddAsync(string make, string model, decimal price)
        {
            var car = new Car
            {
                Id = Guid.NewGuid().ToString(),
                Make = make,
                Model = model,
                Price = price
            };

            await this.carRepository.AddAsync(car);
            await this.carRepository.SaveChangesAsync();
        }
    }
}
