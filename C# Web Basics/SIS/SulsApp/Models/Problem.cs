namespace SulsApp.Models
{
    public class Problem
    {
        public string Id { get; set; }

        [MaxLenght(20)]
        [Required]
        public string Name { get; set; }

        public int Points { get; set; }
    }
}