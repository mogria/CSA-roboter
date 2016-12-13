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
            using (StreamReader tcpReader = new StreamReader(client.GetStream()))
            using (StreamWriter tcpWriter = new StreamWriter(client.GetStream()))
            {
                var httpFirstLine = tcpReader.ReadLine().Split(' ');
                if (httpFirstLine.Length != 3)
                {
                    writeResponse(tcpWriter, 400);
                }

            }

            
        }

        private void parseFirstLineHttp()
        {

        }

        private void writeResponse(StreamWriter writer, int status, String contents = null)
        {
            var statusTable = new Dictionary<int, String>
            {
                {200, "OK"},
                {400, "Bad Request"}
            };
            if(contents == null)
            {
                contents = statusTable[status];
            }

            writer.WriteLine("HTTP/1.0 " + status + " " + statusTable[status]);
            writer.WriteLine("Content-Type: text/plain");
            writer.WriteLine("Content-Length: " + contents.Length);
            writer.WriteLine("Connection: close"); 
            writer.WriteLine("");
            writer.WriteLine(contents);
        } 
    }
}
