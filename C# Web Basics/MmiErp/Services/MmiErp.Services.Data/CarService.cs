namespace MmiErp.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using MmiErp.Data.Common.Models;
    using MmiErp.Data.Common.Repositories;
    using MmiErp.Services.Mapping;

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

        public async Task<IEnumerable<T>> GetAllCars<T>()
        {
            return await this.carRepository
                .AllAsNoTracking()
                .To<T>()
                .ToArrayAsync();
        }
    }
}
