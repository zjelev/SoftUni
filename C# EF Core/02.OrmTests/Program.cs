// dotnet add package Microsoft.EntityFrameworkCore.SqlServer
// dotnet tool install --global dotnet-ef
// dotnet add package Microsoft.EntityFrameworkCore.Design

/* Datanase first
// dotnet ef dbcontext scaffold "Server = .;Database=SoftUni;Integrated Security=true" Microsoft.EntityFrameworkCore.SqlServer -o Models 
*/

/* Code first
// dotnet ef migrations bundle --force --verbose // close folder first
// // dotnet ef database update //does not create tables
*/
using System;
using System.Linq;
using System.Security.Cryptography;
using OrmTests.Models;

namespace OrmTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //SHA256.Create();
            var dbContext = new SoftUniContext();
            var employees = dbContext.Employees.Where(x => x.Department.Manager.Department.Name == "Sales")
                .Select(x => new
                {
                    Name = x.FirstName + ' ' + x.LastName,
                    DepartmentName = x.Department.Name,
                    Manage = x.Manager.FirstName + ' ' + x.Manager.LastName
                });

            var employeeGroups = dbContext.Employees
                .GroupBy(x => x.Department.Name)
                .Where(x => x.Count() > 10) //HAVING
                .Select(x => new
                {
                    DepartmentName = x.Key,
                    CountEmployees = x.Count()
                });

            foreach (var empl in employeeGroups)
            {
                Console.WriteLine(empl.DepartmentName + " => " + empl.CountEmployees);
            }

            // Console.WriteLine(dbContext.Employees
            //      .Where(x =>
            //     x.FirstName.StartsWith("Hu")));

            Employee employee = dbContext.Employees.FirstOrDefault(x => x.EmployeeId == 1);
            Console.WriteLine(employee.FirstName);


            dbContext.Students.Where(x => x.Grades.All(g => g.Value > 4.50M));
            dbContext.Students.Where(x => x.Grades.Average(g => g.Value) > 4.50M);
            dbContext.Students.Add(new Student() { FirstName = "John", LastName = "Doe" } );

            //dbContext.Add(new DbSet<Student>());
            dbContext.SaveChanges();  //how to create new tables? DropCreateDatabaseIfModelChanges?

            bool exists = dbContext.Students.Any(x => x.FirstName.StartsWith("J"));
            Console.WriteLine(dbContext.Students.Count(x => x.FirstName == "john"));

            //DbContext e Unit of Work pattern
            //DbSet e Repository pattern
        }
    }
}
