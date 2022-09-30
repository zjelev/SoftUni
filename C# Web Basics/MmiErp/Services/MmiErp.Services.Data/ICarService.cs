namespace MmiErp.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICarService
    {
        Task AddAsync(string make, string model, decimal price);

        Task<IEnumerable<T>> GetAllCars<T>();
    }
}
