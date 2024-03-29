using System.ComponentModel.DataAnnotations;

namespace DemoApp
{
    public class Tweet
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        [Required]
        public string Creator { get; set; } = null!;

        [Required]
        public string Content { get; set; } = null!;
    }
}