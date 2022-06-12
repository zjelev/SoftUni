// dotnet add package Microsoft.EntityFrameworkCore.Tools -v 3.1.3
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer.Design
// dotnet ef dbcontext scaffold "Server=.;Database=SoftUni;Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer -o Data\Models

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using SoftUni.Data;
using SoftUni.Models;

namespace SoftUni
{
    public class StartUp
    {
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();
            string result = RemoveTown(context);
            Console.WriteLine(result);
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var employees = context
                .Employees
                .Select(e => new
                {
                    e.EmployeeId,
                    e.FirstName,
                    e.LastName,
                    e.MiddleName,
                    e.JobTitle,
                    e.Salary
                })
                .OrderBy(e => e.EmployeeId)
                .ToList();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var employees = context
                .Employees
                .Where(e => e.Salary > 50000)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ToList();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} - {e.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var employees = context
                .Employees
                .Where(e => e.Department.Name.Equals("Research and Development"))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    DepartmentName = e.Department.Name,
                    e.Salary
                })
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .ToList();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} from {e.DepartmentName} - ${e.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            Address address = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            Employee employee = context
                .Employees
                .FirstOrDefault(e => e.LastName == "Nakov");

            context.Addresses.Add(address); // Can be omitted
            employee.Address = address;

            context.SaveChanges();

            List<string> addresses = context
                .Employees
                .OrderByDescending(e => e.AddressId)
                .Take(10)
                .Select(e => e.Address.AddressText)
                .ToList();

            foreach (var a in addresses)
            {
                sb.AppendLine($"{a}");
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder strb = new StringBuilder();
            var employees = context
                .Employees
                .Where(e => e.EmployeesProjects
                    .Any(ep => ep.Project.StartDate.Year >= 2001 &&
                               ep.Project.StartDate.Year <= 2003))
                .Take(10)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    ManagerFirstName = e.Manager.FirstName,
                    ManagerLastName = e.Manager.LastName,
                    Project = e.EmployeesProjects
                        .Select(ep => new
                        {
                            ProjectName = ep.Project.Name,
                            StartDate = ep.Project
                                .StartDate
                                .ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                            EndDate = ep.Project.EndDate.HasValue ?
                                ep.Project
                                    .EndDate
                                    .Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                                : "not finished"
                        }).ToList()
                }).ToList();

            foreach (var e in employees)
            {
                strb.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.ManagerFirstName} {e.ManagerLastName}");
                foreach (var ep in e.Project)
                {
                    strb.AppendLine($"--{ep.ProjectName} - {ep.StartDate} - {ep.EndDate}");
                }
            }
            return strb.ToString().TrimEnd();
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            StringBuilder strb = new StringBuilder();
            var addresses = context.Addresses
               .Select(a => new
               {
                   a.AddressText,
                   a.TownId,
                   TownName = a.Town.Name,
                   EmployeesCount = a.Employees.Count
               }).OrderByDescending(a => a.EmployeesCount)
               .ThenBy(a => a.TownName)
               .ThenBy(a => a.AddressText)
               .Take(10)
               .ToList();

            foreach (var a in addresses)
            {
                strb.AppendLine($"{a.AddressText}, {a.TownName} - {a.EmployeesCount} employees");
            }
            return strb.ToString().TrimEnd();
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            StringBuilder strb = new StringBuilder();

            var employee147 = context
                .Employees
                .Where(e => e.EmployeeId == 147)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    Projects = e.EmployeesProjects
                        .Select(ep => ep.Project.Name)
                        .OrderBy(pn => pn)
                        .ToList()
                }).Single();

            strb.AppendLine($"{employee147.FirstName} {employee147.LastName} - {employee147.JobTitle}");
            foreach (var projectName in employee147.Projects)
            {
                strb.AppendLine(projectName);
            }
            return strb.ToString().TrimEnd();
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            StringBuilder strb = new StringBuilder();

            var departments = context
                .Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(d => new
                {
                    d.Name,
                    ManagerFirstName = d.Manager.FirstName,
                    ManagerLastName = d.Manager.LastName,
                    DepEmployees = d.Employees
                        .Select(e => new
                        {
                            EmplFirstName = e.FirstName,
                            EmplLastName = e.LastName,
                            e.JobTitle
                        })
                        .OrderBy(e => e.EmplFirstName)
                        .ThenBy(e => e.EmplLastName)
                        .ToList()
                })
                .ToList();

            foreach (var department in departments)
            {
                strb.AppendLine($"{department.Name} - {department.ManagerFirstName} {department.ManagerLastName}");
                foreach (var employee in department.DepEmployees)
                {
                    strb.AppendLine($"{employee.EmplFirstName} {employee.EmplLastName} - {employee.JobTitle}");
                }
            }
            return strb.ToString().TrimEnd();
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            StringBuilder strb = new StringBuilder();

            var projects = context
                .Projects
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.StartDate
                })
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .OrderBy(p => p.Name)
                .ToList();

            foreach (var pr in projects)
            {
                strb.AppendLine($"{pr.Name}");
                strb.AppendLine($"{pr.Description}");
                strb.AppendLine($"{pr.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}");
            }

            return strb.ToString().TrimEnd();
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            StringBuilder strb = new StringBuilder();

            IQueryable<Employee> employeesIncr = context
                .Employees
                .Where(e => e.Department.Name == "Engineering" ||
                            e.Department.Name == "Tool Design" ||
                            e.Department.Name == "Marketing" ||
                            e.Department.Name == "Information Services");

            foreach (var empl in employeesIncr)
            {
                empl.Salary += empl.Salary * 0.12m;
            }

            context.SaveChanges();

            var employeesInfo = employeesIncr
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            foreach (var e in employeesInfo)
            {
                strb.AppendLine($"{e.FirstName} {e.LastName} (${e.Salary:f2})");
            }

            return strb.ToString().TrimEnd();
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            StringBuilder strb = new StringBuilder();

            var employeesSa = context
                .Employees
                .Where(e => e.FirstName.Substring(0, 2).ToLower() == "sa")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                }).OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            foreach (var e in employeesSa)
            {
                strb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})");
            }
            return strb.ToString().TrimEnd();
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            StringBuilder strb = new StringBuilder();

            var project2 = context
                .Projects
                .Find(2);

            foreach (var ep in context.EmployeesProjects)
            {
                if (ep.ProjectId == 2)
                {
                    context.EmployeesProjects.Remove(ep);
                }
            }

            context.SaveChanges();

            context.Projects.Remove(project2);

            context.SaveChanges();

            var projects = context
                .Projects
                .Select(p => new
                {
                    p.Name
                }).ToList();

            foreach (var pr in projects)
            {
                strb.AppendLine($"{pr.Name}");
            }

            return strb.ToString().TrimEnd();
        }

        public static string RemoveTown(SoftUniContext context)
        {
            Town townToDel = context
                .Towns
                .First(t => t.Name == "Seattle");

            IQueryable<Address> addressesToDel = context
                .Addresses
                .Where(a => a.TownId == townToDel.TownId);

            int addressesCount = addressesToDel.Count();

            IQueryable<Employee> employeesOnDelAddr = context
                .Employees
                .Where(e => addressesToDel
                .Any(a => a.AddressId == e.AddressId));

            foreach (var empl in employeesOnDelAddr)
            {
                empl.AddressId = null;
            }

            foreach (var address in addressesToDel)
            {
                context.Addresses.Remove(address);
            }

            context.Towns.Remove(townToDel);

            context.SaveChanges();

            return $"{addressesCount} addresses in {townToDel.Name} were deleted";
        }
    }
}
