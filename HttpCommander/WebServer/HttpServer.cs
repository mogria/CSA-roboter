using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using RobotCtrl;
using System.IO;

namespace HttpCommander
{
    class HttpServer
    {
        private TcpListener tcpListener;
        private Robot robot;
        private CommandInterpreter interpreter;


        public static string WebrootDirectory
        {
            get
            {
                string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
                return Path.GetDirectoryName(path) + "/webroot";
            }
        }

        public HttpServer()
        {
            
            tcpListener = new TcpListener(IPAddress.Any, 8080);
            robot = new Robot();
            interpreter = new CommandInterpreter(robot, WebrootDirectory + "/log.txt");
        }

        public void Start()
        {
            tcpListener.Start();

            while(true)
            {
                Console.WriteLine("Waiting for connections ... ");
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                Console.WriteLine("Got connection from: " + tcpClient.ToString());
                var handler = new HttpHandler(tcpClient, interpreter, WebrootDirectory);
                new Thread(handler.HandleRequest).Start();
            }
        }
    }
}
