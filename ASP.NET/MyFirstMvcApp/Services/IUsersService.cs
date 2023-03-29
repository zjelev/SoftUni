namespace MyFirstMvcApp.Services;

public interface IUsersService
{
    int GetCount();
    IEnumerable<string> GetUsernames();
    string LatestUserName(string orderBy = "username");
}
