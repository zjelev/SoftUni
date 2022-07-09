using System.Collections.Generic;
using P03_SalesDatabase.Data.Models;

namespace P03_SalesDatabase.Data
{
    public class StoreSeeder : ISeeder
    {
        private readonly SalesContext dbContext;

        public StoreSeeder(SalesContext context)
        {
            this.dbContext = context;
        }
        public void Seed()
        {
            Store[] stores = new Store[]
            {
                new Store {Name = "PcTech Sofia"},
                new Store {Name = "PcTech Varna"},
                new Store {Name = "InnovativeTech Sofia"},
                new Store {Name = "SoftSystems"},
            };

            this.dbContext.Stores.AddRange(stores);
            this.dbContext.SaveChanges();
        }
    }
}