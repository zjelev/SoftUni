using System.ComponentModel.DataAnnotations;

namespace OrmTests.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        public decimal Value { get; set; }
        [MaxLength(50)]
        public Student Student { get; set; }
    }
}