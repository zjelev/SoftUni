// dotnet ef database update
using SIS.MvcFramework;

namespace DemoApp
{
    public static class Program
    {
        private static async Task Main()
        {
            await WebHost.StartAsync(new Startup());
        }
    }
}
