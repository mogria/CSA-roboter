using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Reflection;

namespace HttpCommander
{
    class HttpHandler
    {
        TcpClient client;
        CommandInterpreter interpreter;
        string webroot;



        public HttpHandler(TcpClient client, CommandInterpreter interpreter, string webroot)
        {
            this.interpreter = interpreter;
            this.client = client;
            this.webroot = webroot;
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

                var method = httpFirstLine[0];
                if(method == "GET")
                {
                    var url = httpFirstLine[1];
                    readHeaders(tcpReader);
                    if(url == "/")
                    {
                        serveFromFileSystem(tcpWriter, "/index.txt");
                    }
                    else
                    {
                        serveFromFileSystem(tcpWriter, url);
                    }
                }
                else if(method == "POST")
                {
                    readHeaders(tcpReader);
                    if(httpFirstLine[1] == "/")
                    {
                        bool result = interpreter.ReadCommands(tcpReader);
                        if(result)
                        {
                            writeResponse(tcpWriter, 200);
                        }
                        else
                        {
                            writeResponse(tcpWriter, 500);
                        }
                    }
                    else
                    {
                        writeResponse(tcpWriter, 404);
                    }

                }
                else
                {
                    writeResponse(tcpWriter, 400, "Method not allowed");
                }

            }

            
        }

        private void readHeaders(StreamReader reader)
        {
            while (reader.ReadLine() != String.Empty) ;
        }

        private void serveFromFileSystem(StreamWriter writer, String fileToServe)
        {
            string file = webroot + fileToServe;


            if(File.Exists(file))
            {
                using (var reader = new StreamReader(File.OpenRead(webroot + fileToServe)))
                {
                    writeResponse(writer, 200, reader.ReadToEnd());
                }
            }
            else
            {
                writeResponse(writer, 404);
            }
            
        }

        private void writeResponse(StreamWriter writer, int status, String contents = null)
        {
            var statusTable = new Dictionary<int, String>
            {
                {200, "OK"},
                {400, "Bad Request"},
                {404, "Not Found"},
                {500, "Internal Server Error"}
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
