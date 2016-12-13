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

        public static string WebrootDirectory
        {
            get
            {
                string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
                return Path.GetDirectoryName(path) + "/webroot";
            }
        }


        public HttpHandler(TcpClient client)
        {
            this.client = client;
            //get the full location of the assembly with DaoTests in it
            AppDomain.CurrentDomain.B
            string fullPath = typeof(HttpCommander).Assembly.GetD

            //get the folder that's in
            string theDirectory = Path.GetDirectoryName(fullPath);
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
                        // @todo send stream further to interpreter
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
            string file = WebrootDirectory + fileToServe;


            if(File.Exists(file))
            {
                using (var reader = new StreamReader(File.OpenRead(WebrootDirectory + fileToServe)))
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
                {404, "Not Found"}
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
