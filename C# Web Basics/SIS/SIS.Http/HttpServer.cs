using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SIS.Http
{
    public class HttpServer : IHttpServer
    {
        private readonly TcpListener listener;
        private readonly IList<Route> routeTable;

        public HttpServer(int port, IList<Route> routeTable)  //TODO: actions
        {
            this.listener = new TcpListener(IPAddress.Loopback, port);
            this.routeTable = routeTable;
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

        private async Task ProcessClientAsync(TcpClient client)
        {
            using NetworkStream stream = client.GetStream();
            try
            {
                byte[] requestBytes = new byte[1000000];    // TODO: Use buffer
                int bytesRead = await stream.ReadAsync(requestBytes, 0, requestBytes.Length);
                string requestAsString = Encoding.UTF8.GetString(requestBytes, 0, bytesRead);
                
                var request = new HttpRequest(requestAsString);
                var route = this.routeTable.FirstOrDefault(
                    x => x.HttpMethod == request.Method && x.Path == request.Path);
                HttpResponse response;
                if (route == null)
                {
                    response = new HttpResponse(HttpReponseCode.NotFound, new byte[0]);
                }
                else
                {
                    response = route.Action(request);
                }
                
                response.Headers.Add(new Header("Server", "SoftUniServer/1.0"));

                response.Cookies.Add(new ResponseCookie("sid", Guid.NewGuid().ToString())
                { HttpOnly = true, MaxAge = 3600 });


                byte[] responseBytes = Encoding.UTF8.GetBytes(response.ToString());
                await stream.WriteAsync(responseBytes);
                await stream.WriteAsync(response.Body);
                Console.WriteLine(requestAsString);
                Console.WriteLine(new string('=', 60));
            }
            catch (Exception ex)
            {
                var errorResponse = new HttpResponse(HttpReponseCode.InternalServerError, Encoding.UTF8.GetBytes(ex.ToString()));
                errorResponse.Headers.Add(new Header("Content-Type", "text/plain"));
                byte[] responseBytes = Encoding.UTF8.GetBytes(errorResponse.ToString());
                await stream.WriteAsync(responseBytes);
                await stream.WriteAsync(errorResponse.Body);
            }

        }
    }
}