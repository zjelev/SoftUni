using System.Text;
using SIS.Http;

namespace SIS.HTTP.Response
{
    public class HtmlResponse : HttpResponse
    {
        public HtmlResponse(string html)
        {
            this.Headers.Add(new Header("Content-type", "text/html"));
            this.StatusCode = HttpReponseCode.Ok;
            byte[] byteData = Encoding.UTF8.GetBytes(html.ToString());
            this.Body = byteData;
            this.Headers.Add(new Header("Content-Length", this.Body.Length.ToString()));
        }
    }
}