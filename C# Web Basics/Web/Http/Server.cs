using System.Net;
using System.Net.Sockets;
using System.Text;

public class Server
{
    private readonly TcpListener tcpListener;
    public const string NewLn = "\r\n";
    private readonly IList<Route> routeTable;

    public Server(int port, IList<Route> routeTable)
    {
        this.routeTable = routeTable;
        this.tcpListener = new TcpListener(IPAddress.Loopback, port);
    }

    public async Task StartAsync()
    {
        this.tcpListener.Start();
        while (true)
        {
            TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
#pragma warning disable CS4014
            ProcessClientASync(tcpClient);
#pragma warning restore CS4014
        }
    }

    private async Task ProcessClientASync(TcpClient tcpClient)
    {
        using NetworkStream networkStream = tcpClient.GetStream();
        byte[] requestBytes = new byte[100000];
        int bytesRead = await networkStream.ReadAsync(requestBytes, 0, requestBytes.Length);
        string requestAsString = Encoding.UTF8.GetString(requestBytes, 0, bytesRead);
        var request = new Request(requestAsString);
        var route = this.routeTable.FirstOrDefault(x => x.Method == request.Method && x.Path == request.Path);
        Response response;
        if (route == null)
        {
            response = new Response(404, new byte[0]);
        }
        else
        {
            response = route.Action(request);
        }

        response.Headers.Add(new("Server", "MySrv 1.0"));
        byte[] headerBytes = Encoding.UTF8.GetBytes(response.ToString());
        await networkStream.WriteAsync(headerBytes, 0, headerBytes.Length);
        await networkStream.WriteAsync(response.Body, 0, response.Body.Length);

        Console.WriteLine(requestAsString);
        Console.WriteLine(new string('=', 60) + DateTime.UtcNow);
    }

    public void Stop()
    {
        this.tcpListener.Stop();
    }
}