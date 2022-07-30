using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace HttpRequester
{
    class Program
    {
        static Dictionary<string, int> SessionStore = new Dictionary<string, int>();

        static async Task Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Loopback, 80);
            listener.Start();
            while (true)
            {
                var client = await listener.AcceptTcpClientAsync();
#pragma warning disable CS1014
                Task.Run(() => ProcessClientAsync(client));
#pragma warning restore CS1014
            }
        }

        private static async Task ProcessClientAsync(TcpClient client)
        {
            const string NewLine = "\r\n";
            using NetworkStream stream = client.GetStream();
            byte[] requestBytes = new byte[1000000];    // TODO: Use buffer
            int bytesRead = await stream.ReadAsync(requestBytes, 0, requestBytes.Length);
            string request = Encoding.UTF8.GetString(requestBytes, 0, bytesRead);
            
            var username = Regex.Match(request, @"Cookie: user=[\w]*").Value;
            var sid = Regex.Match(request, @"sid=[^\n]*\n").Value?.Replace("sid=", String.Empty).Trim();
            var newSid = Guid.NewGuid().ToString();
            var count = 0;
            if(SessionStore.ContainsKey(sid))
            {
                SessionStore[sid]++;
                count = SessionStore[sid];
            }
            else
            {
                sid = null;
                SessionStore[newSid] = 1;
                count = 1;
            }
            string responseText = 
"<h1>" + username + "</h1>" + 
"<h1>" + count + "</h1>" + 
//@"<form action='/Account/Login' method='post'> 
// <input type=date name='date' /> 
// <input type=text name='username' /> 
// <input type=password name='password' /> 
// <input type=submit name='Login' /> 
// </form>
"<h1>" + DateTime.UtcNow + "</h1>";

            byte[] fileContent = File.ReadAllBytes("Cat03.jpg");
            // Thread.Sleep(1000);

            string headers = "HTTP/1.0 200 OK" + NewLine +
                              "Server: MyFirstServer/1.0" + NewLine +
                              "Set-Cookie: lang=bg; Path=/lang" + NewLine +
                              (string.IsNullOrWhiteSpace(sid) ?
                                ("Set-Cookie: sid=" + newSid + NewLine)
                                : string.Empty) +
                              // "Set-Cookie: user=Niki; Expires=" + new DateTime(2023, 1, 1).ToString("R") + NewLine +
                              "Set-Cookie: user=Niki; Max-Age=3600; Secure; HttpOnly; SameSite=Strict" + NewLine +
                              "Content-Type: image/jpeg" + NewLine + // MIME type
                                                                    // "Location: https://google.com" + NewLine + //307
                                                                    // "Content-Disposition: attachement; filename=niki.html" + NewLine + 
                              "Content-Lenght: " //+ responseText.Length 
                                + fileContent.Length + NewLine + NewLine;
            
            byte[] headersBytes = Encoding.UTF8.GetBytes(headers);
            byte[] responseBytes = Encoding.UTF8.GetBytes(responseText);
            await stream.WriteAsync(headersBytes);
            //await stream.WriteAsync(responseBytes);
            await stream.WriteAsync(fileContent);
            // stream.Flush();
            Console.WriteLine(request);
            Console.WriteLine(new string('=', 60));
        }
    }
}