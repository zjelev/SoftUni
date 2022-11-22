public class FileResponse : Response
{
    public FileResponse(byte[] fileContent, string contentType) : base()
    {
        this.Body = fileContent;
        this.Headers.Add(new("Content-Type", contentType));
        this.Headers.Add(new("Content-Length", this.Body.Length.ToString()));
    }
}