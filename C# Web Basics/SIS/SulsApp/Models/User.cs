using System.ComponentModel.DataAnnotations;
using SIS.MvcFramework;

namespace SulsApp.Models
{
    public class User : IdentityUser<string>
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Submissions = new HashSet<Submission>();
        }

        public virtual ICollection<Submission> Submissions { get; set; }
    }
}