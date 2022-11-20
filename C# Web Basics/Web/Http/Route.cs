public class Route
{
    public Route(string method, string path, Func<Request, Response> action)
    {
        this.Method = method;
        this.Path = path;
        this.Action = action;
    }
    public string Path { get; set; }
    public string Method { get; set; }
    public Func<Request, Response> Action { get; set; }

}