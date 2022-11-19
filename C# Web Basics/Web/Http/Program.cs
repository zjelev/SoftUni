// var client = new HttpClient();
// var response = await client.GetAsync(args[0]);
// string result = await response.Content.ReadAsStringAsync();
// File.WriteAllText("index.html", result);

using System.Net;
using System.Net.Sockets;
using System.Text;

const string NewLn = "\r\n";
TcpListener tcpListener = new TcpListener(IPAddress.Any, 80);
tcpListener.Start();
while (true)
{
    TcpClient tcpClient = tcpListener.AcceptTcpClient();
    using NetworkStream networkStream = tcpClient.GetStream();
    byte[] requestBytes = new byte[100000];
    int bytesRead = networkStream.Read(requestBytes, 0, requestBytes.Length);
    string request = Encoding.UTF8.GetString(requestBytes, 0, bytesRead);

    string responseBody = @"<form action='Account/Login' method='post'>
<input type=date name='date' />
<input type=text name='username' />
<input type=password name='password' />
<input type=submit value='Login' />
";
    string response = "HTTP/1.1 200 OK" + NewLn + //307
                    "Server: MySrv 1.0" + NewLn +
                    "Content-Type: text/html" + NewLn + 
                    // "Location: https://google.com" + NewLn +
                    //"Content-Disposition: attachment; filename=index.html" + NewLn + 
                    "Content-Lenght: " + responseBody.Length + NewLn +
                    NewLn + 
                    responseBody;
    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
    networkStream.Write(responseBytes, 0, responseBytes.Length);
    
    Console.WriteLine(request);
    Console.WriteLine(new String('=', 60));
}