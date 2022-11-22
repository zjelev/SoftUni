using System.Text;

public class HtmlResponse : Response
{
    public HtmlResponse(string html) : base()
    {
        this.Body = Encoding.UTF8.GetBytes(html);
        this.Headers.Add(new("Content-Type", "text/html"));
    }
}
