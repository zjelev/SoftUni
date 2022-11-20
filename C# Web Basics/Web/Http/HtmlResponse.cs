using System.Text;

public class HtmlResponse : Response
{
    public HtmlResponse(string html) : base()
    {
        this.Code = 200;
        byte[] byteData = Encoding.UTF8.GetBytes(html);
        this.Body = byteData;
        this.Headers.Add(new("Content-Type", "text/html"));
    }
}
