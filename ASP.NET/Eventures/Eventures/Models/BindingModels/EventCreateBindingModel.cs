using System.ComponentModel.DataAnnotations;

namespace Eventures.Models.BindingModels
{
    public class EventCreateBindingModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Place")]
        public string Place { get; set; }

        [Required]
        [Display(Name = "Start")]
        public DateTime Start { get; set; }

        [Required]
        [Display(Name = "End")]
        public DateTime End { get; set; }

        [Required]
        [Display(Name = "TotalTickets")]
        public int TotalTickets { get; set; }

        [Required]
        [Display(Name = "PricePerTicket")]
        public decimal PricePerTicket { get; set; }
    }
}
