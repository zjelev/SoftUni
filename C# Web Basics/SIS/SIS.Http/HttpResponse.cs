using System.Collections;
using System.Text;

namespace SIS.Http
{
    public class HttpResponse
    {
        public HttpResponse(HttpReponseCode statusCode, byte[] body)
        {
            this.Version = HttpVersionType.Http11;
            this.StatusCode = statusCode;
            this.Headers = new List<Header>();
            this.Cookies = new List<ResponseCookie>();
            this.Body = body;

            if (body?.Length > 0)
            {
                this.Headers.Add(new Header("Content-Length", body.Length.ToString()));
            }
        }
        public HttpVersionType Version { get; set; }
        public HttpReponseCode StatusCode { get; set; }
        public IList<Header> Headers { get; set; }
        public IList<ResponseCookie> Cookies { get; set; }
        public byte[] Body { get; set; }

        public override string ToString()
        {
            var responseAsString = new StringBuilder();
            var httpVersionAsString = this.Version switch
            {
                HttpVersionType.Http10 => "HTTP/1.0",
                HttpVersionType.Http11 => "HTTP/1.1",
                HttpVersionType.Http20 => "HTTP/2.0",
                _ => "HTTP/1.0",
            };
            responseAsString.Append($"{httpVersionAsString} {(int)this.StatusCode} {this.StatusCode}");
            foreach (var header in this.Headers)
            {
                responseAsString.Append(header + HttpConstants.NewLine);
            }

            foreach (var cookie in this.Cookies)
            {
                responseAsString.Append($"Set-Cookie: {cookie}" + HttpConstants.NewLine);
            }

            responseAsString.Append(HttpConstants.NewLine);

            return responseAsString.ToString();
        }
    }
}