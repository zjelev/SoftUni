public class Response : Protocol
{
    public Response(int code, byte[] body)
    {
        this.Code = code;
        this.Body = body;
        if (body?.Length > 0)
        {
            this.Headers.Add(new ("Content-Length", body.Length.ToString()));
        }
    }

    internal Response() : base()
    {
    }
    
    public int Code { get; set; }

    public override string ToString()
    {
        this.sb.Append($"{this.Version} {this.Code}" + Server.NewLn);
        foreach (var header in this.Headers)
        {
            sb.Append(header.Item1 + ": " + header.Item2 + Server.NewLn);
        }
        return sb.ToString() + Server.NewLn;
    }
}