using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Sockets;
using System.Net;
using System.Drawing;
using System.Security.Policy;

namespace WinFormsApp_RSAReciever
{
    internal class ServerConnection
    {
        private Socket server;
        private Socket client;

        public delegate void ServerTextEventHandler(object sender, ServerTextEventArgs e);

        public event ServerTextEventHandler ServerTextEvent;

        public ServerConnection(byte[] publicKey)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint endPoint = new IPEndPoint(ip, 13);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(endPoint);

            ConnectToClient();

            WriteKey(publicKey);
        }

        private void ConnectToClient()
        {
            server.Listen(100);
            client = server.Accept();
        }

        private void WriteKey(byte[] publicKey)
        {
            client.Send(publicKey, 0);
        }

        public void StartRecieving()
        {
            try
            {
                while (true)
                {
                    if (client.Connected)
                    {
                        int size = 0;
                        byte[] buff = new byte[client.Available];

                        while ((size = client.Receive(buff)) > 0)
                        {

                            //byte[] recievedBytes = Byte.  new byte[size];
                            TextRecieved(buff);
                        }
                    }
                    else
                    {
                        client.Listen(0);
                        client = client.Accept();
                    }
                }
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }



            //try
            //{
            //    while (true)
            //    {
            //        if (client != null)
            //        {

            //            if (client.ReceiveBufferSize > 0)
            //            {
            //                byte[] buffer = new byte[client.ReceiveBufferSize];
            //                var recieved = client.Receive(buffer, SocketFlags.None);


            //                if (buffer != null)
            //                {
            //                    TextRecieved(buffer);
            //                }
            //            }
            //            else if (!client.Connected)
            //            {
            //                ConnectToClient();
            //            }
            //        }

            //    }
            //}
            //catch (Exception e)
            //{

            //    throw;
            //}

        }

        public void TextRecieved(byte[] bytes = null)
        {
            ServerTextEvent?.Invoke(this, new ServerTextEventArgs(bytes));
        }
    }
}
