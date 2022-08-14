using System.Text;
using SIS.Http;

namespace SIS.HTTP.Response
{
    public class HtmlResponse : HttpResponse
    {
        public HtmlResponse(string html)
        {
            this.StatusCode = HttpReponseCode.Ok;
            byte[] byteData = Encoding.UTF8.GetBytes("<html><body>" + html.ToString() + "</body></html>");
            this.Body = byteData;
            this.Headers.Add(new Header("Content-type", "text/html"));
            this.Headers.Add(new Header("Content-Length", this.Body.Length.ToString()));
        }
    }
}