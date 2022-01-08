using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AdoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Server = .\SQLEXPRESS; Database = SoftUni; Integrated security = true;";
            int result;
            IList<Employee> employees = new List<Employee>();

            using (SqlConnection dbCon = new SqlConnection(connString))
            {
                dbCon.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "SELECT TOP 10 * FROM Employees WHERE DepartmentId = @deptId";
                    command.Connection = dbCon;
                    // SqlParameter param = new SqlParameter();
                    // param.DbType = System.Data.DbType.Int32;
                    // param.ParameterName = "@deptId";
                    // param.Value = 7;

                    command.Parameters.AddWithValue("@deptId", 7);

                    result = (int)command.ExecuteScalar();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                         while (reader.Read())
                         {
                              employees.Add(new Employee() 
                              {
                                  FirstName = reader["FirstName"]?.ToString(),
                                  MiddleName = reader["MiddleName"]?.ToString(),
                                  LastName = reader[2]?.ToString(),

                              });
                         }
                    }
                }
            }

            Console.WriteLine($"There are {result} rows");

            foreach (var item in employees)
            {
                Console.WriteLine($"{item.FirstName} {item.MiddleName} {item.LastName}");
            }
        }
    }
}
