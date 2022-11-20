// var client = new HttpClient();
// var response = await client.GetAsync(args[0]);
// string result = await response.Content.ReadAsStringAsync();
// File.WriteAllText("index.html", result);

using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

public class Server
{
    private readonly TcpListener tcpListener;
    public const string NewLn = "\r\n";
    public Server(int port)
    {
        this.tcpListener = new TcpListener(IPAddress.Loopback, port);
    }

    public async Task StartAsync()
    {
        this.tcpListener.Start();
        while (true)
        {
            TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
#pragma warning disable CS4014
            //Task.Run(() => 
            ProcessClientASync(tcpClient);
#pragma warning restore CS4014
        }
    }

    private static async Task ProcessClientASync(TcpClient tcpClient)
    {
        using NetworkStream networkStream = tcpClient.GetStream();
        byte[] requestBytes = new byte[100000];
        int bytesRead = await networkStream.ReadAsync(requestBytes, 0, requestBytes.Length);
        string requestAsString = Encoding.UTF8.GetString(requestBytes, 0, bytesRead);
        var request = new Request(requestAsString);

        string content = "<h1>random page</h1>";
        if (request.Path == "/")
        {
            content = "<h1>Home page</h1>" +
            @"<form action=/users/login>
<input type='submit' value='Login' /></form>";
        }
        else if (request.Path == "/users/login?")
        {
            content = "<h1>Login page</h1>" +
            @"<form action='Account/Login' method='post'>
<input type=date name='date' />
<input type=text name='username' />
<input type=password name='password' />
<input type=submit value='Login' /></form>";
        }

        //var sid = Regex.Match(request, @"sid=[^\n]*\n").Value;
        string response = "HTTP/1.1 200 OK" + NewLn + //307
                        "Server: MySrv 1.0" + NewLn +
                        "Content-Type: text/html" + NewLn +
                        /* (string.IsNullOrWhiteSpace(sid) ?
                            "Set-Cookie: sid=" + Guid.NewGuid().ToString() + "; Max-Age=3600*24*7; SameSite=Strict;" + NewLn
                            : string.Empty) +  //prevent XSRF
                                               // "Location: https://google.com" + NewLn +
                                               //"Content-Disposition: attachment; filename=index.html" + NewLn + */
                        "Content-Lenght: " + content.Length + NewLn +
                        NewLn +
                        content;
        byte[] responseBytes = Encoding.UTF8.GetBytes(response);
        await networkStream.WriteAsync(responseBytes, 0, responseBytes.Length); // netstandard 2.0 compatible

        Console.WriteLine(request);
        Console.WriteLine(new string('=', 60) + DateTime.UtcNow);
    }

    public void Stop()
    {
        this.tcpListener.Stop();
    }
}