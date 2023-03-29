using Microsoft.AspNetCore.Identity;
using MyFirstMvcApp.Data;

namespace MyFirstMvcApp.Services;

public class UsersService : IUsersService
{
    private readonly ApplicationDbContext _dbContext;

    public UsersService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public int GetCount() => _dbContext.Users.Count();

    public IEnumerable<string> GetUsernames() =>
        _dbContext.Users.Select(x => x.UserName).ToList();

    public string LatestUserName(string orderBy = "username")
    {
        IQueryable<IdentityUser> query = this._dbContext.Users;
        if (orderBy == "username")
            query = query.OrderByDescending(x => x.UserName);
        else if (orderBy == "email")
            query = query.OrderByDescending(x => x.Email);

        return query.Select(x => x.UserName).FirstOrDefault();
    }
}