using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace HttpCommander
{
    class HttpServer
    {
        private TcpListener tcpListener;
        public HttpServer()
        {
            
            tcpListener = new TcpListener(IPAddress.Any, 8080);
        }

        public void Start()
        {
            tcpListener.Start();

            while(true)
            {
                Console.WriteLine("Waiting for connections ... ");
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                Console.WriteLine("Got connection from: " + tcpClient.ToString());
                var handler = new HttpHandler(tcpClient);
                new Thread(handler.HandleRequest).Start();
            }
        }
    }
}
