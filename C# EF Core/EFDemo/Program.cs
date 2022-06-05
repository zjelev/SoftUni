using System;

namespace EFDemo
{
    using Models;
    internal class Program
    {
        static void Main(string[] args)
        {
            // dotnet add package Microsoft.EntityFrameworkCore.SqlServer
            // dotnet add package Microsoft.EntityFrameworkCore.SqlServer.Design   // or Tools 
            // dotnet tool install --global dotnet-ef

            // string ->  MAX, Unicode  DB -> char(50)   => EF Fluent API
            // dotnet ef dbcontext scaffold "Server=.\SQLEXPRESS;Database=SuTest;Integrated Security=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models -f --data-annotations
            
            // SQL Server Profiler -> Use the template = TSQL_Duration

            // Always use Select().ToList() - get from db only what you need!

            var db = new SuTestContext();
            // Console.WriteLine(db.Employees.Count());
            //Console.WriteLine(db.Employees.Count(x => x.Projects.Count() > 3));
            // var employees = db.Employees.ToList(); //Don't do that, use Select before ToList
            var employees = db.Employees.Select(x =>
                new
                {
                    x.LastName,
                    NumProjects = x.Projects.Count()
                }).OrderByDescending(x => x.NumProjects).Take(50)
                .ToList();

            foreach (var empl in employees)
            {
                System.Console.WriteLine($"{empl.LastName} => {empl.NumProjects}");
            }

            int? a = null;
            DateTime? d = DateTime.UtcNow;
            d = null;
        }
    }
}
