using System.Text;

var routeTable = new List<Route>();
routeTable.Add(new Route("GET", "/", Index));
routeTable.Add(new Route("GET", "/users/login?", Login));
routeTable.Add(new Route("POST", "/users/login", DoLogin));
routeTable.Add(new Route("GET", "/contact", Contact));
routeTable.Add(new Route("GET", "/favicon.ico", FavIcon));

static Response FavIcon(Request request)
{
    throw new NotImplementedException();
}

static Response Contact(Request request)
{
    var content = "<h1>contact page</h1>";
    byte[] byteContent = Encoding.UTF8.GetBytes(content);
    var response = new Response(200, byteContent);
    response.Headers.Add(new("Content-Type", "text/html"));
    return response;
}

static Response Index(Request request)
{
    var content = "<h1>Home page</h1>" +
            @"<form action=/users/login>
<input type='submit' value='Login' /></form>";
    byte[] byteContent = Encoding.UTF8.GetBytes(content);
    var response = new Response(200, byteContent);
    response.Headers.Add(new("Content-Type", "text/html"));
    return response;
}

static Response Login(Request request)
{
    var content = "<h1>Login page</h1>" +
            @"<form action='/users/login' method='post'>
<input type=date name='date' />
<input type=text name='username' />
<input type=password name='password' />
<input type=submit value='Login' /></form>";
    byte[] byteContent = Encoding.UTF8.GetBytes(content);
    var response = new Response(200, byteContent);
    response.Headers.Add(new("Content-Type", "text/html"));
    return response;
}

static Response DoLogin(Request request)
{
    var content = "<h1>User logged in</h1>";
    byte[] byteContent = Encoding.UTF8.GetBytes(content);
    var response = new Response(200, byteContent);
    response.Headers.Add(new("Content-Type", "text/html"));
    return response;
}

var server = new Server(80, routeTable);
await server.StartAsync();