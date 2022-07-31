using System.Text;

namespace SIS.Http
{
    public class HttpRequest
    {
        public HttpRequest(string httpRequestAsString )
        {
            this.Headers = new List<Header>();

            var lines = httpRequestAsString.Split(HttpConstants.NewLine, StringSplitOptions.None);
            var httpInfoHeader = lines[0];
            var infoHeaderParts = httpInfoHeader.Split(' ');
            if(infoHeaderParts.Length != 3)
            {
                throw new HttpServerException("Invalid HTTP header line");
            }

            var httpMethod = infoHeaderParts[0];
            
            // Enum.TryParse(httpMethod, out HttpMethodType type);
            this.Method = httpMethod switch
            {
                "POST"   => HttpMethodType.Post,
                "GET"    => HttpMethodType.Get,
                "PUT"    => HttpMethodType.Put,
                "DELETE" => HttpMethodType.Delete,
                _        => HttpMethodType.Unknown
            };

            this.Path = infoHeaderParts[1];

            var httpVersion = infoHeaderParts[2];
            this.Version = httpVersion switch
            {
                "HTTP/1.0" => HttpVersionType.Http10,
                "HTTP/1.1" => HttpVersionType.Http11,
                "HTTP/2.0" => HttpVersionType.Http20,
                _          => HttpVersionType.Http11
            };

            bool isInHeader = true;
            StringBuilder bodyBuilder = new StringBuilder();
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                if (string.IsNullOrWhiteSpace(line))
                {
                    isInHeader = false;
                    continue;
                }

                if(isInHeader)
                {
                    var headerParts = line.Split(": ", 2, StringSplitOptions.None);
                    if (headerParts.Length != 2)
                    {
                        throw new HttpServerException($"Invalid header: {line}");
                    }

                    var header = new Header(headerParts[0], headerParts[1]);
                    this.Headers.Add(header);
                }
                else
                {
                    bodyBuilder.AppendLine(line);
                }
                
            }

            //StringReader reader = new StringReader(httpRequestAsString);
            
        }
        public HttpMethodType Method { get; set; }

        public string Path { get; set; }

        public HttpVersionType Version { get; set; }

        public IList<Header> Headers { get; set; }
    }
}