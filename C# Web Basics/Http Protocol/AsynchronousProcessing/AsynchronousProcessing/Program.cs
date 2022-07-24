using System.Net;
using System.Net.Sockets;
using System.Text;

namespace HttpRequester
{
    class Program
    {
        static string NewLine = "\r\n";
        static async Task Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Loopback, 80);
            listener.Start();
            while (true)
            {
                var client = listener.AcceptTcpClient();
                using NetworkStream stream = client.GetStream();
                // TODO: Use buffer
                byte[] requestBytes = new byte[1000000];
                int bytesRead = stream.Read(requestBytes, 0, requestBytes.Length);
                string request = Encoding.UTF8.GetString(requestBytes, 0, bytesRead);

                string responseText = @"<form action='/Account/Login' method='post'> 
<input type=date name='date' /> 
<input type=text name='username' /> 
<input type=password name='password' /> 
<input type=submit name='Login' /> 
</form><h1>" + DateTime.UtcNow + "</h1>";
                // Thread.Sleep(1000);
                string response = "HTTP/1.0 200 OK" + NewLine +
                                  "Server: MyFirstServer/1.0" + NewLine +
                                  "Content-Type: text/html" + NewLine + //MIME type
                                                                        // "Location: https://google.com" + NewLine + //307
                                                                        // "Content-Disposition: attachement; filename=niki.html" + NewLine + 
                                  "Content-Lenght: " + responseText.Length +
                                  NewLine + NewLine +
                                  responseText;
                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                stream.Write(responseBytes, 0, responseBytes.Length);
                // stream.Flush();
                Console.WriteLine(request);
                System.Console.WriteLine(new string('=', 60));
            }
        }

        public static async Task HttpRequest()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "My Console Browser");
            var response = await client.GetAsync("https://softuni.bg");
            string result = await response.Content.ReadAsStringAsync();
            File.WriteAllText("index.html", result);
        }
    }
}

