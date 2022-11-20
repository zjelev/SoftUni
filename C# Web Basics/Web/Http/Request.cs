using System.Text;

class Request : Protocol
{
    public Request(string httpRequestAsString)
    {
        this.headerAndBody = httpRequestAsString.Split(Server.NewLn + Server.NewLn, StringSplitOptions.None);
        
        var header = headerAndBody[0];
        var headerLines = header.Split(Server.NewLn);
        
        var methodPathVersion = headerLines[0].Split(' ');
        if (methodPathVersion.Length != 3)
        {
            throw new Exception("Invalid HTTP header line.");
        }
        this.Method = methodPathVersion[0];
        this.Path = methodPathVersion[1];
        this.Version = methodPathVersion[2];

        for (int i = 1; i < headerLines.Length; i++)
        {
            var line = headerLines[i];
            var headerParts = line.Split(": ", 2, StringSplitOptions.None);
            this.Headers.Add(new(headerParts[0], headerParts[1]));
        }

        var body = headerAndBody[1];
        var bodyLines = body.Split(Server.NewLn);
        for (int i = 0; i < body.Length; i++)
        {
            var line = bodyLines[i];
            this.toString.Append(line + Server.NewLn);
        }
        this.Body = Encoding.UTF8.GetBytes(toString.ToString().TrimEnd('\r', '\n'));
    }

    public string Method { get; set; }
    public string Path { get; set; }
}