using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P03_SalesDatabase.Data.Models
{
    public class Customer
    {
        public Customer()
        {
            this.Sales = new HashSet<Sale>();
        }
        [Key]
        public int CustomerId { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } // (unicode)

        [Required]
        [MaxLength(80)]
        public string Email { get; set; } // (up to 80 characters, not unicode)
        public string CreditCardNumber { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }

    }
}