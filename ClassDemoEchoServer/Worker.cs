using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ClassDemoEchoServer
{
    class Worker
    {
        public Worker()
        {

        }

        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 7);
            server.Start();

            while (true)
            {
                TcpClient socket = server.AcceptTcpClient(); //Venter på client
                using (StreamReader sr = new StreamReader(socket.GetStream()))
                using (StreamWriter sw = new StreamWriter(socket.GetStream()))
                {
                    string str = sr.ReadLine();
                    sw.WriteLine(str);
                    sw.Flush();
                }
            }
        }
    }
}