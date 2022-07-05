using System.ComponentModel.DataAnnotations;

namespace P01_HospitalDatabase.Data.Models
{
    public class Patient
    {
        [Key]
        public string PatientId { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; } // unicode)
        
        [MaxLength(50)]
        public string LastName { get; set; } // unicode)

        [MaxLength(250)]
        public string Address { get; set; } // unicode)

        [MaxLength(80)]
        public string Email { get; set; } // not unicode)
        
        public bool HasInsurance { get; set; }

    }
}