using System;

namespace EFDemo
{
    using Models;
    internal class Program
    {
        static void Main(string[] args)
        {
            // dotnet add package Microsoft.EntityFrameworkCore.SqlServer
            // dotnet add package Microsoft.EntityFrameworkCore.SqlServer.Design
            // dotnet tool install --global dotnet-ef

            // string ->  MAX, Unicode  DB -> char(50) => EF Fluent Api
            // dotnet ef dbcontext scaffold "Server=.;Database=SoftUni;Integrated Security=true;" 
                //Microsoft.EntityFrameworkCore.SqlServer -o Models -f --data-annotations
            
            // SQL Server Profiler -> Use the template = TSQL_Duration

            // Always use Select().ToList()

            var db = new SoftUniContext();
            Console.WriteLine(db.Employees.Count(x => x.Projects.Count() > 2));

        }
    }
}
