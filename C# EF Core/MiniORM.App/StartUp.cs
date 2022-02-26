namespace MiniORM.App // Note: actual namespace depends on the project name.
{
    using Data;
    using Data.Entities;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=.;database=MiniORM;Integrated Security=True";
            var context = new SoftUniDbContext(connectionString);

            context.Employees.Add(new Employee
            {
                FirstName = "Ivan",
                LastName = "Inserted",
                DepartmentId = context.Departments.First().Id,
                IsEmployed = true,
            });

            var employee = context.Employees.Last();
            employee.LastName = "Ivanov";

            context.Departments.Add(new Department
            {
                Name = "Sales"
            });

            context.SaveChanges();
        }
    }
}
