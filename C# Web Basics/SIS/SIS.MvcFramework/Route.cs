using SIS.Http;

namespace SIS.MvcFramework
{
    public class Route
    {
        public string Path { get; set; }
        public HttpMethodType HttpMethod { get; set; }
    }
}