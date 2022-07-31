using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SIS.Http
{
    public class HttpServer : IHttpServer
    {
        private readonly TcpListener listener;
        public HttpServer(int port)  //TODO: actions
        {
            this.listener = new TcpListener(IPAddress.Loopback, port);
        }

        static Dictionary<string, int> SessionStore = new Dictionary<string, int>();

        public async Task ResetAsync()
        {
            this.Stop();
            await this.StartAsync();
        }

        public async Task StartAsync()
        {
            listener.Start();
            while (true)
            {
                var client = await listener.AcceptTcpClientAsync();
#pragma warning disable CS1014
                Task.Run(() => ProcessClientAsync(client));
#pragma warning restore CS1014
            }
        }

        public void Stop()
        {
            this.listener.Stop();
        }

        private static async Task ProcessClientAsync(TcpClient client)
        {
            using NetworkStream stream = client.GetStream();
            byte[] requestBytes = new byte[1000000];    // TODO: Use buffer
            int bytesRead = await stream.ReadAsync(requestBytes, 0, requestBytes.Length);
            string requestAsString = Encoding.UTF8.GetString(requestBytes, 0, bytesRead);
            var request = new HttpRequest(requestAsString);
            string content = "<h1>random page</h1>";
            if (request.Path == "/")
            {
                content = "<h1>home page</h1>";
            }
            else if (request.Path == "/users/login")
            {
                content = "<h1>login page</h1>" +
                @"<form method='post'><input type=date name='date' /> 
<input type=text name='username' /> 
<input type=password name='password' /> 
<input type=submit name='Login' /> 
</form>";
            }

            byte[] stringContent = Encoding.UTF8.GetBytes(content);
            var response = new HttpResponse(HttpReponseCode.Ok, stringContent);
            response.Headers.Add(new Header("Server", "SoftUniServer/1.0"));
            response.Headers.Add(new Header("Server", "SoftUniServer/1.0"));
            response.Headers.Add(new Header("Content-Type", "text/html"));
            

            byte[] responseBytes = Encoding.UTF8.GetBytes(response.ToString());
            await stream.WriteAsync(responseBytes);
            await stream.WriteAsync(response.Body);
            Console.WriteLine(requestAsString);
            Console.WriteLine(new string('=', 60));
        }
    }
}