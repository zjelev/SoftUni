using SIS.MvcFramework;

namespace SulsApp
{
    public static class Program
    {
        private static async Task Main()
        {
            await WebHost.StartAsync(new Startup());
        }
    }
}