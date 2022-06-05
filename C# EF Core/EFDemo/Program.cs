// dotnet add package Microsoft.EntityFrameworkCore.SqlServer
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer.Design   // or Tools
// dotnet tool install --global dotnet-ef
// dotnet ef dbcontext scaffold "Server=.\SQLEXPRESS;Database=SuTest;Integrated Security=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models -f --data-annotations
// SQL Server Profiler -> Use the template = TSQL_Duration, or expressprofiler.codeplex.com or Microsoft.Extensions.Logging 

// string ->  MAX, Unicode  DB -> char(50)   => EF Fluent API

using System;
using Microsoft.EntityFrameworkCore;

namespace EFDemo
{
    using Models;
    internal class Program
    {

        static void Main(string[] args)
        {
            int? a = null;
            DateTime? d = DateTime.UtcNow;
            d = null;

            DbContextOptionsBuilder<SuTestContext> optionsBuilder = new DbContextOptionsBuilder<SuTestContext>();
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SuTest;Integrated Security=true");
            using (SuTestContext db = new SuTestContext(optionsBuilder.Options))
            {
                
                // db.Database.EnsureCreated(); // creates new DB without the data
                // db.Database.EnsureDeleted();
                var firstEmployee = db.Employees.Find(1);
                firstEmployee.FirstName = "Niki";
                db.SaveChanges();
                System.Console.WriteLine("{0} {1}", firstEmployee.FirstName, firstEmployee.LastName);

                // Console.WriteLine(db.Employees.Count());
                // Console.WriteLine(db.Employees.Count(x => x.Projects.Count() > 3));
                // var employees = db.Employees.ToList(); //Don't do that, always use Select().ToList() - get from db only what you need!
                var employees = db.Employees.Select(x =>
                    new
                    {
                        x.LastName,
                        NumProjects = x.Projects.Count()
                    }).OrderByDescending(x => x.NumProjects).Skip(10).Take(50)
                    .ToList(); // tuk ve4e postroqva zayavkata i 4ete ot DB - materializacia na dannite; Sled toList zavbravete za DB, vsi4ko se slu4va lokalno; finalem method
                               // drugi finalni metodi sa ToDictionary(), ToArray(), FirstOrDefault();  tqh gi pishem ni-otzad

                //Linq-to-Entities - lokalno
                //Linq-to-SQL - za DB

                foreach (var empl in employees)
                {
                    System.Console.WriteLine($"{empl.LastName} => {empl.NumProjects}");
                }
            }
        }
    }
}

namespace EFDemo.Models
{
    using Microsoft.Extensions.Logging;
    public partial class SuTestContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Test;Integrated Security=true;");
            }
        }
    }
}
