using SIS.Http;

namespace SIS.MvcFramework
{
    public interface IMvcApplication
    {
        void Configure(IList<Route> routetable);
        void ConfigureServices(IServiceCollection serviceCollection);
    }
}