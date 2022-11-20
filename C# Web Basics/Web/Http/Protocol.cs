using System.Text;

public abstract class Protocol
{
    protected string[]? headerAndBody;
    protected Protocol()
    {
        this.Headers = new List<(string, string)>();
        this.Cookies = new List<(string, string)>();
        this.sb = new StringBuilder();
    }
    
    public IList<(string, string)> Headers { get; set; }
    public string Version { get; set; } = "HTTP/1.1";
    public IList<(string, string)> Cookies { get; set; }

    protected StringBuilder sb { get; set;  }
    public byte[] Body { get; set; }
}