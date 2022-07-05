using System.ComponentModel.DataAnnotations;

namespace P01_HospitalDatabase.Data.Models
{
    public class Medicament
    {
        [Key]
        public int MedicamentId { get; set; }

        [Required]
        [MaxLength(50)]
        public int Name { get; set; }
    }
}