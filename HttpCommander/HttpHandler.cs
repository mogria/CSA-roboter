using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace HttpCommander
{
    class HttpHandler

    {
        TcpClient client;

        public HttpHandler(TcpClient client)
        {
            this.client = client;

        }

        internal void HandleRequest()
        {
            StreamReader tcpReader = new StreamReader(client.GetStream());
            StreamWriter tcpWriter = new StreamWriter(client.GetStream());
        }
    }
}
