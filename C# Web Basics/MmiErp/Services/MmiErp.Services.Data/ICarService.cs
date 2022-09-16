namespace MmiErp.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICarService
    {
        Task AddAsync(string make, string model, decimal price);
    }
}
