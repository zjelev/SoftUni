using System.Text;

var routeTable = new List<Route>();
routeTable.Add(new Route("GET", "/", Index));
routeTable.Add(new Route("GET", "/users/login?", Login));
routeTable.Add(new Route("POST", "/users/login", DoLogin));
routeTable.Add(new Route("GET", "/contact", Contact));
routeTable.Add(new Route("GET", "/favicon.ico", FavIcon));

static Response FavIcon(Request request)
{
    var file = File.ReadAllBytes("wwwroot/favicon.ico");
    return new FileResponse(file, "image/x-icon");
}

static Response Contact(Request request)
{
    return new HtmlResponse("<h1>contact page</h1>");
}

static Response Index(Request request)
{
    return new HtmlResponse("<h1>Home page</h1>" +
            @"<form action=/users/login>
<input type='submit' value='Login' /></form>");
}

static Response Login(Request request)
{
    return new HtmlResponse("<h1>Login page</h1>" +
            @"<form action='/users/login' method='post'>
<input type=date name='date' />
<input type=text name='username' />
<input type=password name='password' />
<input type=submit value='Login' /></form>");
}

static Response DoLogin(Request request)
{
    return new HtmlResponse("<h1>User logged in</h1>");
}

var server = new Server(80, routeTable);
await server.StartAsync();