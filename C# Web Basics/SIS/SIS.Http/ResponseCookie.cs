using System.Text;

namespace SIS.Http
{
    public class ResponseCookie : Cookie
    {
        public ResponseCookie(string name, string value) : base(name, value)
        {
            this.SameSite = SameSiteType.None;
            this.Path = "/";
            this.Expires = DateTime.UtcNow.AddDays(30);
        }

        public string Domain { get; set; } = null!;
        public string Path { get; set; }
        public DateTime? Expires { get; set; }
        public long? MaxAge { get; set; }
        public bool Secure { get; set; }
        public bool HttpOnly { get; set; }
        public SameSiteType SameSite { get; set; }

        public override string ToString()
        {
            StringBuilder cookieBulder = new StringBuilder();
            cookieBulder.Append($"{this.Name}={this.Value}");
            if (this.MaxAge.HasValue)
            {
                cookieBulder.Append($"; Max-Age=" + this.MaxAge.Value.ToString());
            }
            else if(this.Expires.HasValue)
            {
                cookieBulder.Append($"; Expires=" + this.Expires.Value.ToString("R"));
            }

            if (!string.IsNullOrWhiteSpace(this.Domain))
            {
                cookieBulder.Append($"; Domain=" + this.Domain);
            }
            
            if (!string.IsNullOrWhiteSpace(this.Path))
            {
                cookieBulder.Append($"; Path=" + this.Path);
            }

            if (this.Secure)
            {
                cookieBulder.Append($"; Secure=");
            }

            if (this.HttpOnly)
            {
                cookieBulder.Append($"; HttpOnly=");
            }

            cookieBulder.Append($"; SameSite=" + this.SameSite.ToString());

            return cookieBulder.ToString();
        }
    }
}