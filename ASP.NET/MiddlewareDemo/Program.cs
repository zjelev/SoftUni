using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDistributedMemoryCache();
//builder.Services.AddSession();
var app = builder.Build();

//app.UseWelcomePage();

app.Use(async (context, next) =>
{
    context.Response.Headers.Add("X-Hello", "Hello from my midleware ");
    context.Items.Add("Username", "Niki");
    await next();
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("...Before...");
    if (DateTime.Now.Second % 2 == 0)
        await next();

    await context.Response.WriteAsync("...After...");
    await context.Response.WriteAsync(context.Items["Username"].ToString());
});

app.MapGet("/", (HttpContext http) =>
{
    http.Response.WriteAsync("Hello from MapGet/ ");
    http.Response.WriteAsync(http.Request.Headers["User-agent"]);
    //http.Session.Set("UserId", new byte[] { 0x0 });
});

app.Map("/SoftUni", builder =>
    builder.Run((context) => context.Response.WriteAsync("Hello from SoftUni Map")));

app.UseMiddleware<AddInfoHeader>();

var supportedCultures = new string[] { "bg-BG", "en-US" };
app.UseRequestLocalization(options =>
    options.AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures)
    .SetDefaultCulture("bg-BG")
    .RequestCultureProviders.Insert(0, new CustomRequestCultureProvider(context =>
    {
        return Task.FromResult(new ProviderCultureResult("bg-BG"));
    }))
);

// app.UseSession();

app.Run();