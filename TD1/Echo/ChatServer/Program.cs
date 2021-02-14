using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace Echo
{
    class EchoServer
    {
        [Obsolete]
        static void Main(string[] args)
        {

            Console.CancelKeyPress += delegate
            {
                System.Environment.Exit(0);
            };

            TcpListener ServerSocket = new TcpListener(5000);
            ServerSocket.Start();

            Console.WriteLine("Server started.");
            while (true)
            {
                TcpClient clientSocket = ServerSocket.AcceptTcpClient();
                handleClient client = new handleClient();
                client.startClient(clientSocket);
            }


        }
    }

    public class handleClient
    {
        TcpClient clientSocket;
        public void startClient(TcpClient inClientSocket)
        {
            this.clientSocket = inClientSocket;
            Thread ctThread = new Thread(Echo);
            ctThread.Start();
        }



        private void Echo()
        {
            NetworkStream stream = clientSocket.GetStream();
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);

            while (true)
            {

                string str = reader.ReadString();
                Console.WriteLine("RECU "+str);
                if(str.StartsWith("GET"))
                {
                    writer.Write(parsePath(str));
                }
                else
                {
                    writer.Write("ERREUR REQUETE");

                }
            }
        }

        private String parsePath(String path)
        {
            String res = "http:/1.0 ";
         
            if (path.Split(" ").Length>1&&path.Split(" ")[1].StartsWith("/"))
            {
                try {
                    String html = File.ReadAllText("../../../www/pub" + path.Split(" ")[1]);
                    return html;

                }
                catch
                {
                    return res+"404 NOT FOUND";
                }

                }
            return res + "404 NOT FOUND";
        }



    }

}