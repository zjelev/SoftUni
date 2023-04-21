using Domain;
using Microsoft.AspNetCore.Identity;

namespace Eventures.Data
{
    public class RoleSeeder : ISeeder
    {
        private readonly EventuresDbContext _context;

        public RoleSeeder(EventuresDbContext context)
        {
            this._context = context;
        }
        public void Seed()
        {
            if (!_context.Roles.Any())
            {
                _context.Roles.Add(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" });
                _context.Roles.Add(new IdentityRole { Name = "User", NormalizedName = "USER" });
            }

            _context.SaveChanges();
        }
    }
}
