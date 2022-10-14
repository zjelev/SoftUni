using SIS.Http;
using SIS.MvcFramework;

namespace SulsApp
{
    public class Startup : IMvcApplication
    {
        public void ConfigureServices()
        {
            var db = new ApplicationDbContext();
            db.Database.EnsureCreated();
        }

        public void Configure(IList<Route> routeTable)
        {

        }
    }
}