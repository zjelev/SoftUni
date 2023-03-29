public class AddInfoHeader
{
    private readonly RequestDelegate next;

    public AddInfoHeader(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        //context.Response.Headers.Add("X-Length", context.Request.ContentLength.ToString());
        //context.Response.Headers.Add("X-Query", context.Request.QueryString.ToString());
        context.Response.WriteAsync("Hello from AddInfoHeader!");
        await next(context);
    }
}

