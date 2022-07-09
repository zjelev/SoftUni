using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P01_HospitalDatabase.Data.Models
{
    public class Doctor
    {
        public Doctor()
        {
            this.Visitations = new HashSet<Visitation>();
        }

        [Key]
        public int DoctorId { get; set; }
        
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Specialty { get; set; }

        public string UserName { get; set; }

        [RegularExpression( "^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$" , ErrorMessage = "Invalid email format." )] 
        public string Email { get; set; }

        public string Passwd { get; set; }

        public virtual ICollection<Visitation> Visitations { get; set; }
    }
}