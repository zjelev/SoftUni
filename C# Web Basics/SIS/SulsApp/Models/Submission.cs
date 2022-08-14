namespace SulsApp.Models
{
    public class Submission
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(800)]
        public string Code { get; set; }

        public int AchievedResult { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual Problem Problem { get; set; }
        public virtual User User { get; set; }
    }
}