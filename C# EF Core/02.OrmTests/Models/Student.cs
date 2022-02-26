using System.Collections.Generic;

namespace OrmTests.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }

}