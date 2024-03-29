﻿using System;
using System.Collections.Generic;
using P03_SalesDatabase.Data;

namespace P03_SalesDatabase
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var dbContext = new SalesContext();

            var seeders = new List<ISeeder>();
            seeders.Add(new ProductSeeder(dbContext));
            seeders.Add(new StoreSeeder(dbContext));

            foreach (ISeeder seeder in seeders)
            {
                seeder.Seed();
            }
        }
    }
}